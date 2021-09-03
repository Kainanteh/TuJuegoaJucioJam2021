using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour
{

    public Localisation ScriptLocal;

    TextMeshProUGUI Myrenderer;
    public SpriteRenderer AlphaSquare;

    public Animation AlphaAnimaton;

    public AnimationClip ToAlpha;
    public AnimationClip ToBlack;

    private void Awake()
    {

      
        ScriptLocal = GameObject.Find("Localisation").GetComponent<Localisation>();

    }

    private void Start() 
    {
        Myrenderer = GetComponent<TextMeshProUGUI>();
        Myrenderer.color = Color.yellow;
        AlphaAnimaton.clip = ToAlpha;
        AlphaAnimaton.Play();
        SetTextInit();

    }

    private void OnMouseOver() 
    {
        Myrenderer.color = Color.red;
    }
    
    private void OnMouseExit() {
        Myrenderer.color = Color.yellow;
    }

    private void OnMouseUp() 
    {
        AlphaAnimaton.clip = ToBlack;
        if(AlphaAnimaton.isPlaying == false)
        {AlphaAnimaton.Play();}
    }

    public void ChangeScene()
    {

        SceneManager.LoadScene("SampleScene");

    }

    public void SetTextInit()
    {
        Myrenderer.text = ScriptLocal.GetTextLocal(0);        
    }



    // private void ToAlpha()
    // {
    //     // if(_progress < 255)
    //     // // {
    //     //     AlphaSquare.color = new Color(_tmpColor.r, _tmpColor.g, _tmpColor.b, _progress); 
    //     // _progress -= Time.deltaTime * multiplier;
    //     // // }
    //     // Debug.Log(_progress);

    // }

   

  

}
