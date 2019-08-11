using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngrMoving : MonoBehaviour
{
    public Ingredient curIngr;

    private Vector3 startPos;
    private Vector3 screenPoint;
    private Vector3 offset;

    private Vector3 targetPos = new Vector3(1100, 550, 0);

    // Start is called before the first frame update
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 ingrPos = this.transform.position;

        if (mousePos.x > (ingrPos.x - 40) && mousePos.x < (ingrPos.x + 40) && mousePos.y > (ingrPos.y - 40) && mousePos.y < (ingrPos.y + 40))
        {
            if (Input.GetKey(KeyCode.Mouse0)){
                this.transform.position = new Vector3(mousePos.x, mousePos.y, 0.0f);
            }
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                if (ingrPos.x > (targetPos.x - 150) && ingrPos.x < (targetPos.x + 150) && ingrPos.y > (targetPos.y - 100) && ingrPos.y < (targetPos.y + 200)) //TO DO: относительно метки
                {
                    //send ingr info to function
                    // EFFECT YAAAY Instantiate
                    Debug.Log("Sended");
                }
                Debug.Log(ingrPos + "     " + targetPos);
                Destroy(this.gameObject);
            }
        }
    }


    /*private void OnMouseDown()
    {
        Debug.Log("tik");
        startPos = transform.position;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    private void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPos = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = curPos;
    }

    private void OnMouseUp()
    {
        Destroy(this.gameObject);
    }*/
}
