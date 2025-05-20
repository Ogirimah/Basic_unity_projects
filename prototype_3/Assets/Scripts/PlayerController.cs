using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 600;
    private bool isOnTheGround = true;
    public float gravityModifier;
    public bool gameOver = false;
    private Animator playerAnima;
    public ParticleSystem dustParticle;
    public ParticleSystem explosnParticle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        playerAnima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Player can only transition to jump state if it is on the ground and the game is not over
        if (Input.GetKeyDown(KeyCode.Space) && isOnTheGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnTheGround = false;
            playerAnima.SetTrigger("Jump_trig");
            dustParticle.Stop();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // The player should fall backward if it is on the ground and it collides with obstacle
        // And it should fall forward if it is has jumped already and it cllides with the obstacle.


        // if (collision.gameObject.CompareTag("Ground") && collision.gameObject.CompareTag("Obstacle"))
        // {
        //     gameOver = true;
        //     playerAnima.SetBool("Death_b", true);
        //     playerAnima.SetInteger("DeathType_int", 1);
        // }
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnTheGround = true;
            dustParticle.Play();
        }

        // Collision with obstacle = game over, transition to death state and falling backward death type.
        // Ideally, I think player should fall forward.
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over");
            playerAnima.SetBool("Death_b", true);
            // playerAnima.SetInteger("DeathType_int", 2);
            playerAnima.SetInteger("DeathType_int", 1);
            explosnParticle.Play();
            dustParticle.Stop();
        }
    }
}
