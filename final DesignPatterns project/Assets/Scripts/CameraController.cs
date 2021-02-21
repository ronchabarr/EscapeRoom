using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class CameraController : MonoBehaviour
{
    public float sensitivity;
    public float smoothing;

    private GameObject player;
    private Vector2 smoothedVelocity;
    private Vector2 currentLookingPos;

    void Start()
    {
        player = transform.parent.gameObject;
        Cursor.lockState = CursorLockMode.Locked;
      //  Cursor.visible = false;
    }

    void Update()
    {
        RotateCamera();
    }

    private void RotateCamera()
    {
        Vector2 values = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        values = Vector2.Scale(values, new Vector2(sensitivity * smoothing, sensitivity * smoothing));

        smoothedVelocity.x = Mathf.Lerp(smoothedVelocity.x, values.x, 1f / smoothing);
        smoothedVelocity.y = Mathf.Lerp(smoothedVelocity.y, values.y, 1f / smoothing);

        currentLookingPos += smoothedVelocity;

        transform.localRotation = Quaternion.AngleAxis(Mathf.Clamp(-currentLookingPos.y, -70,70), Vector3.right);

        player.transform.localRotation = Quaternion.AngleAxis(currentLookingPos.x, player.transform.up);
    }
}

