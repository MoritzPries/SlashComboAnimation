using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slashComboAnimation : StateMachineBehaviour
{

    public string IntParameterName;
    private int StateCount;
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        StateCount = animator.GetInteger(IntParameterName);

        switch (StateCount)
        {
            case 0:
                animator.SetInteger(IntParameterName, 1);
                break;
            case 1:
                animator.SetInteger(IntParameterName, 2);
                break;
            case 2:
                animator.SetInteger(IntParameterName, 0);
                break;    
        }

    }
}
