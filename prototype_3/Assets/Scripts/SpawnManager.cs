using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 obstacleSpawnPos = new Vector3(25, 0, 0);
    private float waitTime = 2f;
    private float repeatDelay = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("spawnObstacle", waitTime, repeatDelay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void spawnObstacle()
    {
        Instantiate(obstaclePrefab, obstacleSpawnPos, obstaclePrefab.transform.rotation);
    }
}
