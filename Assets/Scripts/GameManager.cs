using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance { get; private set; }

    public string PassInput = "";

    public List<Task> AllTasks = new List<Task>();
    public Task ActualTask;
    public int TasksNumber = 0;
    public int TaskMax;

    [HideInInspector] public TextLink TLNombre;
    [HideInInspector] public TextLink TLApellidos;
    [HideInInspector] public TextLink TLNacimiento;
    [HideInInspector] public TextLink TLEdad;
    [HideInInspector] public TextLink TLCiudad;

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
    public Coroutine CouroutineTutorial;

    public AudioSource SoundSource;
    public AudioClip[] AllSounds;

    public TextMeshProUGUI TMPTextPadlock;
    public bool InTutorial = true;

    public bool InFinal = false;

    public TextMeshProUGUI TMPTextTimer;
    public Progress ScriptProgress;

    public TextMeshProUGUI TMPTextTaskCompleted;
    int TaskCompleted = 0;
    public TextMeshProUGUI TMPTextTaskFail;
    int TaskFail = 0;
    public Final ScriptFinal;
    public Tutorial ScriptTutorial;

    private void Awake()
    {

        Instance = this;

        DontDestroyOnLoad(this.gameObject);

    }

    #region SetTaskUserInfo

    public Task GetTask()
    {

        for (int i = 0; i < AllTasks.Count; i++)
        {

            if (AllTasks[i].TaskInList == false)
            {

                // ActualTask = AllTasks[i];
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

    #endregion

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

    public void DeleteCharsPass()
    {
        string ToFormat = TMPTextPass.text;

        const string regex = @"\D+";

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
            StartCoroutine(TypeText(TMPTextPass,newText,0.05f));

        }

      
        newText = newText.Substring(1); 

        PassInput = newText;

        // Debug.Log(TMPTextPass.textInfo.);
        // if(TMPTextPass.isTextTruncated == false)
        // {
           
        // } 

        
    }

    #endregion


    public void PassToObjective()
    {

        if (ActualTask == null) { return; }

        Objective ActualObjective = ActualTask.TaskObjective;
        string ActualPass = PassInput;

        string Fails = "";

        if (ActualObjective.lengthOb != -1)
        {
            // La clave no se pasa del objetivo
            if (ActualPass.Length > ActualObjective.lengthOb)
            {
                Fails += "demasiado larga";
            }
        }
        if (ActualObjective.number == true)
        {

            string toCompare = "";
            const string regex = @"\d";

            toCompare = Regex.Replace(ActualPass, regex, string.Empty);

            // La clave tiene que tener numeros
            if(toCompare == ActualPass)
            {
                Fails += " , no tiene numeros";
            }
     
        }
        else
        {
            
            string toCompare = "";
            const string regex = @"\d";

            toCompare = Regex.Replace(ActualPass, regex, string.Empty);

            // La clave NO tiene que tener numeros
            if (toCompare != ActualPass)
            {
                Fails += " ,  tiene numeros";
            }
            
        }
        if (ActualObjective.allnumbers == true)
        {
            
            string toCompare = "";
            const string regex = @"\d";

            toCompare = Regex.Replace(ActualPass, regex, string.Empty);

            // La clave tiene que ser TODO numeros
            if (toCompare != " ")
            {
                Fails += " ,  no son todo numeros";
            }

        }
        if (ActualObjective.allminus == true)
        {
            
            string toCompare = "";
           

            toCompare = ActualPass.ToLower();

            // La clave tiene que tener TODO minusculas
            if (toCompare != ActualPass)
            {
                Fails += " ,  no son todo minusculas";
            }

        }
        if (ActualObjective.allmayus == true)
        {
            
            string toCompare = "";
          
            toCompare = ActualPass.ToUpper();
            
            // La clave tiene que tener TODO mayusculas
            if (toCompare != ActualPass)
            {
                Fails += " ,  no son todo mayusculas";
            }

        }
        if (ActualObjective.numminus != -1)
        {
            // La clave tiene que tener # numero de minusculas
            // if()
            // {

            // }
            // else
            // {

            // }
        }
        if (ActualObjective.nummayus != -1)
        {
            // La clave tiene que tener # numero de mayusculas
            // if()
            // {

            // }
            // else
            // {

            // }
        }

         Debug.Log(Fails);

        if(Fails == "" && ActualPass!="")
        {
            TaskCompleted += 1;
            TMPTextTaskCompleted.text = TaskCompleted.ToString();
            SoundSource.PlayOneShot(GameManager.Instance.AllSounds[1]);
        }
        else
        {
            TaskFail += 1;
            TMPTextTaskFail.text = TaskFail.ToString();
            SoundSource.PlayOneShot(GameManager.Instance.AllSounds[2]);
        }

        PassInput= "";
        DeleteTextPass();
        Destroy(ActualTask.gameObject);

        ScriptProgress.timerIsRunning = true;
        TasksNumber++;
        if(TasksNumber == TaskMax)
        {
            Final();
        }

    }

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


    public void Final()
    {

        if(TaskCompleted > TaskFail)
        {

            // Final todos hackeados buen trabajo a la mierda la empresa
            StartCoroutine(ScriptFinal.FinalCourutine(0));

        }
        else if(TaskCompleted < TaskFail)
        {

            // Final todo seguro muy mal despedido
            StartCoroutine(ScriptFinal.FinalCourutine(1));

        }
        else if (TaskCompleted == 0  && TaskFail == 0)
        {

            // No has hecho nada elegantemente, aumento de sueldo y promocion
            StartCoroutine(ScriptFinal.FinalCourutine(2));

        }
        else if (TaskCompleted == TaskFail)
        {

            // NI bien ni mal, bien hecho te veo mañana
            StartCoroutine(ScriptFinal.FinalCourutine(3));

        }




    }





  

}
