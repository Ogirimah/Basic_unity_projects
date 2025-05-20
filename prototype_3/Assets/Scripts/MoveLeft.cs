// This moves components left to create an illusion that the player is moving right.
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private float speed = 30;

    private float leftPlayMargin = -10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (transform.position.x < leftPlayMargin && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
