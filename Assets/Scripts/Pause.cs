using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject pause;
    bool turn;

    void Start()
    {

        pause.SetActive(false);
        turn = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        // pausable logic
        if (Input.GetKeyDown(KeyCode.Escape) && turn == false) {

            pause.SetActive(true);
            turn = true;
            Time.timeScale = 0f;

        }
        else if (Input.GetKeyDown(KeyCode.Escape) && turn == true)
        {

            pause.SetActive(false);
            turn = false;
            Time.timeScale = 1f;

        }

    }

}
