using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        animator.SetBool("mouse_clicked", false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        if (Input.GetMouseButtonDown(0) && !animator.GetBool("mouse_clicked") &&
            mousePos.x > Screen.width/2 &&
            mousePos.y > Screen.height/6 && mousePos.y < Screen.height/6*5)
        {
            StartCoroutine(KnightClicked());
        }
    }

    public IEnumerator KnightClicked()
    {
        animator.SetBool("mouse_clicked", true);
        yield return new WaitForSeconds(0.15f);
        animator.SetBool("mouse_clicked", false);
    }
}
