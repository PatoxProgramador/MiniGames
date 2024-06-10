using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cube;
    public int height;

    [SerializeField] private float spawnRate = 1f;

    [SerializeField] private bool spawning = true;

    public static int number;
    public static bool item = false;

    AudioSource sound;

    void Start()
    {

        number = 0;
        sound = GetComponent<AudioSource>();
        sound.volume = 0.1f;

        StartCoroutine(Spawner());

        StartCoroutine(Hitting());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Spawner()
    {
        //anvil spawn rate
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (spawning)
        {

            yield return wait;
            //position where anvil spawn
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-25, 26), height, Random.Range(-25, 26));

            Instantiate(cube, randomSpawnPosition, Quaternion.identity);

        }

    }

    private IEnumerator Hitting()
    {

        yield return new WaitForSeconds(0.5f);
        //anvil hitting floor noise pattern
        sound.Play();

        StartCoroutine(Hitting());

    }
}
