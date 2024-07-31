using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ElementButton : MonoBehaviour
{
    [SerializeField] protected GameObject Canvas;
    [SerializeField] protected Image Imagge;
    [SerializeField] protected TMP_Text Text;

    protected Element Element;
    protected Player Player;
    protected PartButton PartButtton;

    public void InteractElementButton()
    {
        PutElement();
        PartButtton.ShowPartButtons();
        PartButtton.DestroyElementButtons();        
    }

    public void PutElement()
    {
        Player.PLWeapon.SetElement(Element.ToString());
        Player.Inventory.SubtractElement(Element);       
    }
    
    public void Init(Element element, Player player, PartButton patrtButtton, GameObject canvas)
    {
        Element = element;
        Player = player;
        PartButtton = patrtButtton;
        Canvas = canvas;
    }
    public void SetView(Sprite sprite, string text)
    {
        Imagge.sprite = sprite;
        Text.text = text;
    }
}
