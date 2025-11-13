using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)) //deteksi dulu input kliknya
        {
            Vector2 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D objectTerdeteksi = Physics2D.OverlapPoint(posisiKlik);
            //untuk mendeteksi di suatu titik apakah ada object atau tdk
            if (objectTerdeteksi != null)
            {
                Destroy(objectTerdeteksi.gameObject);
            }
            //untuk mendeteksi di suatu titik apakah ada object atau tdk
        }
    }
}
