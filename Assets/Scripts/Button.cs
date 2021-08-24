using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerClickHandler
{

    [SerializeField]
    private Actions.ButtonActions ButtonAction;

    public void ChangeButtonAction(Actions.ButtonActions newAction)
    {

        ButtonAction = newAction;

    }

    public void OnPointerClick(PointerEventData eventData)
    {

        RaycastHit2D hitInfo = Physics2D.Raycast(GameManager.Instance.GetMouseAsWorldPoint(),
         Vector2.zero, Mathf.Infinity, 1 << LayerMask.NameToLayer("Button"));

        if (hitInfo)
        {

           switch(ButtonAction)
           {

            case Actions.ButtonActions.delete:
            {

                GameManager.Instance.DeleteTextPass();

                break;

            }

            case Actions.ButtonActions.nextAction:
            {

                GameManager.Instance.ScriptActionSelected.GetNextIndex();

                break;

            }

            case Actions.ButtonActions.previousAction:
            {

                GameManager.Instance.ScriptActionSelected.GetPreviousIndex();

                break;

            }



           }

        }

    }


}
