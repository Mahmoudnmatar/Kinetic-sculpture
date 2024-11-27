using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         float Y = Mathf.Sin(Time.time);


        transform.rotation = Quaternion.Euler(new Vector3(0 , Y*45f,0 ));
        
    }
}
