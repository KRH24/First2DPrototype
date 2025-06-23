using UnityEngine;
using TMPro; 
public class CollectCoins : MonoBehaviour
{

    public GameObject Square;

    private int score = 0;

    public TextMeshProUGUI scoreText;


    OnCollisionEnter(Collision other)
    {
        Destroy(GameObject);
        score += 1;

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
