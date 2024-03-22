using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartialArts : MonoBehaviour {
  Animator animator;

  public GameObject punchFX;
  public GameObject kickFX;

  // Start is called before the first frame update
  void Start() { animator = GetComponent<Animator>(); }

  // Update is called once per frame
  void Update() {
    // Attacks
    if (Input.GetKeyDown(KeyCode.Alpha1)) {
      if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0) {
        animator.SetTrigger("PunchLower");
      } else
        animator.SetTrigger("Punch");
    }
    if (Input.GetKeyDown(KeyCode.Alpha2)) {
      animator.SetTrigger("Kick");
    }

    // Taunt
    if (Input.GetKeyDown(KeyCode.T)) {
      animator.SetTrigger("Taunt");
    }
  }
}
