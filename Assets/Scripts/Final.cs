using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Final : MonoBehaviour
{

    string TextFinal = "";
    float delay = 6f;

 
    public IEnumerator FinalCourutine(int index)
    {

        if(GameManager.Instance.InTutorial==true)
        {
            StopCoroutine(GameManager.Instance.CouroutineTutorial);
            GameManager.Instance.InTutorial = false;

            GameManager.Instance.ScriptTutorial.AnimPadlock.SetTrigger("TP");
            GameManager.Instance.ScriptTutorial.PadlockTransform.parent = GameManager.Instance.ScriptTutorial.PadlockPositionsTutorial[0];
            GameManager.Instance.ScriptTutorial.PadlockTransform.position = GameManager.Instance.ScriptTutorial.PadlockPositionsTutorial[0].position;
        }

        GameManager.Instance.InFinal = true;
        GameManager.Instance.ScriptProgress.timerIsRunning = false;

        TextMeshProUGUI PadlockText = GameManager.Instance.TMPTextPadlock;

        yield return new WaitForSeconds(delay - 3f);

        if(index == 0) // TaskCompleted > TaskFail
        {

            TextFinal = "Su jornada laboral express ha terminado, veamos...";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);


            if(GameManager.Instance.ScriptProgress.timeRemaining > 0)
            {

                TextFinal = "Y lo ha hecho en un tiempo record, impresionante";

                StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

                yield return new WaitForSeconds(delay);

            }

            TextFinal = "Han hackeado todas las claves de nuestros usuarios, vaya...";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            TextFinal = "Bueno, usted no se preocupe, ha hecho un buen trabajo...";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay); 
            
            TextFinal = "verda?";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

        }
        else if (index == 1) // TaskCompleted < TaskFail
        {

            TextFinal = "Su jornada laboral express ha terminado, veamos...";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            TextFinal = "Bueno, lo ha hecho usted bastante mal";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            TextFinal = "La mayoria de nuestro usuarios no se acuerdan de sus claves";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            TextFinal = "Sera despedido y contratado nuevamente para volver a despedirle";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            TextFinal = "Esperamos no volver a verle nunca, que pase un buen dia...";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

        }
        else if (index == 2) // TaskCompleted == 0  && TaskFail == 0
        {

            TextFinal = "Su jornada laboral express ha terminado, veamos...";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            TextFinal = "No ha hecho absolutamente nada en su jornada...";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            TextFinal = "Es lo que llamamos un trabajo elegantemente ineficente";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            TextFinal = "Sera usted promocionado a ayudante del director regional";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            TextFinal = "Mi enhorabuena a usted y a todos sus descendientes";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

        }
        else if (index == 3) // TaskCompleted == TaskFail
        {

            TextFinal = "Su jornada laboral express ha terminado, veamos...";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            TextFinal = "Ni bien ni mal, un equilibrio perfecto...";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            TextFinal = "Es usted el trabajador ideal para su puesto, le vere mañana";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            TextFinal = "Mi enhorabuena";

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

        }
        

    }

}
