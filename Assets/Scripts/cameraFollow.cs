using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public GameObject c;
    public GameObject d;
    public GameObject end;
    public float velocityY;
    public float velocityX;
    public float velocityZ;
    public float speed;
    float timer = 0;
    Vector3 off;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        timer = 0;
        off = transform.position - c.transform.position;
        rb = GetComponent<Rigidbody>();
        velocityY = -5 * PlayerPrefs.GetFloat("For_Speed");
        speed = 5 * PlayerPrefs.GetFloat("Move");
    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        c.transform.position = transform.position - off;
        d.transform.position = transform.position - off;
        d.transform.position = new Vector3(d.transform.position.x, d.transform.position.y + 5, d.transform.position.z);
    }

    private void FixedUpdate()
    {
        velocityX = 0;  
        velocityZ = 0;
        if (end.GetComponent<End>().lose == 1)
        {
            velocityY = 0;
        }
        if (Input.GetKey(KeyCode.W))
        {
            velocityZ += speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocityX -= speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocityZ -= speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocityX += speed;
        }


        rb.velocity = new Vector3(velocityX, velocityY, velocityZ);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (timer <= 0)
        {
            end.GetComponent<End>().life--;
            end.GetComponent<End>().deplete++;
            end.GetComponent<End>().done2 = 1;
            timer = 2;
        }
    }
}
