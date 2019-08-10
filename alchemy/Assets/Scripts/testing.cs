using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Ingredient ingr1 = new Ingredient ("unicorn", null, "1 horn", 0);
		Ingredient ingr2 = new Ingredient ("shit", null, "1kg", 10);
		Ingredient ingr3 = new Ingredient ("mandrake", null, "100g", 0);
		Ingredient ingr4 = new Ingredient ("stardast", null, "400g", 2);
		Ingredient ingr5 = new Ingredient ("darkwater", null, "300ml", 8);

		Item item1 = new Item ("healthPotion", 999);
		Item item2 = new Item ("shitty", 0);
		Item item3 = new Item ("lovePotion", 111);

		Dictionary<string, int> dict1 = new Dictionary<string, int>();
		dict1.Add (ingr1.Name, 1);
		dict1.Add (ingr3.Name, 2);

		Dictionary<string, int> dict2 = new Dictionary<string, int>();
		dict2.Add (ingr2.Name, 2);
		dict2.Add (ingr5.Name, 1);

		Dictionary<string, int> dict3 = new Dictionary<string, int>();
		dict3.Add (ingr4.Name, 5);
			
		Recipe recipe1 = new Recipe (dict1, item1);
		Recipe recipe2 = new Recipe (dict2, item2);
		Recipe recipe3 = new Recipe (dict3, item3);

		Profession prof1 = new Profession ("north", new Recipe[]{ recipe1, recipe2 });
		Profession prof2 = new Profession ("south", new Recipe[]{ recipe3 });

		//User user1 = new User("1", "1234", prof1, 101, null, new Item[];
		//GameSettings gameSettings = new GameSettings( users, new Recipe[], new Ingredient[], new string, new Profession[]);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
