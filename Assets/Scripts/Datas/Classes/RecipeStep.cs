using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RecipeStep", menuName = "Scriptable Objects/RecipeStep")]
[Serializable]
public class RecipeStep : ScriptableObject
{
    [SerializeField] private int _stepNumber;
    [SerializeField] private string _description;
    [SerializeField] private List<StepDictionnary> _insideSteps;
    
    [System.Serializable]
    public class StepDictionnary
    {
        public RecipeKeyword key;
        public string text;
    }
}
