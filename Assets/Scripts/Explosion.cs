using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public ListParticle listParticle;   

    public void HitEffect(RaycastHit hit)
    {       
        Spawneffect(hit);
        Debug.Log("++++++++++++++++++++");
       
    }

    void Spawneffect(RaycastHit hit)
    {
        GameObject effect = listParticle.freeParticle[0];
        effect.transform.position = hit.point;
        effect.transform.rotation = Quaternion.LookRotation(hit.normal);
        //effect.transform.SetParent(hit.collider.transform);
        effect.SetActive(true);
    }
   
}
