using System.Collections;
using UnityEngine;
using TMPro;

public class FlagPole : MonoBehaviour
{   
    public Transform flag;
    public Transform poleBottom;
    public Transform castle;
    public float speed = 6f;
    public int nextWorld = 1;
    public int nextStage = 1;

    public TextMeshProUGUI winText;

   private void OnTriggerEnter2D(Collider2D other) 
   {
    if (other.CompareTag("Player"))
    {
        StartCoroutine(MoveTo(flag, poleBottom.position));
        StartCoroutine(LevelCompleteSequence(other.transform));
    }
   }

   private IEnumerator LevelCompleteSequence(Transform player)
   {
        player.GetComponent<Player>().enabled = false;
        yield return MoveTo(player, poleBottom.position);
        yield return MoveTo(player, player.position + Vector3.right);
        yield return MoveTo(player, player.position + Vector3.right + Vector3.down);
        yield return MoveTo(player, castle.position);

        player.gameObject.SetActive(false);

        yield return new WaitForSeconds(2f);

        GameManager.Instance.LoadLevel(nextWorld, nextStage + 1);

   }

    private IEnumerator MoveTo(Transform subject, Vector3 destination)
    {
        while(Vector3.Distance(subject.position , destination) > 0.125f)
        {   
            if (winText != null)
            {
                winText.text = "Win";
                winText.gameObject.SetActive(true);
            }

            subject.position = Vector3.MoveTowards(subject.position, destination, speed * Time.deltaTime);
            yield return null;
        }

        subject.position = destination;
    }
}
