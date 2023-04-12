using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    Spaceship spaceship;
    Canvas canvas;
    [SerializeField] ParticleSystem particleSystem;
    [SerializeField] HealthPlayerPrefab health;

    private void Start()
    {
        spaceship = GetComponent<Spaceship>();
        health = spaceship.myCanvas.GetComponent<HealthPlayerPrefab>();
    }
   
    private void Update()
    {
        canvas = spaceship.myCanvas.GetComponent<Canvas>();
        canvas.transform.position = transform.position;

        if (health.healthbar.fillAmount == 0)
        {
            Destroy(health);
            Destroy(health.GetComponentInParent<Image>());
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Block")
        {
            particleSystem.Play();
            health.healthbar.fillAmount -= 0.1f;
        }
    }
}
