using UnityEngine;

public class KotakDrag : MonoBehaviour
{
    void OnMouseDrag()
    {
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);// mengambil posisi mouse di world
        transform.position = worldMousePosition; // mengubah posisi object menjadi posisi mouse
    }
    void Start()
    {
        
    }
}
