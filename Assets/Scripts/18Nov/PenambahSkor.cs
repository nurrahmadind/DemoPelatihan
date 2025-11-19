using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PenambahSkor : MonoBehaviour
{
    public int highScore = 0;
    public int skor=0;
    public TMP_Text teksSkor; //untuk menampilkan text
    public TMP_Text teksHighSkor; //untuk menampilkan text

    private void Start()
    {
        if (PlayerPrefs.HasKey("highscore"))
        {
        
            // {
            //     PlayerPrefs.SetInt("highscore", skor);
            // }
            highScore = PlayerPrefs.GetInt("highscore");
            teksHighSkor.text = "Highscore : " + highScore.ToString(); //teksnya di update

        }
    }

    public void TambahSkor() //function
    {
        skor = skor +1;
        teksSkor.text = "Score : " + skor.ToString();//mengubah int skor ke string
    }
    public void KurangSkor()
    {
        skor = skor -1;
        teksSkor.text="Score : " + skor.ToString();
    }

    public void SimpanHighScore()
    {
        PlayerPrefs.SetInt("lastscore", skor);
        if (skor > highScore)
        {
        highScore=skor;
        PlayerPrefs.SetInt("higscore", highScore);//parameternya "kuncinilainya" = highScore, untuk nilainya = highScore yang terakhir
        PlayerPrefs.Save();
        teksHighSkor.text = "High Score : " + highScore.ToString();
        }
        // PlayerPrefs.DeleteKey("highscore");
        
    }
    public void KeMainMenu ()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene("PlayerPrefs");


    }
}
