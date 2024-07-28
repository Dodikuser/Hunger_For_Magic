using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prefabs : MonoBehaviour
{

    public Sprite FireIcon;
    public Sprite WaterIcon;
    public Sprite AirIcon;
    public Sprite GroundIcon;

    public static Prefabs Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
