using UnityEngine;

public class SquareMoveNov13 : MonoBehaviour
{
//boolean untuk kontrol arah gerakan
//float untuk atur kecepatan
    public bool isMoveRight = true;

    public float kecepatan = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if (isMoveRight == true)
            {
                //gerak ke kanan
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
            }
            else
            {
                //gerak ke kiri
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
            }//gunakan kontrol boolean dan bikin gerak 
    }
}
