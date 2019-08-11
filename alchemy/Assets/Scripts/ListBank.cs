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

    /*private int[] texts = {
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10
    };*/

	private List<Ingredient> ingredients;

    void Start() {
        	var sprites = Resources.LoadAll<Sprite>("Ingredients");
        	ingredients =  new List<Ingredient>();
               for(int i = 0; i < sprites.Length; i++)
               {
                      Ingredient ingredient = new Ingredient();
                      ingredient.Name = i.ToString();
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
