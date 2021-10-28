using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Transform player;
	public Text scoreText;
    // Update is called once per frame
    void Update()
    {    	// Debug.Log(position);
    	scoreText.text = player.position.z.ToString("0");
    	// Debug.Log(scoreText.text);
    	// scroreText.Text = position;

    }
}
