using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreingame : MonoBehaviour
{
    public GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemies"))
        {
           // Debug.Log("you hit an enemy");
            scoreText.GetComponent<ScoreKeeper>().UpdateScore();
        }
    }
}
