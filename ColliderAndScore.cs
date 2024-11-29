using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class paddlecollider : MonoBehaviour
{
    
    

}
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class paddlecollider : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highText;
    public int score = 0;
    //public ParticleSystem particle;
    //public ParticleSystem particle2;
    //public ParticleSystem particle3;

    // Start is called before the first frame update
    void Start()
    {
        //scoreText = GetComponent<Text>();
        scoreText.SetText("Score: "+score);
        highText.SetText("HighScore: "+PlayerPrefs.GetInt("HighScore").ToString()); 
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText("Score: " + score);
        highText.SetText("HighScore: " + PlayerPrefs.GetInt("HighScore").ToString());
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "stone")
        {
            Debug.Log("Collision detected with " + collision.gameObject.name);
            Destroy(collision.gameObject);
            //particle.Explode();
            score++;
        }
        else if (collision.gameObject.tag == "stone2")
        {
            Debug.Log("Collision detected with " + collision.gameObject.name);
            Destroy(collision.gameObject);
            //particle2.Explode();
            score--;
        }
        else if (collision.gameObject.tag == "stone3") 
        {
            Debug.Log("Collision detected with " + collision.gameObject.name);
            Destroy(collision.gameObject);
            //particle3.Explode();
            score += 2;
        }
    }
    public void GemPickup() 
    {
        scoreText.SetText("Score: " + score);
        //scoreText.SetText("Score: " + score);
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highText.SetText("HighScore: "+score.ToString());
        }
    }
    

}*/