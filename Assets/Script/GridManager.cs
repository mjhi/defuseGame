using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public GameObject TileParent;
    [SerializeField]private int width,height;
    [SerializeField] private Tile titlePrefab;
    [SerializeField] private Transform _cam;
    void GenerateGrid(){
        for(int x=0; x<width; x++){
            for(int y=0; y<height; y++){
                var spwanedTile = Instantiate(titlePrefab,new Vector3(TileParent.transform.position.x+x,TileParent.transform.position.y+y),Quaternion.identity);
                spwanedTile.name = $"Tile{x}{y}";
                spwanedTile.transform.parent = TileParent.transform;
                var isOffset = (x%2==0&&y%2!=0) || (x%2!=0&&y%2==0);
                spwanedTile.Init(isOffset);
            }
        }

        _cam.transform.position = new Vector3(TileParent.transform.position.x+width/2f-0.5f,(TileParent.transform.position.y+height/2f-0.5f),-10);
    }
    // Start is called before the first frame update
    void Start()
    {
        GenerateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
