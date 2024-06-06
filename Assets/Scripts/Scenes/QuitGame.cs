using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource click;

    void Start()
    {

        click = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scadoosh()
    {
        //quit game
        click.Play();
        Application.Quit();

    }

}
