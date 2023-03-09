using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class TaskDelayCode : MonoBehaviour
{
  
    void Start()
    {
        print("Haris");
        Task.Delay(2000).Wait(2000);
        print("Ahmed");
    }


   
}
