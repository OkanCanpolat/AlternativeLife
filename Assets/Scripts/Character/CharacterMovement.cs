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
    public GameObject image1, image2;
    public bool resimGecis;
    private GameObject obj;
    public AudioSourcee audioSource;
    public AudioClip audioClip;


    private void Awake()
    {
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

        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);

    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("kapı") == sayac._sayac.sayacArtir >=5)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine(imageGecis());
            }

        }

        if (col.gameObject.CompareTag("npc5"))
        {
            audioSource.sesiCal(audioClip);
        }
        
    }

    public IEnumerator imageGecis()
    {
        yield return new WaitForSeconds(3.0f);
        image1.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        image1.SetActive(false);
        image2.SetActive(true);
        yield return new WaitForSeconds(4.0f);
        image2.SetActive(false);
        resimGecis = true;
        transform.position = SpawnPoint.position;
        polygonCollider2D.enabled = false;
        polygonColliderr2D.enabled = true;
        Debug.Log("girdi");
        cinemachineConfiner.m_BoundingShape2D = polygonColliderr2D;
        obj = GameObject.FindWithTag("kapı");
        obj.tag = "kapi";
    }


}

