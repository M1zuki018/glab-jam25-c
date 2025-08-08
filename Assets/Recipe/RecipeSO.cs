using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class RecipeSO : ScriptableObject
{
    public string recipeName;
    public Sprite resultIcon;
    public List<IngredientSO> requiredIngredients;
}
