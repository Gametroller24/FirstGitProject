using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothScript : MonoBehaviour
{
    
    public void Clothcomponent()
    {
        Cloth a = GetComponent<Cloth>();
        //a.sphereColliders = new ClothSphereColliderPair[1];
        var colliders = new ClothSphereColliderPair[1];
        colliders[0] = new ClothSphereColliderPair(Instantiateball.ball.GetComponent<SphereCollider>());
        a.sphereColliders = colliders;
    }
}
