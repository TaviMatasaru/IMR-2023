using UnityEngine;

public class Knife : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target")) // Presupunem că ținta are tag-ul "Target"
        {
            ScoreManager.instance.IncreaseScore(100);
        }
    }
}
