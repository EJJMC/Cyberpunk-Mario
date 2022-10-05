using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public Slider playerHealthSlider;

    public void PlayerMaxHealth(int health)
    {
        playerHealthSlider.maxValue = health;
        playerHealthSlider.value = health;
    }

    public void SetPlayerHealth(int health)
    {
        playerHealthSlider.value = health;
    }
}
