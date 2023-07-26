using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameManager : MonoBehaviour
{
   
    public static InGameManager instance;
    public int Choice;
    public GameObject[] Unit; 
    public List<GameObject> w = new List<GameObject>();
    public List<int> StoreInt = new List<int>(3);
    public int stageinfo = 1;
    void Awake(){
        if(InGameManager.instance==null){
            InGameManager.instance = this;
            DontDestroyOnLoad(this);
        }
        else{
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Role();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Role()
    {
        
        StoreInt.Clear();
        int i=0;
        while(i!=3){
            bool qw = false;
            int t = Random.Range(0,w.Count);
            for(int j=0; j<StoreInt.Count; j++)
            {
                if(t==StoreInt[j]){
                    qw=true;
                }
            }
            if(qw)
            {
                continue;
            }
            StoreInt.Add(t);
            i+=1;
        }
    }
}
