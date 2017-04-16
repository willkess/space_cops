using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkMove : MonoBehaviour
{
    private Rigidbody rb;

    public GameObject p;
    public GameObject box;
    public Vector3 start;
    public Vector3 v;
    public float qe;
    //public bool despawn;
    // Use this for initialization
    void Start()
    {
        p = GameObject.FindGameObjectWithTag("Player");
        box = GameObject.FindGameObjectWithTag("Box");
        v.y = 2;
        v.x = Random.Range(-1f, 1f);
        v.z = Random.Range(-1f, 1f);
        qe = 2;
        rb = GetComponent<Rigidbody>();
        
        rb.velocity = v;
        rb.angularVelocity = Random.insideUnitSphere * qe;
        //despawn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag=="Box")
        {
            GameObject.Destroy(gameObject);
            //despawn = true;
        }


    }
}