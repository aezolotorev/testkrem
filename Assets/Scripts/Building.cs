using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    [SerializeField] List<Element> elements;
    [SerializeField]private int numberofelement;
    [SerializeField]private int numberofbreakelement;
    private UIController uIController;
    public float destroyValue;
    private void Start()
    {
        uIController = FindObjectOfType<UIController>();
        numberofbreakelement = 0;
        numberofelement = elements.Count;

        foreach (var e in elements)
        {
            e.firtsElement.breakevent += ElementIsBreaking;
        }
    }
    public void ElementIsBreaking()
    {
        numberofbreakelement++;
        if (numberofbreakelement > numberofelement)
            numberofbreakelement = numberofelement;
        destroyValue = numberofbreakelement*100/numberofelement;
        uIController.SetValue((int)destroyValue); 

    }




}
