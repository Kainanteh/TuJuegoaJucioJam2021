using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Task : MonoBehaviour,IPointerClickHandler
{

    public string TaskId;

    public string TaskInfo;

    public string TaskInfoEnglish;

    public bool TaskInList = false;

    public Objective TaskObjective;

    public User TaskUser;

    [SerializeField]
    GameObject SelectionSquare;

    public void OnPointerClick(PointerEventData eventData)
    {

        RaycastHit2D hitInfo = Physics2D.Raycast(GameManager.Instance.GetMouseAsWorldPoint(),
         Vector2.zero, Mathf.Infinity, 1 << LayerMask.NameToLayer("Task"));

        if (hitInfo)
        {

            GameManager.Instance.ActualTask = this;

            if(GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                GameManager.Instance.SetTextTaskInfo(TaskInfo);
            }
            else if(GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                GameManager.Instance.SetTextTaskInfo(TaskInfoEnglish);
            }

            GameManager.Instance.SetTextUserInfo(TaskUser);
            GameManager.Instance.DeselectAllTaskList();
            SquareTask(true);

            GameManager.Instance.PassInput = "";
            GameManager.Instance.DeleteTextPass();
            
        }

    }

    public void SquareTask(bool active)
    {
        if(SelectionSquare==null){return;}
        SelectionSquare.SetActive(active);


    }



}
