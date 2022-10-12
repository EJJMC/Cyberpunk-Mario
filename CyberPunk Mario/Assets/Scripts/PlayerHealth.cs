using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    //player health bar
    /*public int playerMaxHealth = 3;
    public int playerCurrentHealth;
    public PlayerHealthBar healthBar;
    */
    //player hearts
    public int playerHealth;
    public int playerNumberOfHearts;
    public Image[] playerHearts;
    public Sprite playerFullHeart;
    public Sprite playerEmptyHeart;

    public void Start()//all code related to player health bar
    {
       // playerCurrentHealth = playerMaxHealth;
        //healthBar.PlayerMaxHealth(playerMaxHealth);
    }
    private void Update()//all code in update related to player hearts
    {
        if(playerHealth > playerNumberOfHearts)
        {
            playerHealth = playerNumberOfHearts;
        }


        for (int i = 0; i < playerHearts.Length; i++)
        {
            if(i < playerHealth)
            {
                playerHearts[i].sprite = playerFullHeart;
            }
            else
            {
                playerHearts[i].sprite = playerEmptyHeart;
            }
            if(i < playerNumberOfHearts)
            {
                playerHearts[i].enabled = true;
            }
            else
            {
                playerHearts[i].enabled = false;
            }
        } 

        if(playerHealth <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }
    
    public void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.tag == "Enemy")
        {
           // playerCurrentHealth--;//player healthbar
            playerHealth--;//player hearts
           // healthBar.SetPlayerHealth(playerCurrentHealth);
        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "DeathZone")
        {
            
            //playerCurrentHealth-=3;//player healthbar
            playerHealth-=7;//player hearts
            //healthBar.SetPlayerHealth(playerCurrentHealth);
            
        }

        if (collision.gameObject.tag == "SawBlade")
        {

           
            playerHealth -= 2;
                              

        }
    }

}

