using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiateball : MonoBehaviour
{
    public static GameObject ball;
    public GameObject ball_prefabs;
    private void Start()
    {
        ball = Instantiate(ball_prefabs, new Vector3(0.19f, 0.1f, 0), Quaternion.identity);
        GameObject.Find("Cube").GetComponent<ClothScript>().Clothcomponent();
    }
    // Start is called before the first frame update
    public void Returnball()
    {
        print("returnball");
        ball = Instantiate(ball_prefabs, new Vector3(0.19f, 0.1f, 0), Quaternion.identity);
        GameObject.Find("Cube").GetComponent<ClothScript>().Clothcomponent();
    }
    
}
