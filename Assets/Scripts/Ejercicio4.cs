using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    [SerializeField] private GameObject Cylinder;
    [SerializeField] private float movementForce = 10f;
    private Rigidbody rb;
    private Renderer renderer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        renderer = GetComponent<Renderer>();
    }

    private void FixedUpdate()
    {
        if (Cylinder == null || rb == null)
        {
            return;
        }

        Vector3 direction = Cylinder.transform.position - transform.position;
        rb.AddForce(direction.normalized * movementForce, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Collided with an obstacle!");
            renderer.material.color = Random.ColorHSV();
        }
    }
}
