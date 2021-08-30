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
        StartCoroutine(TutorialCourutine());
    }


    IEnumerator TutorialCourutine()
    {
        TextMeshProUGUI PadlockText = GameManager.Instance.TMPTextPadlock;

        yield return new WaitForSeconds(delay-3f);


        TextTutorial = "Buenos dias empleado, ShortPassInc le da la bienvenida";

        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay);


        TextTutorial = "Su cometido sera darle claves a nuestro usuarios";

        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay);


        //TP a ZonaListTasks 
        AnimPadlock.SetTrigger("TP");
        yield return new WaitForSeconds(0.3f);
        PadlockTransform.parent = PadlockPositionsTutorial[1];
        PadlockTransform.position = PadlockPositionsTutorial[1].position;

        TextTutorial = "Aqui elegira la tarea, si no sabe como resolverla pase a otra";

        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay);


        //TP a ZonaInfoTask
        AnimPadlock.SetTrigger("TP");
        yield return new WaitForSeconds(0.3f);
        PadlockTransform.parent = PadlockPositionsTutorial[2];
        PadlockTransform.position = PadlockPositionsTutorial[2].position;

        TextTutorial = "Aqui esta el objetivo a lograr";

        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay);


        //TP a ZonaUserInfo
        AnimPadlock.SetTrigger("TP");
        yield return new WaitForSeconds(0.3f);
        PadlockTransform.parent = PadlockPositionsTutorial[3];
        PadlockTransform.position = PadlockPositionsTutorial[3].position;

        TextTutorial = "Aqui podra escoger las palabras con las que forma la clave";

        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay);


        //TP a ZonaPadlock
        AnimPadlock.SetTrigger("TP");
        yield return new WaitForSeconds(0.3f);
        PadlockTransform.parent = PadlockPositionsTutorial[0];
        PadlockTransform.position = PadlockPositionsTutorial[0].position;


        TextTutorial = "Para seleccionar una accion, primero selecionela con lo botones con flechas";

        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay + 0.5f);

        TextTutorial = "Luego presione el boton naranja para aplicar la accion";

        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay);

        TextTutorial = "Use el boton rojo para borrar y el verde para enviar la clave";

        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay + 0.5f);
        

        TextTutorial = "Haga las que pueda en 4 minutos, su jornada express comienza ahora";

        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay+0.5f);


        TextTutorial = "No nos decepcione, y recuerde una clave demasiado larga es una clave triste";

        StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextTutorial, 0.05f));

        yield return new WaitForSeconds(delay+ 1f);

        PadlockText.text = "";
        GameManager.Instance.ScriptProgress.timerIsRunning = true;
        GameManager.Instance.InTutorial = false;
        

    }


  
}
