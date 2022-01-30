using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChangeClick : MonoBehaviour
{
    public Image oldImage;
    public Sprite oldImage2;
    public Sprite newImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ImageChange()
    {
        oldImage.sprite = newImage;
  
    }

    public void ImageBack()
    {
        oldImage.sprite = oldImage2;
    }
}
