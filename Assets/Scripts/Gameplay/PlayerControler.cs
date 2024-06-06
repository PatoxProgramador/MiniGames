using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{

    public float speed;

    Rigidbody rb;

    float xInput;
    float yInput;

    int score;
    public int winScore;

    public GameObject winText;

    public Transform respawn;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();

        score = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -5f)
        {

            //SceneManager.LoadScene("SampleScene");
            //spawn point
            gameObject.transform.position = new Vector3(-0.1f, 3f, 0f);

        }

    }

    private void FixedUpdate()
    {
        //movement
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        rb.AddForce(xInput * speed, 0 , yInput * speed);

    }
    //collect coin
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Coin")
        {

            other.gameObject.SetActive(false);

            score++;
            //win scenario
            if (score >= winScore)
            {

                winText.SetActive(true);

            }

        }

    }
    //death when touching anvil
    private void OnCollisionEnter(Collision collision)
    {
       
        if(collision.gameObject.tag == "Anvil")
        {

            transform.position = respawn.position;

        }

    }

}
