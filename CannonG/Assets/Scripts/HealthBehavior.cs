using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBehavior : MonoBehaviour
{
    private Image HealthBar;
    public float Health;
    public float MaxHealth = 60f;
    
    
    void Start()
    {
        HealthBar = GetComponent<Image>();
        //Still need the script for damaging the player. 
    }
    //Referenced code from https://www.youtube.com/watch?v=NE5cAlCRgzo
    void Update()
    {
        Health = Player.Health;
        HealthBar.fillAmount = Health / MaxHealth;
    }
}
