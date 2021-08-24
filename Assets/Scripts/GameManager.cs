using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance { get; private set; }

    public List<Task> AllTasks = new List<Task>();
    
    public TextLink TLNombre;
    public TextLink TLApellidos;
    public TextLink TLNacimiento;
    public TextLink TLEdad;
    public TextLink TLCiudad;

    [SerializeField]
    private TextMeshProUGUI TMPTaskInfo;

    [SerializeField]
    private TextMeshProUGUI TMPTextPass;

    public ActionSelected ScriptActionSelected;

    private void Awake()
    {

        Instance = this;

        DontDestroyOnLoad(this.gameObject);

    }

    public Task GetTask()
    {

        for (int i = 0; i < AllTasks.Count; i++)
        {

            if (AllTasks[i].TaskInList == false)
            {

                return AllTasks[i];

            }

        }

        return null;

    }

    public void SetTextTaskInfo(string textString)
    {

        TMPTaskInfo.text = textString;

    }

    public void SetTextUserInfo(User user)
    {

        TLNombre.SetTextLink(user.nombre);
        TLApellidos.SetTextLink(user.apellidos);
        TLNacimiento.SetTextLink(user.nacimiento);
        TLEdad.SetTextLink(user.edad);
        TLCiudad.SetTextLink(user.ciudad);

    }

    #region TextPass

    public void SetTextPass(string textString)
    {
        TMPTextPass.text += " " + textString;
    }

    public void DeleteTextPass()
    {
        TMPTextPass.text = "";
    }

    #endregion


    // Posicion Raton/Dedo en la pantalla
    public Vector3 GetMouseAsWorldPoint()
    {

        Vector3 mousePoint = Input.mousePosition;

        return new Vector3(Camera.main.ScreenToWorldPoint(mousePoint).x
        , Camera.main.ScreenToWorldPoint(mousePoint).y, 0f);

    }

  

}
