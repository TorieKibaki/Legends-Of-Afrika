using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    public Transform player;
    Vector3 spawnPoint;


    public bool hasSafeCollectible;


    DisappearingTile[] disappearingTiles;
    Collectible[] collectibles;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }


    void Start()
    {
        spawnPoint = player.position;
        disappearingTiles = FindObjectsOfType<DisappearingTile>();
        collectibles = FindObjectsOfType<Collectible>();
    }


    public void PlayerDied()
    {
        UIManager.Instance.ShowMessage("You died!");
        Respawn();
    }


    public void Respawn()
    {
        hasSafeCollectible = false;
        player.position = spawnPoint;


        foreach (var tile in disappearingTiles)
            tile.ResetTile();


        foreach (var col in collectibles)
            col.ResetCollectible();
    }
}using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
