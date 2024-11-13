using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour

{

    private bool hasShield;
    


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D whatIHit)
    {
        if (whatIHit.tag == "EnemyOne")
        {
            //Enemy hits the Shield
            Destroy(this.gameObject);
            this.gameObject.SetActive(false);
           
        }


    }
}
