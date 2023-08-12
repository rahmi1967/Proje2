using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 2f;
    public float jumpForce = 2f;

    private bool isGrounded; //Yer ile temas durumunu kontrol etmek i�in de�i�ken

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hzInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(hzInput, 0f, vInput);
        rb.AddForce(move * speed);
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)//yer ile temas durumunu kontrol ederiz
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);//Objeye, yukar� do�ru bir kuvvet uygulanarak z�plama i�lemi ger�ekle�ir. jumpForce de�i�keniyle belirtilen g��te olacak ve ForceMode.Impulse ile anl�k bir ivme olarak uyglanacak.
            isGrounded = false; // z�pland���nda zemin ile temas� kald�r�yoruz.
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("zemin")) //temas edilen nesnenin tag'� zemin ise
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("kup"))
        {
          collision.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        
    }


}
