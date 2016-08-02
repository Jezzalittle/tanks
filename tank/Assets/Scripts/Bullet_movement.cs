using UnityEngine;
using System.Collections;

public class Bullet_movement : MonoBehaviour {

    public GameObject explosion;

    void Update () {

        
	}

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosion,this.transform.position,this.transform.rotation);
        Destroy(this.gameObject);
        Debug.Log("hit");
    }
}
