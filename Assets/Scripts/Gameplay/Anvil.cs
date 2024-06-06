using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Anvil : MonoBehaviour
{
    
    public GameObject cube;

    Vector3 pos;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Floor")
        {

            //print(RandomSpawner.item);
            //random number being generated to pass to public variable between the chances of 0-100
            int a = Random.Range(0,101);
            RandomSpawner.number = a;
            //if item not spawned yet and number 50 do spawn item
            if (RandomSpawner.item == false && a == 50)
            {

                RandomSpawner.item = true;
                // determined position
                pos = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);
                //spawning coin
                Instantiate(cube, pos, Quaternion.identity);
                cube = GameObject.FindWithTag("Coin");
                cube.transform.eulerAngles = new Vector3(90,0,0);

            }

            Destroy(gameObject);

        }

    }

}
