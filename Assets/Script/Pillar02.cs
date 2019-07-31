using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar02 : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Pillar02")
        {
            Animator anim = other.GetComponentInChildren<Animator>();
            if (Input.GetKeyDown(KeyCode.E))
                anim.SetTrigger("Pillars02");
        }
    }
}
