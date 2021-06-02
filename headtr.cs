using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class headtr : MonoBehaviour
{
	float xRotate;
	float yRotate;
	float sens = 5f;

	public GameObject tr;
	public GameObject textic;
	public GameObject key;
	public GameObject light;
	public GameObject end;
	public GameObject man;
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

        RaycastHit hit;
        Debug.DrawRay(transform.position, transform.forward * 3f, Color.red);
        if(Physics.Raycast(transform.position, transform.forward, out hit, 3f))
        {
        	if(hit.collider.gameObject.tag == "true")
        	{
        		tr.SetActive(true);
        	}

        	if(hit.collider.gameObject.tag == "man")
        	{
        		man.SetActive(true);
        	}

        	if(hit.collider.gameObject.tag == "statue")
        	{
        		textic.SetActive(true);
        	}

        	if(hit.collider.gameObject.tag == "light")
        	{
        		light.SetActive(true);
        	}

        	if(hit.collider.gameObject.tag == "end")
        	{
        		end.SetActive(true);
        		SceneManager.LoadScene("scene4");
        	}
    	}
    }

    public void OnClick()
    {
    	 tr.SetActive(false);

    }

    public void Click()
    {
    	 man.SetActive(false);

    }

    public void Close()
    {
    	textic.SetActive(false);
    }

    public void l()
    {
    	light.SetActive(false);
    }

    public void e()
    {
    	end.SetActive(false);
    	key.SetActive(true);
    }

    
}
