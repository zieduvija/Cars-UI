using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour {
    public Objekti objekti;

    void Update()
    {
        if (objekti.pedejaisVilktais != null)
        {
            if(Input.GetKey(KeyCode.Z))
                objekti.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, Time.deltaTime * 20f);
            if(Input.GetKey(KeyCode.X))
                objekti.pedejaisVilktais.GetComponent<RectTransform>().transform.Rotate(0, 0, -Time.deltaTime * 20f);


            if (Input.GetKey(KeyCode.LeftArrow))
                if(objekti.pedejaisVilktais.GetComponent<RectTransform>().localScale.x >= 0.5)
                    objekti.pedejaisVilktais.GetComponent<RectTransform>().localScale = new Vector2(objekti.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x - 0.005f, objekti.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y);
                
            if (Input.GetKey(KeyCode.RightArrow))
                if(objekti.pedejaisVilktais.GetComponent<RectTransform>().localScale.x <= 1)
                    objekti.pedejaisVilktais.GetComponent<RectTransform>().localScale = new Vector2(objekti.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x + 0.005f, objekti.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y);   
            
            if (Input.GetKey(KeyCode.UpArrow))
                if(objekti.pedejaisVilktais.GetComponent<RectTransform>().localScale.x <= 1)
                    objekti.pedejaisVilktais.GetComponent<RectTransform>().localScale = new Vector2(objekti.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x, objekti.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y + 0.004f);   

            if (Input.GetKey(KeyCode.DownArrow))
                if(objekti.pedejaisVilktais.GetComponent<RectTransform>().localScale.x <= 1)
                    objekti.pedejaisVilktais.GetComponent<RectTransform>().localScale = new Vector2(objekti.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.x, objekti.pedejaisVilktais.GetComponent<RectTransform>().transform.localScale.y - 0.004f);   

        }
    }
}
