using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class User : MonoBehaviour {

    [SerializeField]
    private string name;
    [SerializeField]
    private string password;
	private Profession prof;
	private int debuffs; // 101
	private Recipe[] recipes; //  что знает помимо профессии
	private List<Item> items = new List<Item>(); // GPS, шкафчики открываются, зелья выливаются.

	public User (string name, string password, Profession prof, int debuffs, Recipe[] recipes, List<Item> items){
		this.name = name;
		this.password = password;
		this.prof = prof;
		this.debuffs = debuffs;
		this.recipes = recipes;
		this.items = items;
	}

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    public void addItem(Item item)
    {
        items.Add(item);
    }

    public void addInfo()
    {
        if (GameObject.Find("Name").GetComponent<InputField>().text != "" && GameObject.Find("Password").GetComponent<InputField>().text != "")
        {
            name = GameObject.Find("Name").GetComponent<InputField>().text;
            password = GameObject.Find("Password").GetComponent<InputField>().text;
            items = new List<Item>();

            DontDestroyOnLoad(gameObject);

            SceneManager.LoadScene("SampleScene");
        }
    }
}
