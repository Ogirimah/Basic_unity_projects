// This moves components left to create an illusion that the player is moving right.
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
