using System.Numerics;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class Controller : MonoBehaviour
{
    public float movespeed = 5.0f;
    public float jumpforce = 10.0f;
    public Transform groundcheck;
    public float groundcheckradius = 0.2f;

    public Transform ledgecheck;
    public float ledgecheckradius = 0.2f;
    public LayerMask groundlayer;



    private Rigidbody2D rb;
    private bool isgrounded;
    private bool isledgegrabbed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveinput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new UnityEngine.Vector2(moveinput * movespeed, rb.linearVelocity.y);

        if (Input.GetKeyDown("space") && isgrounded)
        {
            rb.linearVelocity = new UnityEngine.Vector2(rb.linearVelocity.x, jumpforce);
        }
   
    }

    private void FixedUpdate()
    {
        isgrounded = Physics2D.OverlapCircle(groundcheck.position, groundcheckradius, groundlayer);
    }
}
