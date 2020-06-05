using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    // Input
    public int XCount;
    public int YCount;
    public float Indent;

    public Transform StartTransform;

    public GameObject CoinPrefab;

    public Transform Parent;

    // May be it`s better to store coinControllers instead GameObjects
    GameObject[][] board;

    void Start()
    {
        var startPos = new Vector3(StartTransform.position.x, StartTransform.position.y, StartTransform.position.z);

        board = new GameObject[XCount][];

        for (int x = 0; x < XCount; x++)
        {
            board[x] = new GameObject[YCount];
            for (int y = 0; y < YCount; y++)
            {
                board[x][y] = Instantiate(CoinPrefab, CalculatePosition(startPos, x, y, Indent), Quaternion.identity, Parent);
                var coinController = board[x][y].GetComponent<CoinController>();
                coinController.SetPositionOnBoard(x, y);

                if ((x + y) % 2 == 0)
                {
                    coinController.Flip();
                }
            }
        }
    }

    private Vector3 CalculatePosition(Vector3 startPosition, int x, int y, float indent)
    {
        return new Vector3(
            startPosition.x + x * indent,
            startPosition.y,
            startPosition.z + y * indent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
