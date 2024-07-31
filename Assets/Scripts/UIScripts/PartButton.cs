using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;
using System.Xml.Linq;

public class PartButton : MonoBehaviour
{
    [SerializeField] protected GameObject Canvas;
    [SerializeField] protected Player Player;
    [SerializeField] protected string NamePart;
    public GameObject Element;

    public bool OpenElements;

    public void InteractPartButton()
    {
        Player.SelectPartName(NamePart);
        if (Player.Inventory.AvailableElements.Count == 0) return;

        if (!OpenElements) OnOpenView();
        else OnCloseView();
    }
    public void OnOpenView()
    {
        HidePartButtons();
        ShowAvailableElements();
    }
    public void OnCloseView()
    {
        ShowPartButtons();
        DestroyElementButtons();
    }

    public void HidePartButtons()
    {
        foreach (Transform child in Canvas.transform)
        {
            if (child != transform) child.gameObject.SetActive(false);
        }
    }
    public void ShowPartButtons()
    {
        foreach (Transform child in Canvas.transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    public void DestroyElementButtons()
    {
        foreach (Transform child in transform)
        {
            if (child.tag == "ElementButton") Destroy(child.gameObject);
        }
        OpenElements = false;
    }

    public void ShowAvailableElements()
    {
        OpenElements = true;

        int countElements = Player.Inventory.AvailableElements.Count;
        float radius = 200f;

        if (countElements == 1)
        {
            Vector2 position = (Vector2)transform.position + (new Vector2(0, radius));
            GameObject element = Instantiate(Element, position, Quaternion.identity, transform);
            InitElementButton(element, 0);
            return;
        }
        double range = Math.PI / 1.5;
        double radSpañe = range / (countElements - 1);
        float offset = (float)(Math.PI - range) / 2;

        for (int i = 0; i < countElements; i++)
        {
            Vector2 position = (Vector2)transform.position
                + (new Vector2((float)Math.Cos(radSpañe * i + offset), (float)Math.Sin(radSpañe * i + offset))) * radius;

            GameObject element = Instantiate(Element, position, Quaternion.identity, transform);
            InitElementButton(element, i);
        }
    }

    private void InitElementButton(GameObject element, int num)
    {
        ElementButton script = element.GetComponent<ElementButton>();
        var elInDic = Player.Inventory.AvailableElements.ElementAt(num);
        script.Init(elInDic.Key, Player, this, Canvas);
        script.SetView(elInDic.Key.Icon, elInDic.Value.ToString());
    }
}
