using System.Threading;
using UnityEngine;

public class CameraFPSScript : MonoBehaviour
{
    private float rotateX, rotateY = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotateX = 0;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * 12;
        transform.position += transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * 12;

        rotateX+=Input.GetAxis("Mouse Y") *Time.deltaTime*200;
        rotateX = Mathf.Clamp(rotateX, -50, 50f);
        rotateY += Input.GetAxis("Mouse X") * Time.deltaTime * 200;

        transform.localEulerAngles = Vector3.right * -rotateX+ Vector3.up * rotateY;


    }
}
