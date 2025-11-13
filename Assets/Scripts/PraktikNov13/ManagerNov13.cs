using TMPro;
using UnityEngine;

public class ManagerNov13 : MonoBehaviour
{
    public int skor;
    
    public TMP_Text teksSkor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateTeksSkor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            Debug.Log ("Klik kiri");
            // Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log("Posisi mouse ada di " + vector.ToString());
            TambahSkor();
            UpdateTeksSkor();
        }
        if (Input.GetMouseButtonDown (1))
        {
            Debug.Log ("Klik kanan");
            KurangSKor();
            UpdateTeksSkor();
        }
    }
    void TambahSkor()
    {
        skor++;
        Debug.Log ("Skor bertambah");
    }
    void KurangSKor()
    {
        skor --;
        Debug.Log ("Skor berkurang");
    }
    void UpdateTeksSkor()
    {
        teksSkor.text = skor.ToString ();
        Debug.Log ("");
    }
}
