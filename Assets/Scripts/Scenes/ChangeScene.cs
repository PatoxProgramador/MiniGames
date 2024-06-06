using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
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

    public void Scene(string scene)
    {
        //change of determined scene when button clicked
        click.Play();
        SceneManager.LoadScene(scene);

    }

}
