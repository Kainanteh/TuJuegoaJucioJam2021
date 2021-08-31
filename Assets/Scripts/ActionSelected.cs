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


    public Actions.ButtonActions GetSelectedAction()
    {
        return SelectedAction;        
    }

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
        GameManager.Instance.SetTextActionSelected(ActionToText(SelectedAction));

    }

    public string ActionToText(Actions.ButtonActions action)
    {

        switch(action)
        {

            case Actions.ButtonActions.deletespace:
            {
                return "Borrar espacios";
            }

            case Actions.ButtonActions.deletesimbol:
            {
                return "Borrar simbolos";
            }

            case Actions.ButtonActions.deletenumber:
            {

                return "Borrar numeros";
            }

            case Actions.ButtonActions.deletechars:
            {
                return "Borrar letras";
            }

            case Actions.ButtonActions.mayus:
            {

                return "Todo mayusculas";
            }

            case Actions.ButtonActions.minus:
            {

                return "Todo minusculas";
            }

            // case Actions.ButtonActions.capitalice:
            // {

            //     return "Capitalizar";
            // }

            // case Actions.ButtonActions.descapitalice:
            // {
            //     return "Descapitalizar";
            // }

            default:
            {
                return "";
            }

        }

    }

}
