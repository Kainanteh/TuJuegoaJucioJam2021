using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Task : MonoBehaviour,IPointerClickHandler
{

    public string TaskId;

    public string TaskInfo;

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
            GameManager.Instance.SetTextTaskInfo(TaskInfo);
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
