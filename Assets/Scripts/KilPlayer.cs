using UnityEngine;

public class KilPlayer : MonoBehaviour
{
    int vida;
    [SerializeField] bool isHill;
    private void Start()
    {
        vida = GameManager.instance.GetLife();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            vida = GameManager.instance.GetLife() - 1;
            GameManager.instance.SetLife(vida);
            if (isHill) collision.transform.position = GameManager.instance.spawnPlayer.position;
            Debug.Log(vida);

            if (vida < 0) Destroy(collision.gameObject);
        }

    }
}
