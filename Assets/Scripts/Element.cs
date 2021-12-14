using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    [SerializeField] GameObject breakingElement;
    [SerializeField] GameObject element;
    public FirtsElement firtsElement;
    public bool isBreaking;

    public delegate void BreakBrick(GameObject g);
    public event BreakBrick breakevent;

    private void Awake()
    {
        firtsElement = element.GetComponent<FirtsElement>();
    }


    private void Start()
    {
        firtsElement.breakevent += Break;
    }

    private void OnDisable()
    {
        firtsElement.breakevent += Break;
    }
    [ContextMenu("Break")]
    public void Break()
    {
        Transform elementTransform = element.transform;
        element.SetActive(false);        
        breakingElement.SetActive(true);
        breakingElement.transform.position = elementTransform.position;
        breakingElement.transform.rotation= elementTransform.rotation;
    }



}
