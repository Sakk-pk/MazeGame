using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveForce = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveZ);
        rb.AddForce(move * moveForce);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Hit a wall!");
        }
        else if (collision.gameObject.CompareTag("Goal"))
        {
            Debug.Log("You reached the goal!");
        }
    }
}
