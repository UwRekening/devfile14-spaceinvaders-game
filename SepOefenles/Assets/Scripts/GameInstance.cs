using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstance : MonoBehaviour
{
    [SerializeField] Animator animator;
    public void Pressed()
    {
        animator.Play("Intro");
    }
}
