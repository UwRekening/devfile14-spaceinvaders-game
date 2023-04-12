using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spaceship : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject canvasPrefab;
    public GameObject myCanvas;
    public int playerIndex = 0;
    private void Start()
    {
        myCanvas = Instantiate(canvasPrefab);
    }
    public Rigidbody2D GetRb()
    {
        return rb;
    }
}
