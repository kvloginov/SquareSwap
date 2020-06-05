using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public bool IsTails = false;

    [SerializeField]
    private Vector2Int positionOnBoard;

    void Start()
    {
        transform.Rotate(0, Random.Range(0, 360) , 0);
        //if (IsTails)
        //{
        //    Flip();
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPositionOnBoard(int x, int y)
    {
        positionOnBoard = new Vector2Int(x, y);
    }

    public void Flip()
    {
        IsTails = !IsTails;

        transform.Rotate(0, 0, 180);
    }
}
