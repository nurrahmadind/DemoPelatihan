using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Timer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int waktu;
    public TMP_Text  TextTimer;
    public bool WaktuBerjalan;

    public KeyCode StartCoroutineKey;

    public KeyCode StopCoroutineKey;

    public Coroutine HitungTimerCoroutine;
    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(StartCoroutineKey))
        {
            HitungTimerCoroutine=StartCoroutine(HitungTimer());
        }
        if(Input.GetKeyDown(StopCoroutineKey))
        {
            if (HitungTimerCoroutine !=null)
            {
                 StopCoroutine(HitungTimerCoroutine);
            }
        }
    }
    IEnumerator HitungTimer()
    {
        while (WaktuBerjalan == true)
        {
        waktu = waktu +1;
        TextTimer.text = waktu.ToString();
        yield return new WaitForSeconds(1);
        }
    }
}
