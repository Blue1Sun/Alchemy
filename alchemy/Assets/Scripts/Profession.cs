using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profession {

	private string name; 
	private Recipe[] recipes;

	public Profession( string name, Recipe[] recipes){
		this.name = name;
		this.recipes = recipes;
	}
}
