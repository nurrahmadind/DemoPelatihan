using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Score : MonoBehaviour
{
    // // Start is called once before the first execution of Update after the MonoBehaviour is created
    // public int score;

    // public void AddScore()
    // {
    //     score = score + 1;
    // }

    public PendeteksiInput objectPendeteksiInput;

    public int score;

    private void OnEnable()
    {
        //Listen ke event dari objectPendeteksiInput
        //objectPendeteksiInput.inputEvent += AddScore;
        //objectPendeteksiInput.inputEvent.AddListener(AddScore);
    }

    public void AddScore()
    {
        score = score + 1;
    }

    private void OnDsable() //jika object ini di disable atau di destroy
    {
        //Unlisten ke event dari objectPendeteksiInput
        //objectPendeteksiInput.inputEvent -= AddScore;
        //objectPendeteksiInput.inputEvent.RemoveListener (AddScore);
    }
} 