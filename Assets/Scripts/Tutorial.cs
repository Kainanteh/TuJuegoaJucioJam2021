using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    
    string TextTutorial = "";
    float delay = 6f;

    public Transform[] PadlockPositionsTutorial;
    public Transform PadlockTransform;

    public Animator AnimPadlock;

    void Start()
    {
        GameManager.Instance.CouroutineTutorial= StartCoroutine(TutorialCourutine());
    }


    IEnumerator TutorialCourutine()
    {
        TextMeshProUGUI PadlockText = GameManager.Instance.TMPTextPadlock;

        yield return new WaitForSeconds(delay);

        if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
        {
            TextTutorial = "Buenos dias empleado, ShortPassInc le da la bienvenida";
        }
        else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
        {
            TextTutorial = "Good morning employee, ShortPassInc welcomes you";
        }



        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay);

        if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
        {
            TextTutorial = "Su cometido sera darle claves a nuestro usuarios";
        }
        else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
        {
            TextTutorial = "Your mission will be to give keys to our users";
        }



        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay);


        //TP a ZonaListTasks 
        AnimPadlock.SetTrigger("TP");
        yield return new WaitForSeconds(0.3f);
        PadlockTransform.parent = PadlockPositionsTutorial[1];
        PadlockTransform.position = PadlockPositionsTutorial[1].position;

        if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
        {
            TextTutorial = "Aqui elegira la tarea, si no sabe como resolverla pase a otra";
        }
        else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
        {
            TextTutorial = "Here you will choose the task, if you do not know how to solve it, go to another";
        }



        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay);


        //TP a ZonaInfoTask
        AnimPadlock.SetTrigger("TP");
        yield return new WaitForSeconds(0.3f);
        PadlockTransform.parent = PadlockPositionsTutorial[2];
        PadlockTransform.position = PadlockPositionsTutorial[2].position;

        if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
        {
            TextTutorial = "Aqui esta el objetivo a lograr";
        }
        else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
        {
            TextTutorial = "Here is the goal to achieve";
        }




        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay);


        //TP a ZonaUserInfo
        AnimPadlock.SetTrigger("TP");
        yield return new WaitForSeconds(0.3f);
        PadlockTransform.parent = PadlockPositionsTutorial[3];
        PadlockTransform.position = PadlockPositionsTutorial[3].position;

        if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
        {
            TextTutorial = "Aqui podra escoger las palabras con las que formar la clave";
        }
        else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
        {
            TextTutorial = "Here you can choose the words with which to form the key";
        }




        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay);


        //TP a ZonaPadlock
        AnimPadlock.SetTrigger("TP");
        yield return new WaitForSeconds(0.3f);
        PadlockTransform.parent = PadlockPositionsTutorial[0];
        PadlockTransform.position = PadlockPositionsTutorial[0].position;

        if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
        {
            TextTutorial = "Para seleccionar una accion, primero selecionela con lo botones con flechas";
        }
        else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
        {
            TextTutorial = "To select an action, first select it with the arrow buttons";
        }



        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay + 0.5f);

        if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
        {
            TextTutorial = "Luego presione el boton naranja para aplicar la accion";
        }
        else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
        {
            TextTutorial = "Then press the orange button to apply the action";
        }



        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay);

        if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
        {
            TextTutorial = "Use el boton rojo para borrar y el verde para enviar la clave";
        }
        else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
        {
            TextTutorial = "Use the red button to delete and the green button to send the key";
        }



        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay + 0.5f);

        if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
        {
            TextTutorial = "Haga las que pueda en 4 minutos, su jornada express comienza ahora";
        }
        else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
        {
            TextTutorial = "Do what you can in 4 minutes, your express journey starts now";
        }




        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay+0.5f);

        if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
        {
            TextTutorial = "No nos decepcione, y recuerde una clave demasiado larga es una clave triste";
        }
        else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
        {
            TextTutorial = "Don't let us down, and remember a key too long is a sad key";
        }



        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay+ 1f);

        PadlockText.text = "";
        GameManager.Instance.ScriptProgress.timerIsRunning = true;
        GameManager.Instance.InTutorial = false;
        

    }


  
}
