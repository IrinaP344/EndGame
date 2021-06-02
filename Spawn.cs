using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
	GameObject bullet;
	Rigidbody bullet_rb;
	public GameObject bullet1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e"))
        {
        	bullet = Instantiate(bullet1, transform.position, Quaternion.Euler(90f + transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0));
            bullet_rb = bullet.GetComponent<Rigidbody>();
            bullet_rb.AddForce(transform.forward * 3000f);
        }
    }
}
