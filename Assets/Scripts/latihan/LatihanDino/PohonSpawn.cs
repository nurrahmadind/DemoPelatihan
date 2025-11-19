using System.Collections;
using UnityEngine;

public class PohonSpawnScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
public GameObject PohonSpawn;//apapun yang spawn harus jadi prefabs
    public bool sedangSpawn = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        StartCoroutine (MunculkanObject()); //memulai coroutine MunculkanObject
    }

    IEnumerator MunculkanObject () //ienumerator untuk membuat fungsi yang dapat dijalankan secara berurutan
    //munculobject sebagai fungsi yang dapat dijalankan secara berurutan
    //Ienumerator dipakai ketika menggunakan coroutine
    //coroutine juga harus menggunakan yield
    {
        while (sedangSpawn == true)
        //fungsi ini digunakan jika sedangSpawn bernilai true
        //jika sedangSpawn bernilai false, maka fungsi ini akan berhenti
        //fungsi ini akan terus berjalan selama sedangSpawn bernilai true
        
        {
            //Spawn Object
            Instantiate (PohonSpawn, new Vector3(7, -3.5f,0),Quaternion.identity); //mengatur kecepatan object
            //fungsi ini berguna untuk membuat object yang ada di variabel SpawnObject
            //new Vector3(Random.Range(-5,5), Random.Range(-5,5),0) berguna untuk membuat object tersebut muncul secara random di koordinat x dan y
            //Quaternion.identity berguna untuk membuat object tersebut memiliki orientasi yang sama dengan object yang membuatnya

            yield return new WaitForSeconds(3);//fungsi ini berguna untuk menunggu 3 detik sebelum membuat object baru
        }
    }
}

