using System.Threading;
using UnityEngine;

public class CameraFPSScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward*Input.GetAxis("Vertical")*Time.deltaTime*12;
        transform.RotateAround(transform.position, transform.up, Input.GetAxis("Horizontal")*Time.deltaTime*60);
    }
}
