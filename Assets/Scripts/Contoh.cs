using System.Globalization;
using Mono.Cecil.Cil;
using UnityEngine;
using UnityEngine.Rendering;

public class Contoh : MonoBehaviour
{
    int nyawa = 10;   // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log ("Perkalian (5,5,5) = " + Kali(5,5,5));
    }   
    public void MinumObat()
    {
        Debug.Log("Pemain meminum obat");
        Sembuhkan(30);

    }
    public void Sembuhkan(int tambahanNyawa)
    {
        nyawa = nyawa + tambahanNyawa;

    }
    public int Kali(int angka1, int angka2, int angka3)
    {
        int result= angka1* angka2* angka3;
        return result;
    }

}
