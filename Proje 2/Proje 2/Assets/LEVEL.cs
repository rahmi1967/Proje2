using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LEVEL : MonoBehaviour
{
   
    void Start()
    {
        //Level 1 = küpün rengi deðiþsin --> silindirin boyutu küçülsün veya ölsün --> Level 2 ye geçiþ yapýlsýn.
          
        //Level 2 = Raycast kullanarak zeminin rengi deðiþsin veya ateþ ederek bir objeyi öldürün.
    } 

    
    void Update()
    {
       //Eðer top bilmemne objesi ile temas ederse veya silindir ölürse veya boyutu küçülürse index numarasý 1 olan sahneye geçiþ yapýlsýn
        SceneManager.LoadScene(1);//index numarasý 1 olan sahneye gider.
    }
}
