using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Init : MonoBehaviour
{

    TextMeshProUGUI Myrenderer;
    public SpriteRenderer AlphaSquare;

    public Animation AlphaAnimaton;

    public AnimationClip ToAlpha;
    public AnimationClip ToBlack;

    private void Start() 
    {
        Myrenderer = GetComponent<TextMeshProUGUI>();
        Myrenderer.color = Color.yellow;
        AlphaAnimaton.clip = ToAlpha;
        AlphaAnimaton.Play(); 

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
