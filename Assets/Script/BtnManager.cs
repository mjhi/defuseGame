using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(InGameManager.instance.stageinfo);
    }   

    // Update is called once per frame
    void Update()
    {
        
    }

    void RefreshUnit(){

    }
    public void Choice1Btn()
    {
        InGameManager.instance.Choice = 0;
    }
}
