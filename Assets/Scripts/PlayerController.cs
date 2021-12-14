using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ListParticle listParticle;
    public Explosion explosion;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Ray myray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitinfo;
            if (Physics.Raycast(myray, out hitinfo, 100f))
            {
                FirtsElement firtsElement = hitinfo.collider.GetComponent<FirtsElement>();
                if (firtsElement != null)
                {
                    firtsElement.Break();
                    explosion.HitEffect(hitinfo);
                }

            }
        }

#if UNITY_EDITOR

        if (Input.GetMouseButtonDown(0))
        {
            Ray myray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitinfo;
            if (Physics.Raycast(myray, out hitinfo, 100f))
            {
                FirtsElement firtsElement = hitinfo.collider.GetComponent<FirtsElement>();
                if (firtsElement != null)
                {
                    firtsElement.Break();
                   
                }
                explosion.HitEffect(hitinfo);

            }
        }
#endif
    }

 }
