using UnityEngine;

public class respawn : MonoBehaviour
{
    public GameObject Square;
    public Transform[] SpawnPoints;
    public float respawnTime = 2f;
    private float timer;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= respawnTime)
        {

            Spawner();
            timer = 0f;
        }
    }

    void Spawner()
    {
        if (SpawnPoints.Length == 0)
        {

            Debug.Log("No spawn points assigned");
            return;
        }

        int randomIndex = Random.Range(0, SpawnPoints.Length);
        Instantiate(Square, SpawnPoints[randomIndex].position, Quaternion.identity);

    }
}
