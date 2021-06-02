using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class head : MonoBehaviour
{
	public GameObject girl;
	public Transform body;
	public GameObject phone;
	public AudioSource audio;

    float xRotate;
    float yRotate;
    float sens = 5f;

	bool isBody = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xRotate = xRotate - Input.GetAxis("Mouse Y") * sens;
        yRotate = yRotate + Input.GetAxis("Mouse X") * sens;
        xRotate = Mathf.Clamp(xRotate, -90, 90);
        transform.rotation = Quaternion.Euler(xRotate, yRotate, 0);
        FindObjectOfType<Girl>().SomeMethod(yRotate);

    	girl.SetActive(false);

        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * 8f, Color.red);
        if(Physics.Raycast(transform.position, transform.forward, out hit, 8f))
        {
        	if(hit.collider.gameObject.tag == "phone")
        	{
        		girl.SetActive(true);
        		if(Input.GetKeyDown("space"))
        		{
        			phone.SetActive(true);
        			hit.transform.position = body.position;
        			hit.transform.SetParent(body);
        			isBody = true;
        			audio.Stop();
        			
        		}
        	}
    	}
    }

    public void OnClick()
    {
    	 girl.SetActive(false);

    }

    public void Oni()
    {
    	phone.SetActive(false);
        SceneManager.LoadScene("scene3");
    }
}
