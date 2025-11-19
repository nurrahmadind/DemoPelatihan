using System.Collections; // kalau pake ienumerator ditambahin
using TMPro;
using UnityEngine;


public class timer : MonoBehaviour
{
    public DeteksiObjek deteksiObjek;
    public float waktu;

    public TMP_Text textTimer;

    public bool WaktuBerjalan=true;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       StartCoroutine(HitungTimer());        ;
    }

    // Update is called once per frame
    void Update()
    {
         if (waktu <= 0)
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
            waktu = waktu - 1;
            textTimer.text = waktu.ToString();
            yield return new WaitForSeconds(1);
        }

    }

    
}

