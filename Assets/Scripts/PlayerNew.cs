using UnityEngine;

public class PlayerNew : MonoBehaviour
{   
    public PlayerSpriteRenderer smallRenderer;
    public PlayerSpriteRenderer bigRenderer;

    private DeathAnimation deathAnimation;

    public bool big => bigRenderer.enabled;
    public bool small => smallRenderer.enabled;
    public bool dead => deathAnimation.enabled;

    private void Awake() 
    {
        deathAnimation = GetComponent<DeathAnimation>();
    }
    
    public void Hit()
    {
        if (big) {
            Shrink();
        } else {
            Death();
        }

    }

    public void Shrink ()
    {

    }

    private void Death() 
    {
        smallRenderer.enabled = false;
        bigRenderer.enabled = false;
        deathAnimation.enabled = true;

        GameManager.Instance.ResetLevel(3f);
    }
}
