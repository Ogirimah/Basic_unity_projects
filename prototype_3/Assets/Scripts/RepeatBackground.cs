using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 backgroundStartPos;
    private float repeatWidth = 58;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        backgroundStartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < backgroundStartPos.x - repeatWidth)
        {
            transform.position = backgroundStartPos;
        }
    }
}
