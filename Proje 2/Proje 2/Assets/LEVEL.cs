using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LEVEL : MonoBehaviour
{
   
    void Start()
    {
        //Level 1 = k�p�n rengi de�i�sin --> silindirin boyutu k���ls�n veya �ls�n --> Level 2 ye ge�i� yap�ls�n.
          
        //Level 2 = Raycast kullanarak zeminin rengi de�i�sin veya ate� ederek bir objeyi �ld�r�n.
    } 

    
    void Update()
    {
       //E�er top bilmemne objesi ile temas ederse veya silindir �l�rse veya boyutu k���l�rse index numaras� 1 olan sahneye ge�i� yap�ls�n
        SceneManager.LoadScene(1);//index numaras� 1 olan sahneye gider.
    }
}
