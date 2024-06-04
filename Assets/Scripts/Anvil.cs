using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Anvil : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;

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

                Instantiate(cube, transform.position, Quaternion.identity);

            }

        }

    }

}
