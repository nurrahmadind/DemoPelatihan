using TMPro;
using UnityEngine;

public class DeteksiObjek : MonoBehaviour
{
    public TMP_Text skorText;
    
    public int score;

    public void tambahSkor()
    {
        score += 1;
        skorText.text = "Skor: " + score.ToString();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Klik");
            
            Vector2 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D lingkarandiklik = Physics2D.OverlapPoint(posisiKlik);
            if(lingkarandiklik != null)
            {
                if(lingkarandiklik.CompareTag("Bola"))
                {Destroy(lingkarandiklik.gameObject);
                Debug.Log("Objek dihapus");
                tambahSkor();
                }
                
            }
            else
            {
                Debug.Log("Tidak ada objek yang dihapus");
            }

        }
    }
}
