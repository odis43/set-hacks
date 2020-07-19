using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bill : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {

       
        FindObjectOfType<audiomanager>().Play("Bill");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
