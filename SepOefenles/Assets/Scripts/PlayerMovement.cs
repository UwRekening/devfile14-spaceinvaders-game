using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Spaceship spaceship;
    [SerializeField] float speed = 1f;
    [SerializeField] float rotateSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        spaceship = GetComponent<Spaceship>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (spaceship.playerIndex == 1)
        {
            float HorInput1 = Input.GetAxisRaw("Horizontal");
            float VerInput1 = Input.GetAxisRaw("Vertical");
            transform.Rotate(new Vector3(0, 0, -1), HorInput1 * rotateSpeed);
            Vector2 moveDirection = transform.up;
            spaceship.GetRb().AddForce(moveDirection * VerInput1 * speed);
        } else if (spaceship.playerIndex == 2)
        {
            float HorInput2 = Input.GetAxisRaw("HorizontalP2");
            float VerInput2 = Input.GetAxisRaw("VerticalP2");
            transform.Rotate(new Vector3(0, 0, -1), HorInput2 * rotateSpeed);
            Vector2 moveDirection = transform.up;
            spaceship.GetRb().AddForce(moveDirection * VerInput2 * speed);
        }
    }
}
