using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LittleCircleMovement : MonoBehaviour
{
    [SerializeField] private float littleCircleSpeed = 5f;
    [SerializeField] private AudioSource shootAudioSource;

    private Rigidbody2D rb2d;
    private bool canMove = true;
    
    
    private void Start() 
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update() 
    {
        if(canMove)
        {
            MoveUp();
        }
        
    }

    private void MoveUp()
    {
        rb2d.MovePosition(rb2d.position + Vector2.up * littleCircleSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        //hit a point
        if(other.gameObject.tag == "BigCircle")
        {
            FindObjectOfType<GameManager>().UpdateScore();
            other.GetComponent<BigCircleMovement>().rotationSpeed *= -1f;
            transform.SetParent(other.transform);
            shootAudioSource.Play();
            canMove = false;
        }

        //die
        if(other.gameObject.tag == "LittleCircle")
        {
            SceneManager.LoadScene("EndScene");
        }
    }

    
}
