using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkPositionBase : MonoBehaviour {

    [HideInInspector]
    public bool exitIsActive = false;
    [HideInInspector]
    public int phase = 0;//it is for different animations for different phases

    public Vector2 GetRotation()//returns only x and y of the eulars
    {
        return new Vector2(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y);
    }

    public virtual float DoEvent()//return the wait time
    {
        //active exit function
        exitIsActive = true;
        //change phase
        return 0f;
    }

    public virtual void DoExitEvent()
    {
        if (exitIsActive)
        {
            //revert part
        }
    }

    public virtual void DoEffect()
    {

    }

    public virtual void DoAnimation()
    {

    }

    public virtual void RenewMarkPositionGroup()
    {

    }

    public virtual void RenewInteractiveItems()
    {

    }

    public virtual void SetPhase(int _phase)//used for reset
    {
        phase = _phase;
        //extra things to do?
    }
}
