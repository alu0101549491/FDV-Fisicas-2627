using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ejercicio2 : MonoBehaviour
{
    [SerializeField] private float movementForce = 10f;

    private Rigidbody rb;
    private Vector3 movementDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        movementDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.LeftArrow))  movementDirection += Vector3.left;
        if (Input.GetKey(KeyCode.RightArrow)) movementDirection += Vector3.right;
        if (Input.GetKey(KeyCode.UpArrow))    movementDirection += Vector3.forward;
        if (Input.GetKey(KeyCode.DownArrow))  movementDirection += Vector3.back;

        movementDirection = movementDirection.normalized;
    }

    private void FixedUpdate()
    {
        rb.AddForce(movementDirection * movementForce, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collided with: {collision.gameObject.name}");
    }
}
