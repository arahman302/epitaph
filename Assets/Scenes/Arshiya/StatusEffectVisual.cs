using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffectVisual : MonoBehaviour
{

    //object initializations
    private SpriteRenderer enemyRenderer;
    private MonoBehaviour statusScript;
    // Start is called before the first frame update
    void Start()
    {
        enemyRenderer = gameObject.GetComponent<SpriteRenderer>();   
        statusScript = gameObject.GetComponent<StatusEffectManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //check if entity is under some effect
            //if they are, change the color 
    }
}
