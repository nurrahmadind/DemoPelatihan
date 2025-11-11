using UnityEngine;
using UnityEngine.UIElements;

public class ContohArray : MonoBehaviour
{
    //membuat array yang menyimpan 3 data nama Aku, Kamu dan Dia
    public string[] ArrayNama = { "Aku", "Kamu", "Dia" };

    private void Start()
    {
        //mengakses data array pada index ke 0
        Debug.Log(ArrayNama[0]); //Output: Aku

        //mengubah data array pada index ke 1
        ArrayNama[1] = "Siapa kamu";
        Debug.Log(ArrayNama[1]); //Output: Siapa Kamu

        //menampilkan panjang array
        Debug.Log(ArrayNama.Length); 
    }
}