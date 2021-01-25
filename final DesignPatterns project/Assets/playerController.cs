using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float MouseSensetivity;
    [SerializeField]Transform playerBody;

    Rigidbody rb;
    Vector2 moveDirection;
    Vector2 Rotation;
    float rotationX;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        moveDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Rotation = new Vector2(Input.GetAxis("Mouse X") * MouseSensetivity * Time.deltaTime, Input.GetAxis("Mouse Y") * MouseSensetivity * Time.deltaTime);
        rotationX -= Rotation.y;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        Debug.Log(Rotation);
        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        playerBody.Rotate(Vector3.up * Rotation.x);
    }
    public void FixedUpdate()
    {
        rb.AddRelativeForce(new Vector3(moveDirection.x, 0, moveDirection.y)*speed);
        
       
       

    }

}
