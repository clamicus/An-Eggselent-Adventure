using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject Boulder;
    public float spawnInterval = 0f;

    private float timer;
    
    private void Update()
    {
        timer += Time.deltaTime;
        int spawnPointX = Random.Range(-15, -10);
        int spawnPointY = Random.Range(7, 10);
        int spawnPointZ = Random.Range(34, 35);

        Vector3 spawnPostion = new Vector3(spawnPointX, spawnPointY, spawnPointZ);

        if (timer >= spawnInterval)
        {
            Instantiate(Boulder, spawnPostion, Quaternion.identity);
            timer = 0f; // Reset the timer
        }
    }





}
