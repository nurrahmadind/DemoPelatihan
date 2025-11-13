using UnityEngine;

public class SquareMove : MonoBehaviour
{

    public ArahGerak arahGerak = ArahGerak.kanan;
    //deklarasi variable arahGerak dengan tipe data ArahGerak
    //dan diinisialisasi dengan ArahGerak.kanan

    public Interaksi12 interaksi12;
    //deklarasi variable interaksi12 dengan tipe data class Interaksi12
    //ini digunakan untuk script ini bisa berkomunikasi dengan script Interaksi12

    public float kecepatan = 5.0f;
    //deklarasi variable kecepatan dengan tipe data float
    //dan diinisialisasi dengan 5.0f
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (arahGerak)
        {
            case ArahGerak.atas:
                gameObject.transform.Translate(0, kecepatan * Time.deltaTime, 0);
                break;
                //Time.deltaTime digunakan untuk mengatur kecepatan agar tetap konsisten
                //0, kecepatan * Time.deltaTime, 0 artinya bergerak di sumbu Y positif berarti gerak ke atas
            case ArahGerak.bawah:
                gameObject.transform.Translate(0, -kecepatan * Time.deltaTime, 0);
                break;
                //0, -kecepatan * Time.deltaTime, 0 artinya bergerak di sumbu Y negatif berarti gerak ke bawah
            case ArahGerak.kanan:
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
                break;
                //kecepatan * Time.deltaTime, 0, 0 artinya bergerak di sumbu X positif berarti gerak ke kanan
            case ArahGerak.kiri:
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
                break;
                //-kecepatan * Time.deltaTime, 0, 0 artinya bergerak di sumbu X negatif berarti gerak ke kiri
        }
    }

    void OnCollisionEnter2D(Collision2D collision) 
    //fungsi yang dijalankan saat terjadi tabrakan dengan collider lain atau object lain
    {
        if (collision.gameObject.CompareTag("Dinding"))
        {
            Debug.Log("Kotak menabrak dinding");
            if (arahGerak == ArahGerak.atas)
            {
                arahGerak = ArahGerak.bawah;
            }
            //cek arahGerak, jika arah ke atas dan nabrak maka arah diubah ke bawah
            else if (arahGerak == ArahGerak.bawah)
            {
                arahGerak = ArahGerak.atas;
            }
            //cek arahGerak, jika arah ke bawah dan nabrak maka arah diubah ke atas
            else if (arahGerak == ArahGerak.kanan)
            {
                arahGerak = ArahGerak.kiri;
            }
            //cek arahGerak, jika arah ke kanan dan nabrak maka arah diubah ke kiri
            else
            {
                arahGerak = ArahGerak.kanan;
            }
            //selainnya (kiri), jika arah ke kiri dan nabrak maka arah diubah ke kanan
            interaksi12.skor++; //menambah skor di script Interaksi12
            TambahSkor(); //memanggil fungsi TambahSkor di script Interaksi12
        }
    }
    public void TambahSkor()
    {
        interaksi12.teksSkor.text = "Skor:" + interaksi12.skor.ToString();
        //mengubah teksSkor di script Interaksi12 menjadi "Skor:" diikuti dengan nilai skor
        //fungsi ini dipanggil saat kotak menabrak dinding
        //fungsi ini dihubungkan di Unity melalui OnCollisionEnter2D
        //di unity, pastikan object yang memiliki script SquareMove memiliki Rigidbody2D dan Collider2D
        //di unity masukan scrip Interaksi12 ke variable interaksi12 di inspector
        //agar script ini bisa mengakses variable di script Interaksi12
        //di unity bagian kotak masukan script SquareMove ke object kotak yang ingin digerakkan
        //dan pastikan object dinding memiliki tag "Dinding" pada object dinding
    }
}

//deklarasi enum dengan nama ArahGerak  
//yang berisi atas, bawah, kiri, kanan
//
public enum ArahGerak
{
    atas,
    bawah,
    kiri,
    kanan,
}
