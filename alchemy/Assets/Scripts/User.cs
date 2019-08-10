using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User {

	private string name;
	private string password;
	private Profession prof;
	private int debuffs; // 101
	private Recipe[] recipes; //  что знает помимо профессии
	private Item[] items; // GPS, шкафчики открываются, зелья выливаются.

	public User (string name, string password, Profession prof, int debuffs, Recipe[] recipes, Item[] items){
		this.name = name;
		this.password = password;
		this.prof = prof;
		this.debuffs = debuffs;
		this.recipes = recipes;
		this.items = items;
	}
}
