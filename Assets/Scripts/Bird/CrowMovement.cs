using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CrowMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;
    [SerializeField] public BirdRotation BirdRot;


    [SerializeField] public float JumpForce = 4f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
            anim.SetInteger("Swing", 1);
            BirdRot.StartRotation();
        }
        else
        {
            anim.SetInteger("Swing", 0);
        }
        BirdRot.ApplyRotation(rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rock"))
        {
            GameManeger.Instance.Lose();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Fish"))
        {
            Destroy(other.gameObject);
            ScoreManeger.Instance.SetScore(1);
        }
    }
}