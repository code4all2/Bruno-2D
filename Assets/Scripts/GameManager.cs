using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    int vidas = 3;
    int moedas;

    private void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
