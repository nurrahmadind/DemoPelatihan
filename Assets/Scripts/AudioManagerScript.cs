using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public AudioSource _BGM;
    public AudioSource _SFX; //untuk memasukkan audio source sfx
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log ("Pencet Spasi");
            PutarBGM();
        }
    }

    public void PutarBGM()
    {
        _BGM.loop =true;
        _BGM.Play();
    } //soundefek bisa dipanggil ketika klik spasi
    

//jika berbenturan dengan objek, suara akan muncul
//di unity obejeknya add component audio source
//di inspector tambahkan audio clip
//di inspector tambahkan audio source
    public void PutarSFX()
    {
        _SFX.Play();
    }
        
    void OnCollisionEnter2D(Collision2D collision)
    {
        PutarSFX();
    }
}


