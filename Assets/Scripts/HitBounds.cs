using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBounds : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bound1")
        {
            gameObject.transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z - 1),0.4f);
        }
        else if (other.gameObject.tag == "Bound2")
        {
            gameObject.transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1),0.4f);
        }
        else if (other.gameObject.tag == "Bound3")
        {
            gameObject.transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x + 1, transform.position.y, transform.position.z),0.4f);
        }
        else if (other.gameObject.tag == "Bound4")
        {
            gameObject.transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x - 1, transform.position.y, transform.position.z),0.4f);
        }
    }
}
