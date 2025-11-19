using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public TMP_Text objectText;
    public void HomePage()
    {
        SceneManager.LoadScene("Play");
    }
    public void ExitGame()
    {
        Debug.Log("Keluar dari Game");
        
        // Perintah standar untuk keluar dari aplikasi. 
        // Ini hanya akan bekerja saat game sudah di-build (file .exe).
        Application.Quit();

        // Optional: Baris di bawah ini hanya untuk membuat tombol Quit berfungsi
        // saat Anda mengujinya di Unity Editor. Hapus baris ini saat di-build.
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }// Start is called once before the first execution of Update after the MonoBehaviour is created
}
