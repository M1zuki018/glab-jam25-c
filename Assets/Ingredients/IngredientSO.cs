using UnityEngine;

[CreateAssetMenu(fileName = "NewIngredient", menuName = "Recipe/Ingredient")]
public class IngredientSO : ScriptableObject
{
    public string ingredientName;
    public Sprite icon;
    public int price;
    public string ID;
}
