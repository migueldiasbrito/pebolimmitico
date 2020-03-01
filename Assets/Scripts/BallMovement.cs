using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    GameObject ball;

    bool clickable;
    bool physics;
    Vector3 spawnPoint;

    public AtributePlayer atributePlayer;

    public Text goal1;
    public Text goal2;
    void Start()
    {
        clickable = true;
        ball = this.gameObject;
        ball.GetComponent<Rigidbody>().useGravity = false;
        physics = false;
        spawnPoint = this.transform.position;
    }

    void Update()
    {
        //if (physics == true)
        //{
            if (Input.GetKey("w"))
            {
                ball.GetComponent<Rigidbody>().AddForce(new Vector3(3f, 0f, 0f));
            }

            if (Input.GetKey("s"))
            {
                ball.GetComponent<Rigidbody>().AddForce(new Vector3(-3f, 0f, 0f));
            }

            if (Input.GetKey("a"))
            {
                ball.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, 3f));
            }

            if (Input.GetKey("d"))
            {
                ball.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, -3f));
            }

            if (Input.GetKeyDown("space"))
            {
                //ball.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, -500f));
                ball.GetComponent<Rigidbody>().AddForce(new Vector3(4f, -2f, 5f));
                ball.GetComponent<Rigidbody>().useGravity = true;
                physics = true;
            }
        //}
    }

    private void OnMouseDown()
    {
        if (clickable == true)
        {
            // Destroy(gameObject);
            ball.GetComponent<Rigidbody>().AddForce(new Vector3(450f, -200f, 50f));
            ball.GetComponent<Rigidbody>().useGravity = true;
            physics = true;
            clickable = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "OoB")
        {
            ResetBall();
        }

        if(other.gameObject.tag == "BalizaP1")
        {
            Debug.Log("GOLO! P2");
            atributePlayer.ads.PlayOneShot(atributePlayer.p1.bolaGolo);
            goal1.text = (int.Parse(goal1.text) + 1).ToString();

            if (goal1.text.Equals("3")) SceneManager.LoadScene(1);
            
            ResetBall();
        }
        if (other.gameObject.tag == "BalizaP2")
        {
            Debug.Log("GOLO! P1");
            atributePlayer.ads.PlayOneShot(atributePlayer.p2.bolaGolo);
            goal2.text = (int.Parse(goal2.text) + 1).ToString();

            if (goal2.text.Equals("3")) SceneManager.LoadScene(1);
            ResetBall();
        }
        if (other.gameObject.tag == "Goal")
        {
            ResetBall();
            //insert point distribution 
        }

    }

    void ResetBall()
    {


        ball.transform.position = spawnPoint;
        /* ball.GetComponent<Rigidbody>().useGravity = false;
         ball.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
         physics = false;*/

        int r = Random.Range(1, 3);


        if (r%2 == 0)
        {
            ball.GetComponent<Rigidbody>().AddForce(new Vector3(4f, -2f, 5f));
            ball.GetComponent<Rigidbody>().useGravity = true;
            physics = true;
        }
        else
        {
            ball.GetComponent<Rigidbody>().AddForce(new Vector3(4f, -2f, -5f));
            ball.GetComponent<Rigidbody>().useGravity = true;
            physics = true;
        }

        clickable = true;
    }

}
