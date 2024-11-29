using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class collision : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
            Debug.Log("Collision detected");
            Destroy(collision.gameObject);
    
    }



}
