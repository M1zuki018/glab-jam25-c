using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CreateAssetMenu(fileName = "NewRecipe", menuName = "Recipe/Recipe")]
public class RecipeSO : ScriptableObject
{
    public string recipeName;
    public Sprite resultIcon;
    public string ID;
    public int sellingPrice;
    public bool isFallbackRecipe; //éGêÜ fail recipe
    public List<IngredientSO> requiredIngredients;

#if UNITY_EDITOR
    private void OnValidate()
    {
        if (string.IsNullOrEmpty(ID))
        {
            ID = System.Guid.NewGuid().ToString();
            EditorUtility.SetDirty(this);
        }

        //if (requiredIngredients != null)
        //{
        //    requiredIngredients.RemoveAll(item => item == null);
        //}
    }
#endif
}
