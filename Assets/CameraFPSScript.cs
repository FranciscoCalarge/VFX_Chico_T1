using System.Threading;
using UnityEngine;

public class CameraFPSScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * 12;
        transform.position += transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * 12;

        transform.Rotate(Vector3.up, Input.GetAxis("Mouse X")*Time.deltaTime*600);

    }
}
