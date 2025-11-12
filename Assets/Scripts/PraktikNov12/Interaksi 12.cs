using UnityEngine;

public class Interaksi12 : MonoBehaviour
{
    public SquareMove squareMove;// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GerakAtas()
    {
        squareMove.arahGerak = ArahGerak.atas;

    }

    public void GerakBawah()
    {
        squareMove.arahGerak = ArahGerak.bawah;
    }
    public void GerakKanan()
    {
        squareMove.arahGerak = ArahGerak.kanan;
    }
    public void GerakKiri()
    {
        squareMove.arahGerak = ArahGerak.kiri;
    }
}