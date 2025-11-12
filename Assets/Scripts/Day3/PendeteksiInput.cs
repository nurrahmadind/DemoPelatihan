using System;
using UnityEngine; //menggunakan library unity
using UnityEngine.Events;

public class PendeteksiInput : MonoBehaviour
{
    //     public Score objectScore; //menunjuk ke script Score dan object score di unity
    //     // Start is called once before the first execution of Update after the MonoBehaviour is created
    //    private void Update()
    //     {
    //         if (Input.GetKeyDown(KeyCode.Space))
    //         {
    //             objectScore.AddScore();
    //         }
    //     }

    public UnityEvent inputEvent; //Action utuk C#
    public UnityEvent jumpEvent; //Action untuk jump

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            inputEvent?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            jumpEvent?.Invoke();
        }
    }
}
