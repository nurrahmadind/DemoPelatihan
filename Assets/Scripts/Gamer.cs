using UnityEngine;

public class Gamer : MonoBehaviour
{
    [SerializeField]

    Player player;
    void Start()
    {
        Debug.Log("Nama Player: " + player.Name);    }
 }
