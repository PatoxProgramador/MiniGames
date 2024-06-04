using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnTimed : MonoBehaviour
{

    [SerializeField] private float spawnRate = 1f;

    [SerializeField] private bool spawning = true;

    void Start()
    {

        StartCoroutine(Spawner());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Spawner()
    {

        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (spawning)
        {

            yield return wait;

            //Instatiate

        }

    }

}
