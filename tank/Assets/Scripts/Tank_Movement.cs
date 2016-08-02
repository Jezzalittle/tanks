using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tank_Movement : MonoBehaviour
{
    public float speed = 100f;
    public float rotSpeed = 90f;
    public Rigidbody rb;
    
    void start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public Canvas UIRotBody;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (vertical == 1)
        {
            transform.position = transform.position + transform.forward * speed * Time.deltaTime; 
        }
        if (vertical == -1)
        {
            transform.position = transform.position + -transform.forward * speed * Time.deltaTime;
        }
        transform.Rotate(Vector3.up * horizontal * Time.deltaTime *rotSpeed);

        UIRotBody.GetComponentInChildren<Image>().transform.Rotate(0,0,-horizontal * Time.deltaTime * rotSpeed);

    }

}