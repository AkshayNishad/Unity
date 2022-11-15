using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;

    public static int number;

    public int curHealth, maxHealth;

    public float invincibleLength;
    private float invincibleCounter;

    private SpriteRenderer tSR;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;

        tSR = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(invincibleCounter > 0)
        {
            invincibleCounter -= Time.deltaTime;

            if(invincibleCounter <= 0)
            {
                tSR.color = new Color(tSR.color.r, tSR.color.g, tSR.color.b, 1f);
            }
        }
    }

    public void DealDamage()
    {
        if(invincibleCounter <= 0)
        {
            //curHealth -= 1;
            curHealth--;

            if (curHealth <= 0)
            {
                curHealth = 0;

                //gameObject.SetActive(false);

               // Instantiate(deathEffect, transform.position, transform.rotation);

                LevelManager.instance.RespawnPlayer();
            }

            else
            {
                invincibleCounter = invincibleLength;
                tSR.color = new Color(tSR.color.r, tSR.color.g, tSR.color.b, 0.5f);

                PlayerController.instance.KnockBack();
            }

            UIController.instance.UpdateHealthDisplay();
        }
    }

    public void HealPlayer()
    {
        //curHealth = maxHealth;

        curHealth++;
        if(curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }

        UIController.instance.UpdateHealthDisplay();
    }
}