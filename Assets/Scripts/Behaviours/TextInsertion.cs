using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextInsertion : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private GameObject _parent;
    
    private TMP_InputField _input;
    private TextAccessor _accessor;

    private void Start()
    {
        _input = transform.GetComponentInChildren<TMP_InputField>();
    }
    
    public void InstantiateText()
    {
        Debug.Log("Instantiate Text");
        var instance = Instantiate(_prefab, _parent.transform);
        _accessor = instance.GetComponent<TextAccessor>();
        _accessor.SetText(_input.text);
    }

    public void ClearInput()
    {
        _input.text = "";
    }
}
