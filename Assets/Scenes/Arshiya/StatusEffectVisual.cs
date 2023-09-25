using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffectVisual : MonoBehaviour
{

    //object initializations
    private SpriteRenderer enemyRenderer;
    //private MonoBehaviour statusScript;
    private List<StatusEffectInstance> statusEffects;
    // Start is called before the first frame update
    void Start()
    {
        enemyRenderer = gameObject.GetComponent<SpriteRenderer>();   
        //statusScript = gameObject.GetComponent<StatusEffectManager>();
    }

    // Update is called once per frame
    void Update()
    {
        statusEffects = gameObject.GetComponent<StatusEffectManager>().getStatusEffects();
        //check if entity is under some effect
        foreach(StatusEffectInstance status in statusEffects){
            StatusEffect current = status.statusEffect;
            //if they are, change the color 
            if(current.ToString().Equals("BURN")){

            } else if (current.ToString().Equals("SLOWNESS")){

            } else{
                
            }
        }
    }
}
