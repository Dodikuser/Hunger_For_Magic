using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    [SerializeField] protected GameObject Canvas;
    [SerializeField] protected Player Player;
        
    public void Touch()
    {
        DealDamageToEnemy();
        HideOpendUI();
    }
    public void DealDamageToEnemy()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Enemy")
            {
                Enemy enemy = hit.collider.transform.GetComponent<Enemy>();
                Player.SelectedEnemy = enemy;
                Player.DealDamage(Player.SelectedPart);
            }
        }
    }
    public void HideOpendUI()
    {
        foreach(Transform t in Canvas.transform)
        {
            if (t.gameObject.activeSelf) t.GetComponent<PartButton>().OnCloseView();
        }
    }
}
