using UnityEngine.UI;
using UnityEngine;
using System.Globalization;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Player.position.z);
        scoreText.text = Player.position.z.ToString("0");
    }
}
