using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnightControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public KeyCode attack;
    public Transform idle;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void shootNow()
    {
        Instantiate(idle, new Vector3 (1, .75f, 0), idle.rotation);
    }

    void onMouseDown()
    {
        anim.SetTrigger("attack");
    }
}
