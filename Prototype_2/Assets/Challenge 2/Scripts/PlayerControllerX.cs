using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private bool spawned = false;
    private float spawnDelay;
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        ResetDelay();
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !spawned)
        {
            spawnDelay = 1f;
            spawned = true;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
    private void ResetDelay()
    {
        if (spawned && spawnDelay > 0)
        {
            spawnDelay -= Time.deltaTime;
        }
        else if (spawnDelay < 0)
        {
            spawnDelay = 0;
            spawned = false;
        }
    }
}
