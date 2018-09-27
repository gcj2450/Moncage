using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePartBase : MonoBehaviour {

    public int phase = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetPhase(int _phase)//used for reset
    {
        phase = _phase;
        switch (phase)
        {
            case 0:
                break;
            default:
                break;
        }
    }

    
}
