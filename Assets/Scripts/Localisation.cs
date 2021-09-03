using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Idiom
{
    spanish,
    english
}

public class Localisation : MonoBehaviour
{
  
   

    private void Start() {

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Localisation");
      
        // Si existe mas de un GameManager destruir hasta que solo quede uno
        if (objs.Length > 1)
        {
  
            Destroy(this.gameObject);

        }
        DontDestroyOnLoad(this);
    }

    public Idiom ActualIdiom = Idiom.english;

    public void ChangeIdiom(int index)
    {
        switch (index)
        {

            case 0:
            {
                
                ActualIdiom = Idiom.english;
                break;
            }
            case 1:
            {

                ActualIdiom = Idiom.spanish;
                break;
            }


        }

    }

    public string GetTextLocal(int index)
    {

     

        switch(index)
        {

            case 0:
            {
                if(ActualIdiom == Idiom.english){return "Start";}
                else if (ActualIdiom == Idiom.spanish) { return "Inicio"; }
                break;
            }
            case 1:
            {
                if (ActualIdiom == Idiom.english) { return "Name:"; }
                else if (ActualIdiom == Idiom.spanish) { return "Nombre:"; }
                break;
            }
            case 2:
            {
                if (ActualIdiom == Idiom.english) { return "Last Name:"; }
                else if (ActualIdiom == Idiom.spanish) { return "Apellidos:"; }
                break;
            }
            case 3:
            {
                if (ActualIdiom == Idiom.english) { return "Birth:"; }
                else if (ActualIdiom == Idiom.spanish) { return "Nacimiento:"; }
                break;
            }
            case 4:
            {
                if (ActualIdiom == Idiom.english) { return "Age:"; }
                else if (ActualIdiom == Idiom.spanish) { return "Edad:"; }
                break;
            }
            case 5:
            {
                if (ActualIdiom == Idiom.english) { return "City:"; }
                else if (ActualIdiom == Idiom.spanish) { return "Ciudad:"; }
                break;
            }


        }

        return "Not found";

    }



}
