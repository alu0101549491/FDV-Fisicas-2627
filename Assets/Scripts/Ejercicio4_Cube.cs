using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ejercicio4_Cube : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;
    private Rigidbody rb;
    private bool isMoving;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (!isMoving) return;

        rb.MovePosition(rb.position + transform.forward * movementSpeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere"))
        {
            Debug.Log("Collided with the Sphere!");
            isMoving = true;
        }
    }
}
