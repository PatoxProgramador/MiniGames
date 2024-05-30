using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cube;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Vector3 randomSpawnPosition = new Vector3(Random.Range(-25,26),5,Random.Range(-25,26));

            Instantiate(cube,randomSpawnPosition,Quaternion.identity);

        }
        
    }
}
