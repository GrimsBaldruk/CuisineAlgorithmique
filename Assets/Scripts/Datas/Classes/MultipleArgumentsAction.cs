using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new MultipleArgsAction", menuName = "Scriptable Objects/RecipeKeywords/MultipleArgsAction")]
public class MultipleArgumentsAction : RecipeKeyword
{
    [SerializeField] private Dictionary<string, string> _argsList = new Dictionary<string, string>();
}
