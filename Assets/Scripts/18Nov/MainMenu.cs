using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MainMenu : MonoBehaviour
{
    public int highScore;
    public TMP_Text teksHighScore;
    void Start()
    {
        if (PlayerPrefs.HasKey("highscore"))
        {
        highScore = PlayerPrefs.GetInt("highscore");
        teksHighScore.text = "High Score : " + highScore;
        }
    }
    
        public void Play()
    {
        SceneManager.LoadScene("PlayerPrefs");
    }
}
