using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Anvil : MonoBehaviour
{
    // Start is called before the first frame update
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

            Destroy(gameObject);
            //print(RandomSpawner.item);

            int a = Random.Range(0,101);
            RandomSpawner.number = a;

            if (RandomSpawner.item == false && a == 50)
            {

                RandomSpawner.item = true;

                pos = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);

                Instantiate(cube, pos, Quaternion.identity);
                cube = GameObject.FindWithTag("Coin");
                cube.transform.eulerAngles = new Vector3(90,0,0);

            }

        }

    }

}
