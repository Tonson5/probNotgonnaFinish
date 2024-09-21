using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float moveSpeed;
    public float sprintSpeed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.up * verticalInput * moveSpeed * Time.deltaTime * sprintSpeed);
        transform.Rotate(Vector3.back * horizontalInput * rotationSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprintSpeed = 1.5f;
        }

        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            sprintSpeed = 1;
        }
    }
}
