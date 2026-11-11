using System.Numerics;
using UnityEditor.Experimental.GraphView;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.EventSystems;
using static System.Runtime.CompilerServices.RuntimeHelpers;


public class RabbitController : MonoBehaviour
{
    public float movespeed = 5.0f;
    public float jumpforce = 10.0f;
    public Transform groundcheck;
    public float groundcheckradius = 0.2f;
    public LayerMask groundlayer;

    float time;
    float interval = 3f;

    float movdirection;

    private Rigidbody2D rb;
    private bool isgrounded;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        while (time >= interval)
        {
            movdirection = randommove();
            time -= interval;
        }

        float moveinput = movdirection;
        if (isgrounded);
        {
            rb.linearVelocity = new UnityEngine.Vector2(moveinput * movespeed, 5.0f);
        }
    }

    private void FixedUpdate()
    {
        isgrounded = Physics2D.OverlapCircle(groundcheck.position, groundcheckradius, groundlayer);
    }
    public float randommove()
    {
        return Random.Range(-1.0f, 1.0f);
    }

}

