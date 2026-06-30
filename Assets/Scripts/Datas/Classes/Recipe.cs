using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Recipe", menuName = "Scriptable Objects/Recipe")]
public class Recipe : ScriptableObject
{
    [SerializeField] private string _title;

    [SerializeField] private string _description;

    [SerializeField] private List<RecipeStep> _steps;
}
