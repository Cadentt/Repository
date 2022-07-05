using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public Sabers sb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 2;   //Move Boxes Forward
        StartCoroutine(ExecuteAfterTime(10));
    }

    IEnumerator ExecuteAfterTime(float time)                            // After 10 seconds destroy the cube
    {                                                                    
        yield return new WaitForSeconds(time);

        ScoreManager.score--;                                           // Decrease Score
        ScoreManager.missedBox++;                                       // After player missed , lose the game                                     
       Destroy(this.gameObject);
    }
    
}
