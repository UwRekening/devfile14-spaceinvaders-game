using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    public Transform firePoint;
    [SerializeField] GameObject laser;
    Spaceship spaceship;

    private void Start()
    {
        spaceship = GetComponent<Spaceship>();
    }

    private void Update()
    {
        if (spaceship.playerIndex == 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                StartCoroutine(ShootPlayerP1());
            }
        } else if (spaceship.playerIndex == 2)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine(ShootPlayerP2());
            }
        }
    }
    private IEnumerator ShootPlayerP1()
    {
        Instantiate(laser, firePoint.position, firePoint.rotation);
        yield return new WaitForSeconds(1f);
    }
    private IEnumerator ShootPlayerP2()
    {
        Instantiate(laser, firePoint.position, firePoint.rotation);
        yield return new WaitForSeconds(1f);
    }
}
