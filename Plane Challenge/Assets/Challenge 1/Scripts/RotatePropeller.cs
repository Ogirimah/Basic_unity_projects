using UnityEngine;

public class RotatePropeller : MonoBehaviour
{
    public float propellerSpeed = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 1 * propellerSpeed);
    }
}
