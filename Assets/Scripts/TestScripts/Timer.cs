using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [SerializeField] Text timerText;
    [SerializeField]float elapsedTime;
    
    void Start()
    {
        
    }

    void Update()
    {

        if (elapsedTime > 0)
        {

            elapsedTime -= Time.deltaTime;

        }
        else
        {

            elapsedTime = 0;

        }
        

        int min = Mathf.FloorToInt(elapsedTime / 60);
        int sec = Mathf.FloorToInt(elapsedTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}",min,sec);
        
    }

}
