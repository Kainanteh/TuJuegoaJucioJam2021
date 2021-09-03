using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagsIdiom : MonoBehaviour
{

    public Localisation ScriptLocal;
    public Init ScriptInit;

    public enum IdiomFlag
    {
        spanish,
        english
    }
    private void Awake()
    {


        ScriptLocal = GameObject.Find("Localisation").GetComponent<Localisation>();

    }
    public IdiomFlag FlagIdiom;

    private void OnMouseUp() {

  
        if(FlagIdiom == IdiomFlag.english)
        {
            ScriptLocal.ChangeIdiom(0);
            ScriptInit.SetTextInit();
        }
        else if(FlagIdiom == IdiomFlag.spanish)
        {
            ScriptLocal.ChangeIdiom(1);
            ScriptInit.SetTextInit();
        }

    }


}
