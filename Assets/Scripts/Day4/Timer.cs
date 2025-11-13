using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float waktu;
    
    public int MaximumWaktu;
    public TMP_Text  TextTimer;
    public bool WaktuBerjalan;

    public KeyCode StartCoroutineKey;

    public KeyCode StopCoroutineKey;

    public Coroutine HitungTimerCoroutine;

    public Image ProgressFill;
    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(StartCoroutineKey))
        {
            if (HitungTimerCoroutine==null)
            {
            HitungTimerCoroutine=StartCoroutine(HitungTimer()); 
            }
        }
        if(Input.GetKeyDown(StopCoroutineKey))
        {
            if (HitungTimerCoroutine !=null)
            {
                 StopCoroutine(HitungTimerCoroutine);
                 HitungTimerCoroutine = null; //balik ke 0, atau permainan awal
            }
        }
    }
    IEnumerator HitungTimer()
    {
        while (WaktuBerjalan == true && waktu < MaximumWaktu)
        {
        waktu = waktu +1;
        TextTimer.text = waktu.ToString();
        ProgressFill.fillAmount = waktu/ MaximumWaktu;
        yield return new WaitForSeconds(1);
        }
    }
}
