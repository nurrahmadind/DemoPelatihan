using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MainMenu : MonoBehaviour
{
    public int highScore; //classnya int untuk menyimpan highscore
    //variabel untuk menyimpan highscore
    public TMP_Text teksHighScore;
    void Start()
    {
        if (PlayerPrefs.HasKey("highscore"))//untuk mengecek apakah sudah ada key highscore
        {
        highScore = PlayerPrefs.GetInt("highscore"); 
        teksHighScore.text = "High Score : " + highScore;
        }
    }
    
    public void Play() //method untuk memulai game
    {
        SceneManager.LoadScene("PlayerPrefs");
    }
}
