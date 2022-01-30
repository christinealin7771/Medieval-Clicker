using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float hits;
    public static float boosts;
    //public static int abb;
   

    // Start is called before the first frame update
    void Start()
    {
        hits = PlayerPrefs.GetFloat("hits", (float)0.0);
        boosts = PlayerPrefs.GetFloat("boosts", (float)1);
    }

 
  
}
