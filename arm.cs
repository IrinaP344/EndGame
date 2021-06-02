using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    	
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown (0)) {
	      Ray ray = Camera.main.ScreenPointToRay (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 1));
	      RaycastHit _hit;
        if (Physics.Raycast (ray, out _hit, Mathf.Infinity)) {
        if (_hit.transform.tag == "PickUp") {
          Destroy (_hit.transform.gameObject);
        }
      }
    }
    }
}
