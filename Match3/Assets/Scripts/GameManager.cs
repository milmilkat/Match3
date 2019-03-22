using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{

    public Sprite[][] Cells;
    public int Rows;
    public int Cols;
    public GameObject CellPrefab;
    public Sprite[] sprites;
    public Text test;
    public Text test2;

    private void Start()
    {
        //Debug.Log(Camera.main.WorldToScreenPoint(transform.position));


        Cells = new Sprite[Rows][];
        for (int i = 0; i < Rows; i++)
            Cells[i] = new Sprite[Cols];

        

        for(int i = 0; i < Rows; i++)
            for(int j = 0; j < Cols; j++)
            {
                GameObject instantiated = Instantiate(CellPrefab, transform, true);
                instantiated.transform.localPosition = new Vector3(i * 2, -j * 2, 0);
            }

        //transform.position = new Vector3(0, 0, 0);
        //transform.localPosition = new Vector3(0, 0, 0);

    }

    private void Update()
    {
        test.text = Camera.main.WorldToScreenPoint(transform.position).ToString();
        test2.text = transform.position.ToString();
    }
}
