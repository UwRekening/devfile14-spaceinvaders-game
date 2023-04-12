using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipFactory : MonoBehaviour
{
    [SerializeField] Spaceship SpaceshipPrefab = null;
    [SerializeField] Spaceship SpaceshipPrefab2 = null;
    private void Start()
    {
        for (int i = 1; i < 3; i++)
        {
            SpaceshipPrefab.playerIndex = i;
            if (SpaceshipPrefab.playerIndex == 1)
            {
                Instantiate(SpaceshipPrefab);
            } else if (SpaceshipPrefab.playerIndex == 2)
            {
                Instantiate(SpaceshipPrefab2);
            }
        }
    }
}
