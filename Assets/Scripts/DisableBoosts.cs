using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableBoosts : MonoBehaviour
{
    public Button eggButton, shieldButton, swordButton, bowButton, potionButton, miniknightButton;
    public float eggPrice = 25, shieldPrice = 250, swordPrice = 500, bowPrice = 2500, potionPrice = 20000, miniknightPrice = 100000;
    // Start is called before the first frame update
    void Start()
    {
        eggButton.interactable = false;
        shieldButton.interactable = false;
        swordButton.interactable = false;
        bowButton.interactable = false;
        potionButton.interactable = false;
        miniknightButton.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        DoYouHaveEnoughHits();
    }

    void DoYouHaveEnoughHits()
    {
        //if not enough hits
        if(GameManager.hits < eggPrice)
        {
            eggButton.interactable = false;
        }
        if (GameManager.hits < shieldPrice)
        {
            shieldButton.interactable = false;
        }
        if (GameManager.hits < swordPrice)
        {
            swordButton.interactable = false;
        }
        if (GameManager.hits < bowPrice)
        {
            bowButton.interactable = false;
        }
        if (GameManager.hits < potionPrice)
        {
            potionButton.interactable = false;
        }
        if (GameManager.hits < miniknightPrice)
        {
            miniknightButton.interactable = false;
        }
    

        //if enough hits
        if (GameManager.hits >= eggPrice)
        {
            eggButton.interactable = true;
        }
        if (GameManager.hits >= shieldPrice)
        {
            shieldButton.interactable = true;
        }
        if (GameManager.hits >= swordPrice)
        {
            swordButton.interactable = true;
        }
        if (GameManager.hits >= bowPrice)
        {
            bowButton.interactable = true;
        }
        if (GameManager.hits >= potionPrice)
        {
            potionButton.interactable = true;
        }
        if (GameManager.hits >= miniknightPrice)
        {
            miniknightButton.interactable = true;
        }
    }
}
