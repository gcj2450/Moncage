using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkPositionGroupManager : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public MarkPositionBase CheckForCameraSnapTarget(float x, float y)
    {
        foreach (Transform child in transform)
        {
            if (child.gameObject.activeSelf == true)
            {
                if (isMarkInRange(x, y, child.GetComponent<MarkPositionBase>().GetRotation()))
                {
                    return child.GetComponent<MarkPositionBase>();
                }
            }
        }
        return null;
    }

    bool isMarkInRange(float x, float y, Vector2 markXY)
    {
        if (Mathf.Abs(x - markXY.x) < 2f && Mathf.Abs(y - markXY.y) < 2f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
