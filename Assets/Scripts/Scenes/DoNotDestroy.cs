using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{

    public static string evaluator;

    private void Awake()
    {

        GameObject[] musicObject = GameObject.FindGameObjectsWithTag("GameMusic");

        if (musicObject.Length > 1)
        {

            Destroy(this.gameObject);

        }
        DontDestroyOnLoad(this.gameObject);


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (evaluator.Equals("EndScene") && this.gameObject != null)
        {

            Destroy(this.gameObject);

        }

    }
}
