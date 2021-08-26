﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerClickHandler
{

    [SerializeField]
    private Actions.ButtonActions ButtonAction;

    public Animation AnimButton;

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
            PlayActionButton();
            AnimButton.Play();

        }

    }

    private void PlayActionButton()
    {

        switch (ButtonAction)
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

            case Actions.ButtonActions.playAction:
            {

                PlayActionButton(GameManager.Instance.ScriptActionSelected.GetSelectedAction());

                break;

            }



        }
    }

    private void PlayActionButton(Actions.ButtonActions actionSelected)
    {

        switch (actionSelected)
        {

            case Actions.ButtonActions.deletespace:
            {

                GameManager.Instance.DeleteSpacesPass();

                break;

            }

            case Actions.ButtonActions.deletenumber:
            {

                GameManager.Instance.DeleteNumbersPass();

                break;

            }

            case Actions.ButtonActions.deletesimbol:
            {

                GameManager.Instance.DeleteSymbolsPass();

                break;

            }

            case Actions.ButtonActions.mayus:
            {

                GameManager.Instance.MayusPass();

                break;

            }

            case Actions.ButtonActions.minus:
            {

                GameManager.Instance.MinusPass();

                break;

            }

        }

    }
}