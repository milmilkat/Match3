using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellBehaviour : MonoBehaviour
{
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = GameManager.Instance.sprites[1];
    }

    void Start()
    {
        
    }

    public void OnMouseDrag()
    {
        
    }
}
