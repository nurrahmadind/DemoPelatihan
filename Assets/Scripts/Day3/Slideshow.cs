using UnityEngine;
using UnityEngine.UI;

public class Slideshow : MonoBehaviour
{
    public DatabaseGambar databaseGambar;

    public Image objectImage;

    public int index = 0;// Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Next()
    {
        if (index >= databaseGambar.ListGambar.Count - 1)
        {
            index = 0;
        }
        else
        {
            index = index + 1;
        }        
        objectImage.sprite = databaseGambar.ListGambar[index];
    }
    public void Previous()
    {
        if (index <= 0)
        {
            index = databaseGambar.ListGambar.Count - 1;
        }
        else
        {
            index = index - 1;
        }         
        objectImage.sprite = databaseGambar.ListGambar[index];
    }   
}
