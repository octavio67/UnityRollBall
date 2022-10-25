using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public GameObject winTextObject;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    private bool isJumping;

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb  = GetComponent<Rigidbody>();
        count = 30;
        SetCountText();
        winTextObject.SetActive(false);
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    void SetCountText()
    {
        countText.text = "Remaining Cubes: " + count.ToString();
        if(count <= 0)
        {
            winTextObject.SetActive(true);
            
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
         
            isJumping = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && count <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    private void FixedUpdate() 
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count - 1;

            SetCountText();
        }
        if(other.gameObject.CompareTag("Door") && count <=0)
        {
            
            SceneManager.LoadScene("MiniGame2");
        }
    }



}
       
    
