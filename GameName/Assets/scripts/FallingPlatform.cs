using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private float fallDelay = 0.25f;
    private float destroyDelay = 3f;

    [SerializeField] private Rigidbody2D rb;
    private Vector2 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
    }

    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        yield return new WaitForSeconds(destroyDelay);
            
        rb.bodyType = RigidbodyType2D.Static;
        rb.velocity = Vector2.zero;
        transform.position = initialPosition;
    }
}
