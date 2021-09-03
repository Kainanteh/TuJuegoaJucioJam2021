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
                if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
                {
                    return "Borrar espacios";
                }
                else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
                {
                    return "Delete spaces";
                }
                else
                {
                    return "";
                }
               
            }

            case Actions.ButtonActions.deletesimbol:
            {
                
                if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
                {
                    return "Borrar espacios";
                }
                else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
                {
                    return "Delete symbols";
                }
                else
                {
                    return "";
                }

            }

            case Actions.ButtonActions.deletenumber:
            {

                if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
                {
                    return "Borrar numeros";
                }
                else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
                {
                    return "Delete numbers";
                }
                else
                {
                    return "";
                }

            }

            case Actions.ButtonActions.deletechars:
            {

                if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
                {
                    return "Borrar letras";
                }
                else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
                {
                    return "Delete letters";
                }
                else
                {
                    return "";
                }

            }

            case Actions.ButtonActions.mayus:
            {

                if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
                {
                    return "Todo mayusculas";
                }
                else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
                {
                    return "All uppercase";
                }
                else
                {
                    return "";
                }

            }

            case Actions.ButtonActions.minus:
            {

                if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
                {
                    return "Todo mayusculas";
                }
                else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
                {
                    return "All lowercase";
                }
                else
                {
                    return "";
                }

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
