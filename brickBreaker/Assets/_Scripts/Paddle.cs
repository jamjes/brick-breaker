using UnityEngine;

public class Paddle : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    [SerializeField] private float force = 25f;
    private int direction;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 1;
        }
        else
        {
            direction = 0;
        }
    }

    private void FixedUpdate()
    {
        if (direction == 0)
        {
            return;
        }

        rigidBody.AddForce(new Vector2(direction * force, 0));
    }
}
