using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{

    Rigidbody2D rb2d;
    Vector3 movementVector;

    [SerializeField] float speed = 3f;

    Animate animate;

    // Called upon creation of GameObject
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 0;
        movementVector = new Vector3();
        animate = GetComponent<Animate>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");

        rb2d.velocity = movementVector * speed;

        animate.horizontal = movementVector.x;
    }
}
