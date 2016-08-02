using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    public float speed = 25;
    public Rigidbody rb;
    public GameObject player;

    void start()
    {
    
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + transform.forward * speed * Time.deltaTime);
        transform.LookAt(player.transform.position);
    }
}