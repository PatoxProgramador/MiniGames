using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadsOrTails : MonoBehaviour
{

    public static bool fate;
    [SerializeField] Text fateText;
    AudioSource sound;
    [SerializeField]AudioClip[] skillIssue = new AudioClip[2];

    void Start()
    {

        sound = GetComponent<AudioSource>();

        if (fate)
        {

            fateText.text = "You Win";
            sound.PlayOneShot(skillIssue[0]);

        }
        else
        {

            fateText.text = "You Lose";
            sound.PlayOneShot(skillIssue[1]);

        }
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
