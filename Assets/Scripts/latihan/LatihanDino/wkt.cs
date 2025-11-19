using System.Collections; // kalau pake ienumerator ditambahin
using TMPro;
using UnityEngine;


public class wkt : MonoBehaviour
{
    public DeteksiObjek deteksiObjek;
    public float waktu;//menyimpan waktu

    public TMP_Text textTimer;

    public bool WaktuBerjalan=true;
    
    public AudioSource TimerAlert;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       StartCoroutine(HitungTimer());        ;
    }

    // Update is called once per frame
    void Update()
    {
         if (waktu >=10)
        {
            WaktuBerjalan = false; 
            Application.Quit();
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying= false;
            #endif
        }
    }
    
    public IEnumerator HitungTimer()
    {
        while (WaktuBerjalan == true)
        {
            waktu = waktu + 1;
            if (waktu >= 5)
            {
                Debug.Log("Timer Alert");
                TimerAlert.Play();
            }
            textTimer.text = waktu.ToString();
            yield return new WaitForSeconds(1);//untuk delay tiap satu detik waktu bertambah satu       
        }

    }

    
}

