using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tile : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private GameObject highight;


    public void Init(bool isOffset){
        _renderer.color = isOffset ? offsetColor:baseColor;
    }

    void OnMouseEnter(){
        highight.SetActive(true);
    }
    void OnMouseExit(){
        highight.SetActive(false);
    }
    void OnMouseDown(){
        Debug.Log("클릭");
        GameObject T = InGameManager.instance.Unit[InGameManager.instance.Choice];
        Instantiate(T,transform.position,Quaternion.identity);
        
    }
}
