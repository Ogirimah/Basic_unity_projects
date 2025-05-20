using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 obstacleSpawnPos = new Vector3(25, 0, 0);
    private float waitTime = 2f;
    private float repeatDelay = 2f;
    private PlayerController playerControllerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("spawnObstacle", waitTime, repeatDelay);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void spawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, obstacleSpawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
