using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewgameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        Debug.Log("It's a new game");
        GameObject[] allenemies = GameObject.FindGameObjectsWithTag("Enemies");
        foreach (GameObject dude in allenemies)
            GameObject.Destroy(dude);
    }
}
