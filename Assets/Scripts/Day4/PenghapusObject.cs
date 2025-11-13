using System.Collections;
using UnityEngine;

public class PenghapusObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
    //     StartCoroutine (HapusObject());
    //     //supaya bisa menjalankan yang HapusObject di bawah
    // }

    // IEnumerator HapusObject ()
    // {
    //     yield return new WaitForSeconds (5);
    //     Destroy (gameObject);
    // }
    void Start()
    {
        Destroy (gameObject, 5);
    }
}
