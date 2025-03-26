using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    int vidas = 3;
    int moedas;

    public int maxMoedas;
    public Transform spawnPlayer;

    PlayerMovement player;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        player = FindAnyObjectByType<PlayerMovement>();
    }

    void Update()
    {
        moedas = player.GetMoedas();
        Debug.Log(moedas);
    }

    public void SetLife(int life)
    {
        vidas = life;
    }
    public int GetLife()
    {
        return vidas;
    }


}
