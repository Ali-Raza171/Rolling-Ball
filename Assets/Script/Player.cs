using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody ball;
    public float ballspeed;
    public Text score;
    public bl_Joystick _joystick;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score.text = ball.position.z.ToString("0");


        if (ball.position.y < -3)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);



    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            ball.AddForce(-ballspeed, 0f, 0f);

        if (Input.GetKey(KeyCode.RightArrow))
            ball.AddForce(ballspeed, 0f, 0f);

        ball.AddForce(0f, 0f, ballspeed);
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Respawn"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        if (collision.gameObject.CompareTag("Finish"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void left()
    {
        ball.AddForce(-ballspeed*10, 0f, 0f);
    }

    public void right()
    {
        ball.AddForce(ballspeed*10, 0f, 0f);
    }
}