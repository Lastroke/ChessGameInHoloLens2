using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pozisyon : MonoBehaviour
{
    public static Vector3 position;
    Rigidbody rb;
    
    private void OnTriggerEnter(Collider other)
    {
        position = new Vector3(other.transform.position.x, other.transform.position.y + 0.5f, other.transform.position.z);
        transform.position = position;
    }

    public void freezeConstraint()
    {
        rb = GetComponent<Rigidbody>();
        if (Turn.isWhiteTurn)
        {
            if (gameObject.tag == "Black")
            {
                rb.constraints = RigidbodyConstraints.FreezeAll;
            }
            else
            {
                rb.constraints = RigidbodyConstraints.None;
                rb.constraints = RigidbodyConstraints.FreezeRotation;
            }
        }
        else
        {
            if (gameObject.tag == "Black")
            {
                rb.constraints = RigidbodyConstraints.None;
                rb.constraints = RigidbodyConstraints.FreezeRotation;
            }
            else
            {
                rb.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }
}
