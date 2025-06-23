using UnityEngine;
using TMPro; 
public class CollectSquares : MonoBehaviour
{

    private int score = 0;

    public TextMeshProUGUI scoreText;


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Square")){
            Destroy(other.gameObject);
            Debug.Log("hiting");
            score += 1;
            scoreText.text = "Score: " + score.ToString();
        }

    }
    
}
