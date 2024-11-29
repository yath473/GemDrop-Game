using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    public GameObject stone;
    public GameObject stone2;
    public GameObject stone3;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 1, 5);
        InvokeRepeating("Spawn2", 1, 2);
        InvokeRepeating("Spawn3", 1, 10);
    }
    void Spawn() 
    {
        float z = Random.Range(0, 20);
        float x = Random.Range(-z - 20.2f, z + 20.2f);
        Instantiate(stone, new Vector3(x, 50, z), Quaternion.identity);
    }
    void Spawn2() 
    {
        float z = Random.Range(0, 20);
        float x = Random.Range(-z - 20.2f, z + 20.2f);
        Instantiate(stone2, new Vector3(x, 50, z), Quaternion.identity);
    }
    void Spawn3()
    {
        float z = Random.Range(0, 20);
        float x = Random.Range(-z - 20.2f, z + 20.2f);
        Instantiate(stone3, new Vector3(x, 50, z), Quaternion.identity);
    }

    /*using System.Collections; 
     * using System.Collections.Generic; 
     * using System.Net;
     * using UnityEngine; 
     * using UnityEngine.Experimental.GlobalIllumination; 
     * public class SpawnFood : MonoBehaviour {     
     * public GameObject cookie;     public GameObject tomato;     
     * void Start()     
     * {         
     * InvokeRepeating("Spawn", 1, 5);     
     * }      
     * void Update()     
     * {              
     * }     
     * void Spawn()     
     * {         
     * float z = Random.Range(0, 10);        
     * float x = Random.Range(z-3.7f, z+3.7f);        
     * int p = Random.Range(1, 4);        
     * if (p == 3)         
     * {            
     * Instantiate(tomato, new Vector3(x, 10, z), new Quaternion());       
     * }         else        
     * {          
     * Instantiate(cookie, new Vector3(x, 10, z), new Quaternion());        
     * }     
     * } 
     * }*/

}
