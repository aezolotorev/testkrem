using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirtsElement : MonoBehaviour
{
    public delegate void BreakBrick();
    public event BreakBrick breakevent;


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.ToString());
        if (collision.gameObject.GetComponent<Rigidbody>().velocity.magnitude > 3f)
        {
            breakevent?.Invoke();
        }
    }
    [ContextMenu("Break")]
    public void Break()
    {
        breakevent?.Invoke();
    }


}
