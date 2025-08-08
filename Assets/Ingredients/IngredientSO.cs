using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "NewIngredient", menuName = "Recipe/Ingredient")]
public class IngredientSO : ScriptableObject
{
    public string ingredientName;
    public Sprite icon;
    public int price;
    public string ID;

#if UNITY_EDITOR
    private void OnValidate()
    {
        if (string.IsNullOrEmpty(ID))
        {
            ID = System.Guid.NewGuid().ToString();
            EditorUtility.SetDirty(this);
        }
    }
#endif
}
