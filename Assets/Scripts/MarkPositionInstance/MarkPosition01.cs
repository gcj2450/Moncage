using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkPosition01 : MarkPositionBase{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override float DoEvent()//return the wait time
    {
        print("position1 in");
        exitIsActive = true;
        return 1f;
    }

    public override void DoExitEvent()
    {
        if (exitIsActive)
        {
            exitIsActive = false;
            print("position1 exit");
        }        
    }
}
