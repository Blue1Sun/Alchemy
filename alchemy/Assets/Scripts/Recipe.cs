using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe {

    private Dictionary<string, int> ingredients;
    private Item result;

    public Recipe(Dictionary<string, int> ingredients, Item result) {
        this.ingredients = ingredients;
        this.result = result;
    }

    public Dictionary<string, int> Ingredients { 

        get { return ingredients; }

        set { ingredients = value; }

    }

    public Item Result
    {

        get { return result; }

        set { result = value; }

    }
}
