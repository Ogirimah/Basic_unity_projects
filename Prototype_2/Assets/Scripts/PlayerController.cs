using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 200f;
    private float xMargin = 10f;
    public GameObject pizzaPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Keep the player within the bounds of the track
        if (transform.position.x < -xMargin)
        {
            transform.position = new Vector3(-xMargin, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xMargin)
        {
            transform.position = new Vector3(xMargin, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(pizzaPrefab, transform.position, pizzaPrefab.transform.rotation);
        }
    }
}
