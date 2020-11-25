using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private float hor, ver;
    public float Speed,TurnSpeed;
    private Rigidbody rig;
    public float Hit;

    private void Start()
    {
        rig = this.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        //transform.position += transform.forward * ver * hor* Time.deltaTime * Speed;
        if (ver!=0||hor!=0)
        {
            transform.position += transform.forward * ver * Time.deltaTime * Speed;
            transform.position += transform.right * hor * Time.deltaTime * Speed;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rig.velocity = transform.forward * Hit;
        }
        Debug.Log(rig.velocity);
       
    }
}
