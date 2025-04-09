using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public TMP_Text vidaText;
    public TMP_Text moedaText;
    public GameObject gameOverScreen;

    int vidas = 3;
    int moedas;

    public int maxMoedas;
    public Transform spawnPlayer;
    public Portal portal;

    PlayerMovement player;
    private void Awake()
    {
        instance = this;

        gameOverScreen.SetActive(false);
        portal.gameObject.SetActive(false);
    }

    void Start()
    {
        player = FindAnyObjectByType<PlayerMovement>();
    }

    void Update()
    {
        if (vidas <= 0)
        {
            gameOverScreen.SetActive (true);
            return;
        }
        moedas = player.GetMoedas();

        vidaText.SetText(vidas.ToString());
        moedaText.SetText(moedas.ToString());

        if (moedas >= maxMoedas)
        {
            portal.gameObject.SetActive(true);
        }

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
