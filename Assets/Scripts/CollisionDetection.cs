using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetection : MonoBehaviour
{
     
    public Text text;
    private GameObject coll;
    int scorecount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "plane"&& collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Goal").GetComponent<AudioSource>().Play();
            scorecount++;
            print(scorecount);
            text.text = "Score:" + scorecount;
           
        }
        
    }
   
}
