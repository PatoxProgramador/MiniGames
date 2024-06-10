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

    AudioSource death;
    public AudioClip []sounds = new AudioClip[2];

    int score;
    public int winScore;

    public Transform respawn;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        death = GetComponent<AudioSource>();

        score = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -5f)
        {

            //SceneManager.LoadScene("SampleScene");
            //spawn point
            RespawnPosition();

        }

    }

    private void FixedUpdate()
    {
        //movement
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        rb.AddForce(xInput * speed, 0 , yInput * speed);

    }

    void RespawnPosition()
    {

        death.PlayOneShot(sounds[0]);
        gameObject.transform.position = respawn.position;

    }
    //collect coin
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Coin")
        {

            other.gameObject.SetActive(false);
            death.PlayOneShot(sounds[1]);

            score++;
            //win scenario
            if (score >= winScore)
            {

                SceneManager.LoadScene("EndScene");

            }

        }

    }
    //death when touching anvil
    private void OnCollisionEnter(Collision collision)
    {
       
        if(collision.gameObject.tag == "Anvil")
        {

            RespawnPosition();

        }

    }

}
