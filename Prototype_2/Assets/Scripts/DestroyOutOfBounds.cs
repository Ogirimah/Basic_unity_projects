using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperBound = 30f;
    private float lowerBound = -15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Destroy pizza once it is past gaming area
        if (transform.position.z > upperBound)
        {
            Destroy(gameObject);
        }
        // Destroy animal once they are past gaming area
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!!!");
            Destroy(gameObject);
        }
    }
}
