using TMPro;
using UnityEngine;

public class ManagerNov13 : MonoBehaviour
{
    public int skor;
    
    public TMP_Text teksSkor;

    public SquareMoveNov13 squareMoveNov13;

    public GameObject bolaJatuh;

    public PemainLompat pemainLompat;
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
            // ToggleKiriKanan(); 
            squareMoveNov13.isMoveRight = false;
            MunculDariAtas ();
            pemainLompat.Lompat();
        }
        if (Input.GetMouseButtonDown (1))
        {
            Debug.Log ("Klik kanan");
            KurangSKor();
            UpdateTeksSkor();
            squareMoveNov13.isMoveRight = true;
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
        Debug.Log ("Skor terupdate");
    }

    void ToggleKiriKanan()
    {
        if (squareMoveNov13.isMoveRight)
        {
            squareMoveNov13.isMoveRight = false;
        }
        else
        {
            squareMoveNov13.isMoveRight = true;
        }
    }
    void MunculDariAtas()
    {

        //ambil posisi dimana kursor mouse berada
        Vector3 posisiKlik = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        //ambil posisi titik paling atas layar
        Vector3 titikAtas = Camera.main.ScreenToWorldPoint (new Vector3(0, Screen.height,0));
        //gunakan posisi kursor pada sumbu x dan posisi titik paling atas layar untun vektor3
        Vector3 tempatJatuh = new Vector3 (posisiKlik.x, titikAtas.y, 0);
        //memunjulkan object dengan nama bola jatuh di posisi tempat jatuh dengan rotasi quaternion 
        Instantiate (bolaJatuh, tempatJatuh, Quaternion.identity);    
    }

}
