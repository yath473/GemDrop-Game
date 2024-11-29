using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Paddle : MonoBehaviour
{

    Vector3 paddle;
    Rigidbody rb;
    public int score = 0;
    public int speed = 100;
    //public Font myFont;
    public TMP_Text scoreText;
    public TMP_Text highText;
    public TMP_Text highText2;
    public TMP_Text highText3;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        scoreText.SetText("Score: " + score);
        highText.SetText("HighScore: " + PlayerPrefs.GetInt("HighScore").ToString());
        highText2.SetText("#2: " + PlayerPrefs.GetInt("#2").ToString());
        highText3.SetText("#3: " + PlayerPrefs.GetInt("#3").ToString());
        //scoreText = GetComponent<Text>().font();
    }
    // Update is called once per frame
    void Update()
    {
        paddle.x = Input.GetAxis("Horizontal");
        paddle.z = Input.GetAxis("Vertical");
        scoreText.SetText("Score: " + score);
        highText.SetText("HighScore: " + PlayerPrefs.GetInt("HighScore").ToString());
        highText2.SetText("#2: " + PlayerPrefs.GetInt("#2").ToString());
        highText3.SetText("#3: " + PlayerPrefs.GetInt("#3").ToString());

        Bounds();
        GemPickup();
    }
    void Bounds()
    {
        float zbound = Mathf.Clamp(transform.position.z, 0, 20);
        float xbound = Mathf.Clamp(transform.position.x, -zbound - 20.2f, zbound + 20.2f);
        transform.position = new Vector3(xbound, transform.position.y, zbound);
    }
    private void FixedUpdate()
    {
        rb.AddForce(paddle * speed);

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
            speed += 10;
        }
        else if (collision.gameObject.tag == "stone3")
        {
            Debug.Log("Collision detected with " + collision.gameObject.name);
            Destroy(collision.gameObject);
            //particle3.Explode();
            score += 2;
            speed -= 10;
        }
    }
    public void GemPickup()
    {
        scoreText.SetText("Score: " + score);
        //scoreText.SetText("Score: " + score);
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highText.SetText("HighScore: " + score.ToString());
        }
    }

}
