using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Character Movement
        float fwd = Input.GetAxis("Vertical");
        animator.SetFloat("Forward", Mathf.Abs(fwd));
        animator.SetFloat("Sense", Mathf.Sign(fwd));
        animator.SetFloat("Turn", Input.GetAxis("Horizontal"));

        // Quit Program
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
