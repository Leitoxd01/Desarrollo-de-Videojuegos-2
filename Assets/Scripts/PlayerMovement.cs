using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 50f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("START ejecutado");
    }

    void FixedUpdate()
    {
        Debug.Log("FIXEDUPDATE ejecutándose");

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x, 0, z).normalized;
        rb.AddForce(direction * speed);
    }
}
