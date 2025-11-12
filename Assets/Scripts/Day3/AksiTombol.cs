using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AksiTombol : MonoBehaviour
{
    public Sprite assetGambar; //aset gambar yang akan dimasukkanke object image
    public Image Image; //component image pada scene
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text objectText;
    public void Aksi()
    {
        // Image.sprite = assetGambar; // mengganti gambar
        // objectText.text = "Tombol sudah diklik"; //mengganti text
        // Debug.Log("Tombol diklik");

        SceneManager.LoadScene("Day3 SceneBaru");
    }
}
