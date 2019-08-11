using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ingredient {

	private string name;
	private Sprite image = null;
	private string amount; //200 грамм, 2 лапы и т.д.
	private int severity; // 0 = ничего плохого, 10 = очень плохо

	public Ingredient(string name, Sprite image, string amount, int severity){
		this.name = name;
		this.image = image;
		this.amount = amount;
		this.severity = severity;
	}

	public Ingredient() {

	}

    public string Name
    {

        get { return name; }

        set { name = value; }

    }

    public Sprite getImage() {
    	    return image;
    	}

    	public void setImage(Sprite image) {
    	    this.image = image;
    	}

	/*
	void Start(){    
		StartCoroutine(DownloadImage("https://pngicon.ru/file/uploads/kartinka-lotos.png"));
	}

	IEnumerator DownloadImage(string url)
	{   
	*/
		/*
		UnityWebRequest request = UnityWebRequestTexture.GetTexture(MediaUrl);
		yield return request.SendWebRequest();
		if(request.isNetworkError || request.isHttpError) 
			Debug.Log(request.error);
		else
			image = ((DownloadHandlerTexture) request.downloadHandler).texture*/

		/*
		WWW www = new WWW(url);
		yield return www;

		// calling this function with StartCoroutine solves the problem
		Debug.Log("Why on earh is this never called?");

		www.LoadImageIntoTexture(image);
		www.Dispose();
		www = null;	

		Rect rec = new Rect(0, 0, image.width, image.height);
		Sprite.Create(image,rec,new Vector2(0,0),1);
		GetComponent<Image>().sprite = Sprite.Create(image,rec,new Vector2(0,0),.01f);
		
	} */
}
