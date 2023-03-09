using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSwipe : MonoBehaviour
{
    
    
    public float ThroughforceinXandY;
    
     public float throughforceinZ;
    Rigidbody rb;
    private Vector2 startpos, endpos,direction,mousepos;
    float touchtimestart, touchtimefinish, timeinterval, timeM;
    private bool isdragging = false;
    private bool check=true;
    private void Start()
    {
        
        if ((Screen.width == 720 && Screen.height == 1280 ))
        {
            throughforceinZ = 80f;
            ThroughforceinXandY = 0.8f;
        }
        else if((Screen.width == 480 && Screen.height == 800))
        {
            throughforceinZ = 100f;
            ThroughforceinXandY = 1f;
        }
        else if ((Screen.width == 1080 && Screen.height == 2160))
        {
            throughforceinZ =80f;
            ThroughforceinXandY = 0.4f;
        }
        else
        {
            throughforceinZ = 60f;
            ThroughforceinXandY = 0.3f;
        }
        rb = GetComponent<Rigidbody>();
    }
    
    private void OnMouseDown()
    {
        if (check)
        {
            print("incheck");
            touchtimestart = Time.time;
            startpos = Input.mousePosition;
            startpos = Camera.main.ScreenToWorldPoint(startpos);

            Invoke(nameof(destroyball), 10f);
            //appcontroller
            GameObject.Find("Sounds").transform.GetChild(0).GetComponent<AudioSource>().Play();
        }
        
       
    }
   void destroyball()
    {
        Destroy(gameObject);
    }
    /*void ColidrOff()
    {
        
        throughforceinZ=0;
        ThroughforceinXandY = 0;
    }*/
    private void OnMouseUp()
    {
        if (check)
        {
            check = false;
            //Invoke(nameof(ColidrOff), 2f);
            touchtimefinish = Time.time;
            timeinterval = touchtimefinish - touchtimestart;
            endpos = Input.mousePosition;
            direction = (startpos - endpos);
            rb.isKinematic = false;
            rb.AddForce(-direction.x * ThroughforceinXandY, -direction.y * ThroughforceinXandY * 1f, throughforceinZ / timeinterval * 2f);
            Invoke(nameof(Returnball1), 5);
        }
    }
    void Returnball1()
    {
        GameObject.Find("spawnmanager").GetComponent<Instantiateball>().Returnball();
    }

}
