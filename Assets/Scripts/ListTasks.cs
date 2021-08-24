using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ListTasks : MonoBehaviour
{

    public List<Transform> PositionsTasks = new List<Transform>();

    public GameObject GameTask;

    // const string glyphs = "abcdefghijklmnopqrstuvwxyz0123456789";

    private void Start()
    {

        // AddTask();

    }

    private void Update() 
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {

            AddTaskToList();

        }

    }

    private void AddTaskToList()
    {
        Transform EmptyPosition = GetEmptyPosition();

        if (EmptyPosition != null)
        {

            SetTask(EmptyPosition);

        }
        else
        {

            //Todas las posiciones estan "ocupadas"
            Debug.Log("ocupadas");

        }
    }

    private void SetTask(Transform EmptyPosition)
    {

        // Task newTask = Instantiate(GameTask,EmptyPosition).GetComponent<Task>();

        Task newTask = GameManager.Instance.GetTask();

        if(newTask==null){return;}

        newTask.transform.SetParent(EmptyPosition);
        newTask.transform.position = EmptyPosition.position;
        newTask.TaskInList = true;
        newTask.GetComponent<TextMeshProUGUI>().text = newTask.TaskId;
  

        // string newId = "";
        // for (int i = 0; i < 7; i++)
        // {
        //     newId += glyphs[Random.Range(0, glyphs.Length)];
        // }
        // newTask.TaskId = newId;
        // newTask.name = newId;

    }

    public Transform GetEmptyPosition()
    {

        for (int i = 0; i < PositionsTasks.Count ; i++)
        {

            // Debug.Log(PositionsTasks[i].name + " " + PositionsTasks[i].childCount);

            if(PositionsTasks[i].childCount == 0)
            {

                // Debug.Log(PositionsTasks[i].name + " " + PositionsTasks[i].GetChild(0).name);
                return PositionsTasks[i];

            }

        }
        
        return null;

    }


}
