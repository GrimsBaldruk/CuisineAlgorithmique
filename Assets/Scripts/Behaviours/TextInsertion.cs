using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextInsertion : MonoBehaviour
{
    [SerializeField] private TMP_Text _tmpText;
    private TMP_InputField _input;
    public string textToInsert;

    private void Start()
    {
        _input = transform.GetComponentInChildren<TMP_InputField>();
    }
    
    public void InstantiateText()
    {
        if (string.IsNullOrEmpty(_input.text)) return;
        
        Debug.Log("Add text Text");
        
        var prevText = _tmpText.text;
        var newText = _input.text;

        if (string.IsNullOrEmpty(prevText))
        {
            _tmpText.text = newText;
            return;
        }
        
        var finalText = $"{prevText}<br>{textToInsert}{" "}{newText}";
        _tmpText.text = finalText;
    }

    public void ClearInput()
    {
        _input.text = "";
    }
}
