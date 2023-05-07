using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] public float movementSpeed;
    public Animator animator;
    public PolygonCollider2D polygonCollider2D;
    public PolygonCollider2D polygonColliderr2D;
    public CinemachineConfiner2D cinemachineConfiner;
    public Transform SpawnPoint;
    public SpriteRenderer rnd;
    
    private void Awake()
    {
        rnd = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        Time.timeScale = 1;
        if (PlayerPrefs.HasKey("x"))
        {
            Debug.Log("player prefs");
            Vector3 pos = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"), PlayerPrefs.GetFloat("z"));
            transform.position = pos;
        }
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(horizontal * movementSpeed, vertical * movementSpeed);
        
        animator.SetFloat("Horizontal",horizontal);
        animator.SetFloat("Vertical", vertical);

        if(horizontal > 0)
        {
            rnd.flipX = true;
        }

        else
        {
            rnd.flipX = false;
        }

    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("kapı"))
        {

            if (Input.GetKeyDown(KeyCode.Space) && sayac._sayac.sayacArtir>=4)
            {
                transform.position = SpawnPoint.position;
                polygonCollider2D.enabled = false;
                polygonColliderr2D.enabled = true;
                Debug.Log("girdi");
                cinemachineConfiner.m_BoundingShape2D = polygonColliderr2D;
                Debug.Log("aaaaaaaaaaa");
                

            }
            
        }
    }

}
