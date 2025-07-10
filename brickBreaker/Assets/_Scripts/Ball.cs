using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    [SerializeField] private float speed = 500f;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Invoke(nameof(RandomTrajectory), 1f);
    }

    private void RandomTrajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-.5f, .5f);
        force.y = -1;

        rigidBody.AddForce(force.normalized * speed);
    }
}
