using System.Collections.Generic;
using Unity.Android.Gradle;
using UnityEngine;
using UnityEngine.UIElements;

public class ContohArray : MonoBehaviour
{
    [SerializeField]

    // menampilkan Array of Player
    // membuat array yang menyimpan 3 data nama Aku, Kamu dan Dia
    // Player[] ArrayPlayer;

    // void Start()
    // {
    //     for (int index = 0; index < ArrayPlayer.Length; index++)
    //     {
    //         Debug.Log(ArrayPlayer[index].Name);
    //     }
    //     foreach (Player player in ArrayPlayer)
    //     {
    //         Debug.Log(player.Name);
    //     }
    //     Debug.Log("Jumlah Player: " + ArrayPlayer.Length);
    // }

    // List<string> ListPlayer = new List<string>();
    // void Start()
    // {
    //     ListPlayer.Add("Aku");
    //     ListPlayer.Add("Kamu");
    //     ListPlayer.Add("Dia");

    //     string name = ListPlayer.Find(element => element == "Kamu");
    //     Debug.Log("Nama Player yang dicari: " + name);
    //     bool isExist = ListPlayer.Exists(element => element == "Admin");
    //     Debug.Log("Apakah Admin ada di ListPlayer? " + isExist);
    //     //ListPlayer.RemoveAt(0);
    //     //ListPlayer.insrt(1,"Admin");

    //     Debug.Log("Jumlah Player: " + ListPlayer.Count);
    // }

    // List<Player> ListPlayer = new List<Player>();
    // void Start()
    // {
    //     List<Player> ListBaru = new List<Player>();
    //     ListBaru = ListPlayer.FindAll(element => element.Level > 15);
    //     Player player = ListPlayer.Find(element => element.Level > 15);
    //     foreach (Player p in ListBaru)
    //     {
    //         Debug.Log("Nama Player Level > 15: " + p.Name);
    //     }
    // } untuk menampilkan semua player yg levelnya diatas 15
    
    
    List<Player> ListPlayer = new List<Player>();
    void Start()
    {
        Player player = ListPlayer.Find(element => element.Level > 15);
        Debug.Log("Nama Player Level > 15: " + player.Name);
        }
    }

