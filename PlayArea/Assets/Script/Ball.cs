using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private MousePaddle myPaddle;

    private Rigidbody2D rb2d;

    private Vector3 paddleToBallVector;

    private bool hasStarted = false;

    float randomX, randomY;

    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(20, -15));
        }
        else
        {
            rb2d.AddForce(new Vector2(-20, -15));
        }
    }

    // Use this for initialization
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);

        /*randomX = Random.Range(0f, 0.2f);
        randomY = Random.Range(0f, 0.2f);

        myPaddle = GameObject.FindObjectOfType<Paddle>();

        //saves the distance between ball and paddle
        paddleToBallVector = this.transform.position - myPaddle.transform.position;*/
    }

    void ResetBall()
    {
        paddleToBallVector = Vector2.zero;
        rb2d.velocity = paddleToBallVector;
        transform.position = Vector2.zero;
    }

    void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            paddleToBallVector.x = rb2d.velocity.x;
            paddleToBallVector.y = (rb2d.velocity.y / 2.0f) + (collision.collider.attachedRigidbody.velocity.y / 3.0f);
            rb2d.velocity = paddleToBallVector;
        }

        /*if (hasStarted == true)
        {
            this.GetComponent<AudioSource>().Play();
        }

        if (collision.gameObject.name == "TopCollider")
        {
            randomY = Random.Range(-0.2f, 0f);
            Vector2 tweak = new Vector2(randomX, randomY);
            this.GetComponent<Rigidbody2D>().velocity += tweak;

        }
        else
        {
            Vector2 tweak = new Vector2(randomX, randomY);

            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }*/
    }


    
	

	// Update is called once per frame
	void Update () {

        /*if (!hasStarted)
        {
            this.transform.position = myPaddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0))//Left Click
            {
                hasStarted = true;
                this.GetComponent <Rigidbody2D>().velocity = new Vector2(2f, 10f);
            }

        }*/

	}
}
