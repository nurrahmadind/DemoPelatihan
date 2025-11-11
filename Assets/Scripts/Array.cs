using UnityEngine;
using UnityEngine.UIElements;

public class ContohArray : MonoBehaviour
{
    [SerializeField]
    //membuat array yang menyimpan 3 data nama Aku, Kamu dan Dia
    Player[] ArrayPlayer;

    void Start()
    {
        for (int index = 0; index < ArrayPlayer.Length; index++)
        {
            Debug.Log(ArrayPlayer[index].Name);
        }
        foreach (Player player in ArrayPlayer)
        {
            Debug.Log(player.Name);
        }
        Debug.Log("Jumlah Player: " + ArrayPlayer.Length);
    }
}