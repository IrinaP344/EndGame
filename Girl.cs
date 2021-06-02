using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Girl : MonoBehaviour
{
	float ws;
	float ad;
	float yRotate;
	Animator anim;

	Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        ws = Input.GetAxis("Vertical");
        rb.velocity = transform.forward *ws * 3f;


		
		if(ws!=0)
		{
			anim.SetBool("isRun", true);
		}else{
			anim.SetBool("isRun", false);
		}
	}

	public void SomeMethod(float val)
    {
    	yRotate = val;
    	transform.rotation = Quaternion.Euler(0, yRotate, 0);
    }
}
