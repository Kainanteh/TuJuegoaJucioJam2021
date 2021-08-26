using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class TextLink : MonoBehaviour, IPointerClickHandler
{
 
    public string TextLinkText;

    private TextMeshProUGUI TMPTextLink;

    private void Start() 
    {
        TMPTextLink = GetComponent<TextMeshProUGUI>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {

        RaycastHit2D hitInfo = Physics2D.Raycast(GameManager.Instance.GetMouseAsWorldPoint(),
         Vector2.zero, Mathf.Infinity, 1 << LayerMask.NameToLayer("TextLink"));

        if (hitInfo)
        {
           
            GameManager.Instance.SetTextPass(TextLinkText);

        }

    }

    public void SetTextLink(string text)
    {

        TextLinkText = text;
        // TMPTextLink.text = text;
        StartCoroutine(GameManager.Instance.TypeText(TMPTextLink, text, 0.05f));

    }


}
