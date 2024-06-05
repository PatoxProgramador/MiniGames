using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConto : MonoBehaviour
{

    public Transform target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //camera rotation towards player
        transform.LookAt(target);

    }

}
