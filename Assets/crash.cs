using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crash : MonoBehaviour
{
    private Vector3 m_preVelocity = Vector3.zero;//上一帧速度
    private Rigidbody rig; //刚体

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            ContactPoint contactPoint = collision.contacts[0];
            Vector3 newDir = Vector3.zero;
            Vector3 curDir = transform.TransformDirection(Vector3.forward);
            newDir = Vector3.Reflect(curDir, contactPoint.normal);
            Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, newDir);
            transform.rotation = rotation;
            rig.velocity = newDir.normalized * m_preVelocity.x / m_preVelocity.normalized.x;
        }
    }
}
