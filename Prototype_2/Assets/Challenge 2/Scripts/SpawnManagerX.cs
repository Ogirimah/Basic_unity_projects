using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        // Spawn first random ball using the start delay
        Invoke("SpawnRandomBall", startDelay);
    }

    void Update()
    {

    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        spawnInterval = Random.Range(3f, 5f);
        // Generate random ball index and random spawn position
        int randomBallIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBallIndex], spawnPos, ballPrefabs[randomBallIndex].transform.rotation);

        // Recursively trigger the spawning of the next random ball using the interval
        Invoke(nameof(SpawnRandomBall), spawnInterval);
    }

}
