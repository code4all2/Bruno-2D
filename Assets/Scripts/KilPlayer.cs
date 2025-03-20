using UnityEngine;

public class KilPlayer : MonoBehaviour
{
    [SerializeField] int dano = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }

    }
}
