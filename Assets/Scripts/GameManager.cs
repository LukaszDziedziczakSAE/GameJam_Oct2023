using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] EnemySpawn leftSpawner;
    [SerializeField] EnemySpawn rightSpawner;
    [SerializeField] float spawnRate;
    [SerializeField] float roundCooldown;
    [SerializeField] int baseSpawnAmount;
    [SerializeField] int additionSpawnPerLevel;

    int round = 0;
    int enemiesToSpawn = 0;
    bool leftspawned = true;
    public List<Enemy> Enemies = new List<Enemy>();
    float spawnTimer;
    Castle castle;
    

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this.gameObject);

        castle = FindAnyObjectByType<Castle>();
    }

    // Start is called before the first frame update
    void Start()
    {
        NewRound();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer > 0) spawnTimer -= Time.deltaTime;

        if (enemiesToSpawn > 0 && spawnTimer < 0)
        {
            if (leftspawned)
            {
                Enemies.Add(leftSpawner.SpawnEnemy());
                leftspawned = false;
            }
            else
            {
                Enemies.Add(rightSpawner.SpawnEnemy());
                leftspawned = true;
            }
            enemiesToSpawn--;
            spawnTimer = spawnRate;
        }

        if (Enemies.Count == 0 && spawnTimer <= 0)
        {
            NewRound();
            spawnTimer = roundCooldown;
        }
    }

    void NewRound()
    {
        round++;
        enemiesToSpawn = baseSpawnAmount + (round * additionSpawnPerLevel);
        spawnTimer = spawnRate;
        UI.UpdateUI();
    }

    public string RoundNumber => round.ToString();

    public static void EndGame()
    {
        SceneManager.LoadScene(0);
    }

    public int Round => round;
}
