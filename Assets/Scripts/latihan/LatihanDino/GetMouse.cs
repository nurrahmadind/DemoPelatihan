using UnityEngine;

public class GetMouse : MonoBehaviour
{
    public Transform CubeTransform;

    public Vector2 PosisiKlik;

    public  GameObject Segitiga;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        //geser objek ke mouse
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        CubeTransform.position = worldMousePosition;
        // CubeTransform.position = Vector2.MoveTowards (CubeTransform.position, worldMousePosition,0.05f);
        //geser object ke klik

        // if (Input.GetKeyDown(KeyCode.Mouse0))
        // {
        //     PosisiKlik = Camera.main.ScreenToWorldPoint (Input.mousePosition); 
        //     //fungsi ini berguna untuk mengambil posisi mouse dan mengubahnya menjadi posisi world
        // }
        // CubeTransform.position = Vector2.MoveTowards (CubeTransform.position, PosisiKlik,0.1f);
        //fungsi ini berguna untuk menggeser objek ke posisi yang telah ditentukan
        //0.1f adalah kecepatan gerak
        //cubetransform.position adalah posisi objek yang akan digeser
        //posisiklik adalah posisi yang dituju
          if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SpawnSegitiga();
        }
        Destroy (Segitiga, 3f);
    }
    public void SpawnSegitiga()
    {
        Instantiate(Segitiga, CubeTransform.position, Quaternion.identity);
    }

}
