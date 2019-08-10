using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings {

	private User[] users; 
	private Recipe[] recipes;
	private Ingredient[] ingredient;
	private string invitation;
	private Profession[] prof;

	public GameSettings (User[] users, Recipe[] recipes, Ingredient[] ingredient, string invitation, Profession[] prof){
		this.users = users;
		this.recipes = recipes;
		this.ingredient = ingredient;
		this.invitation = invitation;
		this.prof = prof;
	}
}
