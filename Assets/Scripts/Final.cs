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


            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Su jornada laboral express ha terminado, veamos...";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "Your express workday is over, let's see ...";
            }
         

            

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);


            if(GameManager.Instance.ScriptProgress.timeRemaining > 0)
            {

                if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
                {
                    TextFinal = "Y lo ha hecho en un tiempo record, impresionante";
                }
                else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
                {
                    TextFinal = "And he has done it in record time, impressive";
                }
                

                StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

                yield return new WaitForSeconds(delay);

            }


            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Han hackeado todas las claves de nuestros usuarios, vaya...";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "They have hacked all the keys of our users, well ...";
            }


            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Bueno, usted no se preocupe, ha hecho un buen trabajo...";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "Well, don't worry, you've done a good job ...";
            }

           

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "... verda?";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "... right?";
            }

            

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

        }
        else if (index == 1) // TaskCompleted < TaskFail
        {

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Su jornada laboral express ha terminado, veamos...";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "Your express workday is over, let's see ...";
            }

            

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Bueno, lo ha hecho usted bastante mal";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "Well you did it pretty bad";
            }



            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "La mayoria de nuestro usuarios no se acuerdan de sus claves";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "Most of our users do not remember their passwords";
            }




            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Sera despedido y contratado nuevamente para volver a despedirle";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "You will be fired and hired again to fire you again";
            }



            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Esperamos no volver a verle nunca, que pase un buen dia...";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "We hope never to see you again, have a good day ...";
            }



            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

        }
        else if (index == 2) // TaskCompleted == 0  && TaskFail == 0
        {

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Su jornada laboral express ha terminado, veamos...";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "Your express workday is over, let's see ...";
            }



            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "No ha hecho absolutamente nada en su jornada...";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "You done absolutely nothing in his day ...";
            }



            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Es lo que llamamos un trabajo elegantemente ineficente";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "It's what we call elegantly ineffective work";
            }



            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Sera usted promocionado a ayudante del director regional";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "You will be promoted to Assistant Regional Director";
            }



            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Mi enhorabuena a usted y a todos sus descendientes";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "My congratulations to you and all your descendants";
            }



            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

        }
        else if (index == 3) // TaskCompleted == TaskFail
        {

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Su jornada laboral express ha terminado, veamos...";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "Your express workday is over, let's see ...";
            }



            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Ni bien ni mal, un equilibrio perfecto...";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "Neither good nor bad, a perfect balance ...";
            }



            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Es usted el trabajador ideal para su puesto, le vere en su proxima jornada";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "You are the ideal worker for your position, I will see you on your next day";
            }

 

            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);

            if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.spanish)
            {
                TextFinal = "Mi enhorabuena";
            }
            else if (GameManager.Instance.ScriptLocal.ActualIdiom == Idiom.english)
            {
                TextFinal = "My congratulations";
            }



            StartCoroutine(GameManager.Instance.TypeText(PadlockText, TextFinal, 0.05f));

            yield return new WaitForSeconds(delay);



        }

        GameManager.Instance.Square.clip = GameManager.Instance.ToBlack;
        GameManager.Instance.Square.Play();

    }

}
