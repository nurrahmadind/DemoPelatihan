using System.Data.Common;
using UnityEngine;

public class SquareMove12 : MonoBehaviour
{
    public bool isMoveRight = true;
    public float kecepatan = 5.0f;

    public bool isMove = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        //bergerak
        // ke kanan
        // ke kiri
        //tidakbergerak

        if (isMove)
        {
            if (isMoveRight)
            {
                //gerak ke kanan
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
            }
            else
            {
                //gerak ke kiri
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
            }
        }
        else
        {
            //tidak bergerak
            gameObject.transform.Translate(0, 0, 0);
        }
    }
}
