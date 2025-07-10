using UnityEngine;

public class Brick : MonoBehaviour
{
    public delegate void BrickEvent();
    public static event BrickEvent OnBreak;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ball")
        {
            if (OnBreak != null)
            {
                OnBreak();
            }
            
            Destroy(gameObject);
        }
    }
}
