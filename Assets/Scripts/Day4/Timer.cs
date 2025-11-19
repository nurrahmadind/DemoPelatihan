using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float waktu; //float ialah class untuk menampung angka desimal
    //waktu adalah variable yang menampung nilai dari waktu
    
    public int MaximumWaktu;
    //int ialah class untuk menampung angka bulat
    //MaximumWaktu adalah variable yang menampung nilai dari waktu maksimal
    public TMP_Text  TextTimer;
    //TMP_Text ialah class untuk menampung text
    public bool WaktuBerjalan;
    //bool berguna untuk menampung nilai true atau false
    //WaktuBerjalan adalah variable yang menampung nilai dari waktu berjalan
    //bool digunakan untuk menentukan apakah waktu berjalan atau tidak

    public KeyCode StartCoroutineKey;
    //Keycode ialah class untuk menampung keycode
    //StartCoroutineKey adalah variable yang menampung nilai dari keycode untuk memulai coroutine

    public KeyCode StopCoroutineKey;
    //StopCoroutineKey adalah variable yang menampung nilai dari keycode untuk menghentikan coroutine

    public Coroutine HitungTimerCoroutine;
    //Coroutine ialah class untuk menampung coroutine
    //coroutine berfungsi untuk menjalankan perintah secara berurutan
    //HitungTimerCoroutine adalah variable yang menampung nilai dari coroutine

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
        if(Input.GetKeyDown(StopCoroutineKey))//getkeydown untuk mengetahui apakah ada key yang ditekan
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
        while (WaktuBerjalan == true && waktu < MaximumWaktu)// fungsi pada baris ini berfungsi untuk menampilkan timer
        //waktu berjalan adalah boolean yang menentukan apakah timer berjalan atau tidak
        //waktu < MaximumWaktu adalah untuk menentukan apakah waktu sudah mencapai batas maksimal atau belum
        //waktu adalah variabel yang menentukan berapa detik yang sudah berjalan
        //MaximumWaktu adalah variabel yang menentukan berapa detik yang akan berjalan
        {
        waktu = waktu +1;
        TextTimer.text = waktu.ToString();
        ProgressFill.fillAmount = waktu/ MaximumWaktu;
        yield return new WaitForSeconds(1);
        }
    }
}
