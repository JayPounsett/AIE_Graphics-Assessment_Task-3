using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartialArts : MonoBehaviour {
  Animator animator;

  public GameObject punchFX;
  public GameObject kickFX;

  // Start is called before the first frame update
  void Start() { 
        animator = GetComponent<Animator>();
        
        // Set VFX to not activate on awake
        kickFX.SetActive(false);
        punchFX.SetActive(false);
    }

  // Update is called once per frame
  void Update() {
    // Attacks
    if (Input.GetKeyDown(KeyCode.Mouse0)) {
      if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0) {
        animator.SetTrigger("PunchLower");
      } else
        animator.SetTrigger("Punch");
    }
    if (Input.GetKeyDown(KeyCode.Mouse1)) {
      animator.SetTrigger("Kick");
    }
  }
}
