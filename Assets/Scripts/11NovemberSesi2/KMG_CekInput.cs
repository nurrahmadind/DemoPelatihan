using UnityEngine;

public class KMG_CekInput : MonoBehaviour
{
    public GameObject _targetHancur;
    public GameObject _munculHilang;

    public GameObject _kotakBerwarna;
    public GameObject _untukSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tombol Spasi ditekan");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Tombol O ditekan. objek muncul");
            _munculHilang.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Tombol P ditekan. objek hilang");
            _munculHilang.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Tombol Enter ditekan");
            Vector3 spawnPosition = new Vector3(2, 3, 2);
            Quaternion spawnRotation = Quaternion.Euler(0, 5, 0);
            Instantiate(_untukSpawn, spawnPosition, spawnRotation);
            //spawanPosition dan spawnRotation untuk menentukan posisi dan rotasi objek spawn yang dihasilkan
            //spawn berguna untuk membuat objek baru

            // Instantiate(_untukSpawn, new Vector3 (Random.Range (-5,5), Random.Range (-5,5),0), Quaternion.Euler(0,0,0));
            //vector dan Quaternion untuk menentukan posisi dan rotasi objek spawn yang dihasilkan
            //apabila objek yang ingin muncul dititik yang random anda bisa menggunakan (Random.Range,Random.Range,Random.Range)
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            GameObject hancurkan = GameObject.Find("SpawnCapsule(Clone)");
            Debug.Log("Tombol M ditekan,Object hancur");
            // Destroy(_targetHancur); //untukmenghilangkan targethancur
            Destroy(hancurkan);

        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            SpriteRenderer _localspriteRenderer = _kotakBerwarna.GetComponent<SpriteRenderer>();

            // Color warnaAcak = new Color (Random.Range (0.0f,1.0f), Random.Range (0.0f,1.0f), Random.Range (0.0f,1.0f));
            // _localspriteRenderer.color = warnaAcak; // warna acak
            _localspriteRenderer.color = Color.red;
         
        }
    }
}
