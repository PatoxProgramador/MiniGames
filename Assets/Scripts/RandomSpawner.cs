using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cube;

    [SerializeField] private float spawnRate = 1f;

    [SerializeField] private bool spawning = true;

    public static int number;
    public static bool item = false;

    void Start()
    {

        number = 0;

        StartCoroutine(Spawner());

    }

    // Update is called once per frame
    void Update()
    {

        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Vector3 randomSpawnPosition = new Vector3(Random.Range(-25,26),5,Random.Range(-25,26));

            Instantiate(cube,randomSpawnPosition,Quaternion.identity);

        }
        */

        if (number == 50)
        {

            item = true;

        }
        
    }

    private IEnumerator Spawner()
    {

        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (spawning)
        {

            yield return wait;

            Vector3 randomSpawnPosition = new Vector3(Random.Range(-25, 26), 5, Random.Range(-25, 26));

            Instantiate(cube, randomSpawnPosition, Quaternion.identity);

        }

    }
}
