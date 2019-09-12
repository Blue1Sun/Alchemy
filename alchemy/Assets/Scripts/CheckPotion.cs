using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class CheckPotion : MonoBehaviour
{
    public Dictionary<string, int> curRecipe = new Dictionary<string, int>();
    public GameObject messageObj;

    private Recipe[] recipes;

    private void Start()
    {
        Ingredient ingr1 = new Ingredient("meat", null, "1 horn", 0);
        Ingredient ingr2 = new Ingredient("unicorn horn", null, "1kg", 10);
        Ingredient ingr3 = new Ingredient("salt", null, "100g", 0);
        Ingredient ingr4 = new Ingredient("nymph tear", null, "400g", 2);
        Ingredient ingr5 = new Ingredient("dragon egg", null, "300ml", 8);

        Item item1 = new Item("healthPotion", 999);
        Item item2 = new Item("godPotion", 0);
        Item item3 = new Item("lovePotion", 111);


        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        dict1.Add(ingr1.Name, 1);
        dict1.Add(ingr3.Name, 2);

        Dictionary<string, int> dict2 = new Dictionary<string, int>();
        dict2.Add(ingr2.Name, 2);
        dict2.Add(ingr5.Name, 1);

        Dictionary<string, int> dict3 = new Dictionary<string, int>();
        dict3.Add(ingr4.Name, 5);

        Recipe recipe1 = new Recipe(dict1, item1);
        Recipe recipe2 = new Recipe(dict2, item2);
        Recipe recipe3 = new Recipe(dict3, item3);
        recipes = new Recipe[] { recipe1, recipe2, recipe3 };
    }

    public void onClick()
    {
        CheckCreatedPotion();
    }

    public void CheckCreatedPotion()
    {
        Item item = new Item();
        bool equal = false;
        foreach (var recipe in recipes)
        {
            equal = false;
            if (recipe.Ingredients.Count == curRecipe.Count) // Require equal count.
            {
                equal = true;
                foreach (var pair in recipe.Ingredients)
                {
                    int value;
                    if (curRecipe.TryGetValue(pair.Key, out value))
                    {
                        // Require value be equal.
                        if (value != pair.Value)
                        {
                            equal = false;
                            break;
                        }
                    }
                    else
                    {
                        // Require key be present.
                        equal = false;
                        break;
                    }
                }
            }

            if (equal) {
                item = recipe.Result;
                break;
            }
        }

        int chance;
        if (!equal)
        {
            chance = Random.Range(1, 11);
            if (chance > 0 && chance < 5) { // return damage
                curRecipe = new Dictionary<string, int>();

                StartCoroutine(showResult("BadResult", "Вы создали что-то опасное"));
                return;
            }
            else
            {
                StartCoroutine(showResult("NeuResult", "Вы создали неведомую фигню"));
                return;
            }
        }

        // else 

        curRecipe = new Dictionary<string, int>();

        StartCoroutine(showResult("GoodResult", "Вы создали " + item.Name));

        FindObjectOfType<User>().addItem(item);

        return;

    }

    IEnumerator showResult(string puffName, string message)
    {
        GameObject puff = GameObject.Find(puffName);
        puff.GetComponent<ParticleSystem>().Play();

        GameObject curMessage = Instantiate(messageObj, messageObj.GetComponent<Transform>().position, Quaternion.identity, GameObject.Find("Canvas").GetComponent<Transform>()) as GameObject;
        curMessage.GetComponent<UnityEngine.UI.Text>().text = message;
        curMessage.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 150, 0);

        yield return new WaitForSeconds(3);

        Destroy(curMessage);

    }

}
