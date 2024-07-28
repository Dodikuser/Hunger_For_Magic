using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;

public class PatrtButtton : MonoBehaviour
{
    [SerializeField] protected Player Player;
    public GameObject Element;


    public void ShowAvailableElements()
    {
        int countElements = Player.Inventory.AvailableElements.Count;
        float radius = 300f;

        if (countElements == 1)
        {
            Vector2 position = (Vector2)transform.position + (new Vector2(0, radius));
            Instantiate(Element, position, Quaternion.identity, transform);
            return;
        }
        double range = Math.PI / 1.5;
        double radSpañe = range / (countElements - 1);
        float offset = (float)(Math.PI - range) / 2;

        for (int i = 0; i < countElements; i++)
        {
            Vector2 position = (Vector2)transform.position 
                + (new Vector2 ((float)Math.Cos(radSpañe * i + offset), (float)Math.Sin(radSpañe * i + offset))) * radius;            

            GameObject element =  Instantiate(Element, position, Quaternion.identity, transform);
            Image imagge = element.GetComponent<Image>();
            var elInDic = Player.Inventory.AvailableElements.ElementAt(i);
            imagge.sprite = elInDic.Key.Icon;

            element.transform.GetChild(0).GetComponent<TMP_Text>().text = elInDic.Value.ToString();
        }
    }
}
