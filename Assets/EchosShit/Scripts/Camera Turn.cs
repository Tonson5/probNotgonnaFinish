using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTurn : MonoBehaviour
{
    public float rotationSpeed = 5f;
    void Update()
{
    // Get the mouse position in world space
    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    // Calculate the direction from the object to the mouse
    Vector3 direction = mousePosition - transform.position;

    // Set the z-coordinate of direction to zero since we're in 2D
    direction.z = 0;

    // Calculate the target angle
    float targetAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

    // Get the current angle of the object
    float currentAngle = transform.eulerAngles.z;

    // Smoothly interpolate between the current angle and the target angle
    float angle = Mathf.LerpAngle(currentAngle, targetAngle, rotationSpeed * Time.deltaTime);

    // Apply the rotation
    transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
}
}