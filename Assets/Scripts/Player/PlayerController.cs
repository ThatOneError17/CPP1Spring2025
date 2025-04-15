using UnityEditor.Tilemaps;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController : MonoBehaviour
{
    [Range(3, 10)]
    public float speed = 6.0f;

    [Range(400, 1000)]
    public float jumpforce = 400f;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(hInput * speed, rb.linearVelocity.y);
        spriteRenderer.flipX = rb.linearVelocity.x < 0f;

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, jumpforce));
        }

    }
} 
