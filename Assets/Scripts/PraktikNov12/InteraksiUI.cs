using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteraksiUI : MonoBehaviour
{
    public GameObject SquareUbahWarna;
    public TMP_Text KataBerubah;

    public TMP_Text NamaBerubah;

    public List<string> daftarNama;

    public int idNama;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UbahKataKiri()
    {
        string kata = "kiri";
        KataBerubah.text = kata;
    }

    public void UbahKataKanan()
    {
        string kata = "kanan";
        KataBerubah.text = kata;
    }

    public void LanjutNama()
    {
        if (idNama < daftarNama.Count-1)
        {
            idNama++;
        }
        else
        {
            idNama = 0;
        }
        NamaBerubah.text = daftarNama[idNama];
    }
    
    public void KembaliNama()
    {
        if (idNama <= 0)
        {
            idNama = daftarNama.Count - 1;
        }
        else
        {
            idNama--;
        }
        NamaBerubah.text = daftarNama[idNama];
    }

    public void UbahWarna(Color warna)
    {
        SpriteRenderer sr = SquareUbahWarna.GetComponent<SpriteRenderer>();
        sr.color = warna;
    }

    public void UbahWarnaMerah()
    {
        UbahWarna(Color.red);
    }
    public void UbahWarnaBiru()
    {
        UbahWarna(Color.blue);
    }
    public void UbahWarnaHijau()
    {
        UbahWarna(Color.green);
    }
    public void UbahWarnaAcak()
    {
        Color col = new Color (Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f));
        UbahWarna(col);
    }
}
