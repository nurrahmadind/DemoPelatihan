using UnityEngine;
using TMPro;
public class Interaksi12 : MonoBehaviour
{
    public TMP_Text teksNyawa;
    public int nyawa;
    //deklarasi variable nyawa dengan tipe data int
    //untuk menyimpan nilai nyawa
    public BolaTabrak bolaTabrak;
    //deklarasi variable bolaTabrak dengan tipe data class BolaTabrak
    //ini digunakan untuk script ini bisa berkomunikasi dengan script BolaTabrak

    public SquareMove squareMove;
    //deklarasi variable squareMove dengan tipe data class SquareMove
    //ini digunakan untuk script ini bisa berkomunikasi dengan script SquareMove
    public int skor;
    //deklarasi variable skor dengan tipe data int
    //untuk menyimpan nilai skor
    public TMP_Text teksSkor;
    //deklarasi variable teksSkor dengan tipe data TMP_Text
    //untuk menampilkan teks skor di layar
    //tambahkan referensi using TMPro; di bagian atas script
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GerakAtas()
    {
        squareMove.arahGerak = ArahGerak.atas;
        //mengubah arahGerak di script SquareMove menjadi ArahGerak.atas
        //fungsi ini akan dipanggil saat tombol Atas ditekan
        //fungsi ini dihubungkan di Unity melalui OnClick() kemudian pilih Interaksi12 -> GerakAtas

    }

    public void GerakBawah()
    {
        squareMove.arahGerak = ArahGerak.bawah;
    }
    public void GerakKanan()
    {
        squareMove.arahGerak = ArahGerak.kanan;
    }
    public void GerakKiri()
    {
        squareMove.arahGerak = ArahGerak.kiri;
    }


}
    