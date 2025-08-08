using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RecipeManager : MonoBehaviour
{
    [SerializeField] private List<RecipeSO> allRecipes;

    public RecipeSO FindMatchingRecipe(List<IngredientSO> inputIngredients)
    {
        foreach (var recipe in allRecipes)
        {
            if (recipe.recipeName == "雑炊") continue; // On skip le fallback

            if (MatchIngredients(recipe.requiredIngredients, inputIngredients))
            {
                return recipe;
            }
        }

        // Nothing matching -> 雑炊
        return allRecipes.FirstOrDefault(r => r.recipeName == "雑炊");
    }

    private bool MatchIngredients(List<IngredientSO> recipeIngredients, List<IngredientSO> inputIngredients)
    {
        if (recipeIngredients.Count != inputIngredients.Count)
            return false;

        // CCheck if hierarchy list and this one have same ingredients (for prevents errors)
        return !recipeIngredients.Except(inputIngredients).Any();
    }
}
