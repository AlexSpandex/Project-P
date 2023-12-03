using UnityEngine;
using TMPro;


public class DeathBarrier : MonoBehaviour
{
    public TextMeshProUGUI gameOverText; 

   private void OnTriggerEnter2D(Collider2D other)
   {   
        if(other.CompareTag("Player")){
            other.gameObject.SetActive(false);
            if (gameOverText != null)
            {
                gameOverText.text = "Game Over";
                gameOverText.gameObject.SetActive(true);
            }
            GameManager.Instance.ResetLevel(3f);
        } else 
        {
            Destroy(other.gameObject);
        }
    }
}
