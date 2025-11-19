using System.Collections;
using UnityEngine;

public class ContohCourotine : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine (CobaCourotine());
    }
    //Coroutine adalah function yang bisa dijalankan secara berurutan
    //Coroutine menggunakan IEnumerator
    //COroutine digunakan untuk membuat delay
    // Update is called once per frame
    void Update()
    {
        
    }

    //buat function IEnumerator untuk menggunakan coroutine
    IEnumerator CobaCourotine()
    {
        Debug.Log("Perintah 1");
        yield return new WaitForSeconds (5); //tunda selama 5 detik
        Debug.Log ("Perintah 2");
    }
}
