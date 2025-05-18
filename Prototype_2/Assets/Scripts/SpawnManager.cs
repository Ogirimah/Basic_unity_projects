using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    private float spawnLimitX = 10;
    private float spawnPosZ = 25;
    private float spurnStartTime = 2f;
    private float spurnRepeatrate = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("randomlySpurnAnimal", spurnStartTime, spurnRepeatrate);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // intermittently spurn a random animal at a random x-position
    void randomlySpurnAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnLimitX, spawnLimitX), 0, spawnPosZ);
        Quaternion spawnDirection = animalPrefab[animalIndex].transform.rotation;
        Instantiate(animalPrefab[animalIndex], spawnPosition, spawnDirection);

    }
}
