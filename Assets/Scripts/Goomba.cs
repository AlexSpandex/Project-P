using UnityEngine;

public class Goomba : MonoBehaviour
{
    public Sprite flatSprite;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerNew player = collision.gameObject.GetComponent<PlayerNew>();
        
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.transform.DotTest(transform, Vector2.down))
            {
                Flatten();
            } else {
                player.Hit();
            }
        }
    }

    private void Flatten()
    {
        GetComponent<Collider2D>().enabled = false;
        GetComponent<EntityMovement>().enabled = false;
        GetComponent<AnimatedSprite>().enabled = false;
        GetComponent<SpriteRenderer>().sprite = flatSprite;
        Destroy(gameObject, 0.5f);
    }
}
