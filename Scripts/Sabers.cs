using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sabers : MonoBehaviour
{
    public LayerMask layer;
    private Vector3 previousPos;
    public string level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;                                                                         // Hit Check
        if(Physics.Raycast(transform.position,transform.forward,out hit,1,layer))
        {
            if(Vector3.Angle(transform.position-previousPos,hit.transform.up)>130)
            {
                ScoreManager.score++;                                                           // Increase score if object is hit
                
                Destroy(hit.transform.gameObject);                                              // Destroy object if hit
            }
        }
        previousPos = transform.position;
        
        if(ScoreManager.missedBox>4)                                                            // If 4 object missed game over
        {
            SceneManager.LoadScene(level);                                                      // Open a level
        }    
    }
}
