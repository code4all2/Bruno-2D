using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField] string sceneName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<PlayerMovement>(out var player))
        {
            if(player != null)
            {
                SceneManager.LoadSceneAsync(sceneName);
            }
        }
    }
}
