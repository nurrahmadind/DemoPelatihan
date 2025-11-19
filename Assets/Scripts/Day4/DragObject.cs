using UnityEngine;

public class DragObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void OnMouseEnter()
    // {
    //     Debug.Log("Mouse Enter");
    // }
    // void OnMouseDown()
    // {
    //     Debug.Log("Mouse Down");
    // }
   
    // void OnMouseExit() //ketika pointer keluar dari object
    // {
    //     Debug.Log("Mouse Exit");
    // }

     void OnMouseDrag()
    {
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);// mengambil posisi mouse di world
        transform.position = worldMousePosition; // mengubah posisi object sesuai dengan posisi mouse
        

        //jika ingin dibatasi di dengan keadaan tertentu sb X
        // Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // Vector2 squarePosition = new Vector2(Input.mousePosition.x, transform.position.y);
        // Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        // Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));
                
        //jika hanya bergerak di sumbu x 
        //Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //squarePosition.x = Mathf.Clamp(squarePosition.x, -8, 8);
        //transform.position = squarePosition;
     }
    
}
