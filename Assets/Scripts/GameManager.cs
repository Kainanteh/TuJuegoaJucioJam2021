using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance { get; private set; }

    

    public List<Task> AllTasks = new List<Task>();
    public Task ActualTask;

    public TextLink TLNombre;
    public TextLink TLApellidos;
    public TextLink TLNacimiento;
    public TextLink TLEdad;
    public TextLink TLCiudad;

    [SerializeField]
    private TextMeshProUGUI TMPTaskInfo;

    [SerializeField]
    private TextMeshProUGUI TMPTextPass;

    [SerializeField]
    private TextMeshProUGUI TMPTextActionSelected;

    public ActionSelected ScriptActionSelected;


    private bool EffecType = false;
    private bool EffecTypeTaskInfo = false;
    private bool EffecTypeTextLink = false;

    Coroutine CouroutineTaskInfo;


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

                ActualTask = AllTasks[i];
                return AllTasks[i];

            }

        }

        return null;

    }

    public void DeselectAllTaskList()
    {

        for (int i = 0; i < AllTasks.Count; i++)
        {

            if (AllTasks[i].TaskInList == true)
            {


                AllTasks[i].SquareTask(false);
            

            }

        }

    }

    public void SetTextTaskInfo(string textString)
    {

        // TMPTaskInfo.text = textString;
        
        if(EffecTypeTaskInfo == true)
        {
           
            StopCoroutine(CouroutineTaskInfo);
        }
        else
        {
            EffecTypeTaskInfo = true;
        }
        CouroutineTaskInfo = StartCoroutine(TypeText(TMPTaskInfo, textString, 0.02f,true));

        

    }

    public void SetTextUserInfo(User user)
    {

      
       
        TLNombre.SetTextLink(user.nombre);
        TLApellidos.SetTextLink(user.apellidos);
        TLNacimiento.SetTextLink(user.nacimiento);
        TLEdad.SetTextLink(user.edad);
        TLCiudad.SetTextLink(user.ciudad);

        

    }

    public void SetTextActionSelected(string textString)
    {

        TMPTextActionSelected.text = textString;

    }

    #region TextPass

    public void SetTextPass(string textString)
    {

        string ToFormat = TMPTextPass.text + " " + textString;

        TextToPass(ToFormat);

        // TMPTextPass.text += " " + textString;

    }

    public void DeleteTextPass()
    {
        TMPTextPass.text = "";
    }

    public void DeleteSpacesPass()
    {
        string ToFormat = TMPTextPass.text;
        ToFormat = ToFormat.Replace(" ", "");
        TextToPass(ToFormat);
    }

    public void DeleteNumbersPass()
    {
        string ToFormat = TMPTextPass.text;
      
        const string regex = @"\d";

        ToFormat = Regex.Replace(ToFormat, regex, string.Empty);

        TextToPass(ToFormat);

    }

    public void DeleteSymbolsPass()
    {
        string ToFormat = TMPTextPass.text;

        const string regex = @"[^0-9a-zA-Z]+";

        ToFormat = Regex.Replace(ToFormat, regex, string.Empty);

        TextToPass(ToFormat);

    }

    public void MayusPass()
    {
        string ToFormat = TMPTextPass.text;

        ToFormat = ToFormat.ToUpper();

        TextToPass(ToFormat);

    }

    public void MinusPass()
    {
        string ToFormat = TMPTextPass.text;

        ToFormat = ToFormat.ToLower();

        TextToPass(ToFormat);

    }

    private void TextToPass(string newText)
    {

        if(newText.Length >= 36)
        {

             newText = newText.Substring(0,newText.Length-(newText.Length-21));

            //DeleteTextPass();

        }
        else if (EffecType == false)
        {
            EffecType = true;
            // TMPTextPass.text = newText;
            StartCoroutine(TypeText(TMPTextPass,newText,0.1f));

        }

        // Debug.Log(TMPTextPass.textInfo.);
        // if(TMPTextPass.isTextTruncated == false)
        // {
           
        // } 

        
    }

    #endregion


    // Posicion Raton/Dedo en la pantalla
    public Vector3 GetMouseAsWorldPoint()
    {

        Vector3 mousePoint = Input.mousePosition;

        return new Vector3(Camera.main.ScreenToWorldPoint(mousePoint).x
        , Camera.main.ScreenToWorldPoint(mousePoint).y, 0f);

    }

    // Efecto maquina de escribir para el texto de la clave
    public IEnumerator TypeText(TextMeshProUGUI TMP, string text, float delay)
    {
        
        for (int i = 0; i <= text.Length; i++)
        {

            TMP.text = text.Substring(0, i);
            yield return new WaitForSeconds(delay);

        }
        EffecType = false;
    }

    public IEnumerator TypeText(TextMeshProUGUI TMP, string text, float delay, bool TaskInfo)
    {

        for (int i = 0; i <= text.Length; i++)
        {

            TMP.text = text.Substring(0, i);
            yield return new WaitForSeconds(delay);

        }
        EffecTypeTaskInfo = false;
    }



  

}
