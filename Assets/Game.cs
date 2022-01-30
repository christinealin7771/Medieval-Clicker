using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;
using UnityEngine;

public class Game : MonoBehaviour
{
    public string[] letters = { "", "K", "M", "B", "t", "q", "Q" };
    public Text ui;
    public Text ui2;
    public int abb = 0;
    private Animator animator;

    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    public void Increment()
    {
        GameManager.hits += GameManager.boosts;
        PlayerPrefs.SetFloat("hits", GameManager.hits);

    }

    public void Buy(int num)
    {
        if (num == 1 && GameManager.hits >= 25)
        {
            GameManager.boosts += 1;
            GameManager.hits -= 25;
            PlayerPrefs.SetFloat("hits", GameManager.hits);
            PlayerPrefs.SetFloat("boosts", GameManager.boosts);
        }
        if (num == 2 && GameManager.hits >= 250)
        {
            GameManager.boosts += 15;
            GameManager.hits -= 250;
            PlayerPrefs.SetFloat("hits", GameManager.hits);
            PlayerPrefs.SetFloat("boosts", GameManager.boosts);
        }
        if (num == 3 && GameManager.hits >= 500)
        {
            GameManager.boosts += 50;
            GameManager.hits -= 500;
            PlayerPrefs.SetFloat("hits", GameManager.hits);
            PlayerPrefs.SetFloat("boosts", GameManager.boosts);
        }
        if (num == 4 && GameManager.hits >= 2500)
        {
            GameManager.boosts += 500;
            GameManager.hits -= 2500;
            PlayerPrefs.SetFloat("hits", GameManager.hits);
            PlayerPrefs.SetFloat("boosts", GameManager.boosts);
        }
        if (num == 5 && GameManager.hits >= 20000)
        {
            GameManager.boosts += 5000;
            GameManager.hits -= 20000;
            PlayerPrefs.SetFloat("hits", GameManager.hits);
            PlayerPrefs.SetFloat("boosts", GameManager.boosts);
        }
        if (num == 6 && GameManager.hits >= 100000)
        {
            GameManager.boosts += 10000;
            GameManager.hits -= 100000;
            PlayerPrefs.SetFloat("hits", GameManager.hits);
            PlayerPrefs.SetFloat("boosts", GameManager.boosts);
        }
    }

    public float Rounded(float x)
    {
        if (x < 9999) {
            return x;
        }
        else if (x < 999999) {
            abb = 1;
            return (float)Math.Round((Decimal)x / 1000, 2);
        }
        else if (x < 999999999) {
            abb = 2;
            return (float)Math.Round((Decimal)x / 1000000, 2);
        }
        else if (x < 999999999999) {
            abb = 3;
            return (float)Math.Round((Decimal)x / 1000000000, 2);
        }
        else if (x < 999999999999999) {
            abb = 4;
            return (float)Math.Round((Decimal)x / 1000000000000, 2);
        }
        else if (x < 999999999999999999) {
            abb = 5;
            return (float)Math.Round((Decimal)x / 1000000000000000, 2);
        }
        else
        {
            Reset();
            return x;
        }

    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        if (Input.GetMouseButtonDown(0) &&
            mousePos.x > Screen.width / 2 &&
            mousePos.y > Screen.height / 6 && mousePos.y < Screen.height / 6 * 5)
        {
            Increment();
        }
        ui.text = "Hits: " + Rounded(GameManager.hits) + letters[abb];
        ui2.text = "Boost: " + Rounded(GameManager.boosts) + letters[abb];

    }

    public void Reset()
    {
        GameManager.hits = 0;
        GameManager.boosts = 1;
        abb = 0;
    }



}
