using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionSelected : MonoBehaviour
{

    [SerializeField]
    private Actions.ButtonActions[] ActionsForSelection;

    [SerializeField]
    private Actions.ButtonActions SelectedAction;

    [SerializeField]
    private int ActualIndexAction = 0;


    public int GetNextIndex()
    {
        if (ActualIndexAction + 1 >= ActionsForSelection.Length) 
        {
            ActualIndexAction = 0;
            ChangeActionSelected(ActualIndexAction);
            return ActualIndexAction; 
        }
        ActualIndexAction = ActualIndexAction + 1;
        ChangeActionSelected(ActualIndexAction);
        return ActualIndexAction;
    }

    public int GetPreviousIndex()
    {
        if (ActualIndexAction - 1 < 0) 
        {
            ActualIndexAction = ActionsForSelection.Length - 1;
            ChangeActionSelected(ActualIndexAction);
            return ActualIndexAction; 
        }
        ActualIndexAction = ActualIndexAction - 1;
        ChangeActionSelected(ActualIndexAction);
        return ActualIndexAction;
    }

    public void ChangeActionSelected(int index)
    {

        SelectedAction = ActionsForSelection[index];

    }

}
