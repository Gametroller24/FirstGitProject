using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //appcontroller
        gameObject.GetComponent<AudioSource>().Play();
    }
}