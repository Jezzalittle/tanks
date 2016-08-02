using UnityEngine;
using System.Collections;

public class Tank_Turret_Rotate : MonoBehaviour {

    public float rotSpeed = 90f;
    private float horizontal = 0;
    private Vector3 fwd;
    public GameObject bullet;
    public float BulletSpeed;



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey("q"))
        {
            horizontal = -1f;
        }
       else if (Input.GetKey("e"))
        {
            horizontal = 1f;
        }
        else
        {
            horizontal = 0;
        }
        transform.Rotate(Vector3.up * horizontal * Time.deltaTime * rotSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(bullet, transform.position + new Vector3(0,0.25f,0), transform.rotation) as GameObject;
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * BulletSpeed;
        }


    }
    


     

  
    




}
