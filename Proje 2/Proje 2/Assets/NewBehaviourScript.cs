using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 2f;
    public float jumpForce = 2f;

    private bool isGrounded; //Yer ile temas durumunu kontrol etmek için deðiþken

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
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);//Objeye, yukarý doðru bir kuvvet uygulanarak zýplama iþlemi gerçekleþir. jumpForce deðiþkeniyle belirtilen güçte olacak ve ForceMode.Impulse ile anlýk bir ivme olarak uyglanacak.
            isGrounded = false; // zýplandýðýnda zemin ile temasý kaldýrýyoruz.
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("zemin")) //temas edilen nesnenin tag'ý zemin ise
        {
            isGrounded = true;
        }
        if (collision.gameObject.CompareTag("kup"))
        {
          collision.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        
    }


}
