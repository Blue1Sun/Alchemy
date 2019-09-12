/* Store the contents for ListBoxes to display.
 */
using UnityEngine;
using System.Collections.Generic;

/* The base class of the list content container
 *
 * Create the individual ListBank by inheriting this class
 */
public abstract class BaseListBank: MonoBehaviour
{
	public abstract string GetContentText(int index);
	public abstract Sprite GetContentImage(int index);
	public abstract int GetListLength();
}

/* The example of the ListBank
 */
public class ListBank : BaseListBank
{

    private string[] texts = {
        "meat", "unicorn horn", "salt", "nymph tear", "dragon egg", "wolf fang", "cristal", "spider leg", "dragon scale"
    };

	private List<Ingredient> ingredients;

    void Start() {
        	var sprites = Resources.LoadAll<Sprite>("Ingredients");
        	ingredients =  new List<Ingredient>();
               for(int i = 0; i < sprites.Length; i++)
               {
                      Ingredient ingredient = new Ingredient();
                      ingredient.Name = texts[i];
                      ingredient.setImage(sprites[i]);
                      ingredients.Add(ingredient);
               }
    }


	public override string GetContentText(int index)
	{
		return ingredients[index].Name.ToString();
	}

	public override Sprite GetContentImage(int index)
    	{
    		return ingredients[index].getImage();
    	}

	public override int GetListLength()
	{
		return ingredients.Count;
	}
}
