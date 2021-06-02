using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class heade : MonoBehaviour
{
	float xRotate;
	float yRotate;
	float sens = 5f;

	static int time = 30;
    public GameObject text_object;
    Text time_text;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MyTimer", 1f, 1f);
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
        Debug.DrawRay(transform.position, transform.forward * 2f, Color.red);
        if(Physics.Raycast(transform.position, transform.forward, out hit, 2f))
        {
            if(hit.collider.gameObject.tag == "president")
            {
                SceneManager.LoadScene("scene5");
            }
        }
    }

    void MyTimer()
    {
        time = time - 1;
        if(time == 0)
            {
                SceneManager.LoadScene("scene5");
            }
        FindObjectOfType<tb>().changeValue(time);
    }
}
