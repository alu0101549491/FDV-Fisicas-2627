using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class Ejercicio3 : MonoBehaviour
{
    private Renderer renderer;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        renderer.material.color = Random.ColorHSV();
    }
}
