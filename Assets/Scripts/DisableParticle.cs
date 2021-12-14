using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableParticle : MonoBehaviour
{
    public ListParticle listParticle;   
    public GameObject parent; 
    public float timer = 0;
    public float timeToDisable = 3;



    private void OnEnable()
    {
        timer = 0;
        listParticle.busyParticle.Add(gameObject);
        listParticle.freeParticle.RemoveAt(0);

    }


    void Update()
    {
        if (timer >= timeToDisable)
        {
            this.gameObject.SetActive(false);
            listParticle.freeParticle.Add(gameObject);
            listParticle.busyParticle.RemoveAt(0);

        }
         
        timer += Time.deltaTime;
    }



}
