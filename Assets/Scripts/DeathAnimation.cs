using System.Collections;
using UnityEngine;
using TMPro;


public class DeathAnimation : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite deadSprite;
    public TextMeshProUGUI gameOverText; 


    public void Reset()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnEnable()
    {
        UpdateSprite();
        DisablePhysics();
        StartCoroutine(Animate());
    }

    private void UpdateSprite()
    {
        spriteRenderer.enabled = true;
        spriteRenderer.sortingOrder = 100;
        
        if(deadSprite != null) {
            spriteRenderer.sprite = deadSprite;
        }

    }

    private void DisablePhysics()
    {
        Collider2D[] colliders = GetComponents<Collider2D>();

        foreach (Collider2D collider in colliders)
        {
            collider.enabled = false;
        }

        GetComponent<Rigidbody2D>().isKinematic = true;

        Player playerMovement = GetComponent<Player>();
        EntityMovement entityMovement = GetComponent<EntityMovement>();


        if(playerMovement != null) {
            playerMovement.enabled = false;
        }

        if(entityMovement != null) {
            entityMovement.enabled = false;
        }

    }

    private IEnumerator Animate()
    {
        float elapsed = 0f;
        float duration = 3f;

        float jumpVelocity = 10f;
        float gravity = -36f;

        Vector3 velocity = Vector3.up * jumpVelocity;

        while(elapsed < duration) {
            transform.position += velocity * Time.deltaTime;
            velocity.y += gravity * Time.deltaTime;
            elapsed += Time.deltaTime;
            yield return null;

            if (gameOverText != null)
            {
                gameOverText.text = "Game Over";
                gameOverText.gameObject.SetActive(true);
            }
        }

    }
}
