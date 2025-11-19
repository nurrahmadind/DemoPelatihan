using UnityEngine;

public class ArahGerakPohon : MonoBehaviour
{

    public float kecepatan = 3.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //gerak ke kiri
        gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
        //gunakan kontrol boolean dan bikin gerak 
    }
}
