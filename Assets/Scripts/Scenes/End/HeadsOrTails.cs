using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadsOrTails : MonoBehaviour
{

    public static bool fate;
    [SerializeField] Text fateText;
    AudioSource sound;
    [SerializeField] AudioClip[] skillIssue = new AudioClip[2];

    [SerializeField] Image[] screen = new Image[2];
    [SerializeField] Sprite []background = new Sprite[2];

    Color changer = Color.white;
    float a = 1f;

    void Start()
    {

        sound = GetComponent<AudioSource>();

        a = 0f;
        changer.a = a;
        screen[1].color = changer;

        if (fate)
        {
            a = 0f;
            changer.a = a;
            screen[0].color = changer;

            fateText.text = "You Win";
            sound.PlayOneShot(skillIssue[0]);
            screen[0].sprite = background[0];

            StartCoroutine(FadeIn(0, 0.1f));

        }
        else
        {

            fateText.text = "You Lose \n That Was In-Tents";
            sound.PlayOneShot(skillIssue[1]);
            screen[0].sprite = background[1];

            StartCoroutine(FadeIn(1, 0.5f));

        }

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FadeIn(int screener, float speed)
    {

        a += 0.2f;
        changer.a = a;
        screen[screener].color = changer;

        yield return new WaitForSeconds(speed);

        if (changer.a < 1)
        {

            StartCoroutine(FadeIn(screener, speed));

        }

    }

}
