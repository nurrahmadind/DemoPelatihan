using UnityEngine;

public class SquareMove : MonoBehaviour
{

    public ArahGerak arahGerak = ArahGerak.kanan;

    public Interaksi12 interaksi12;// Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public float kecepatan = 5.0f;
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
            case ArahGerak.bawah:
                gameObject.transform.Translate(0, -kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerak.kanan:
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
                break;
            case ArahGerak.kiri:
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
                break;

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dinding"))
        {
            Debug.Log("Kotak menabrak dinding");
            if (arahGerak == ArahGerak.atas)
            {
                arahGerak = ArahGerak.bawah;
            }
            else if (arahGerak == ArahGerak.bawah)
            {
                arahGerak = ArahGerak.atas;
            }
            else if (arahGerak == ArahGerak.kanan)
            {
                arahGerak = ArahGerak.kiri;
            }
            else
            {
                arahGerak = ArahGerak.kanan;
            }
            interaksi12.skor++;
            TambahSkor();
        }
    }
    public void TambahSkor()
    {
        interaksi12.teksSkor.text = "Skor:" + interaksi12.skor.ToString();
    }
}

public enum ArahGerak
{
    atas,
    bawah,
    kiri,
    kanan,
}
