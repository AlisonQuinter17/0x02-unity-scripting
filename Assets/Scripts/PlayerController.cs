using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1000f;
    private int score = 0;

    // Fixed Update is called once per frame
    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score++;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
        }
    }
}
