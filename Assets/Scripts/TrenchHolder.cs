using System.Collections.Generic;
using UnityEngine;

public class TrenchHolder : MonoBehaviour
{
    private bool listIsEmpty = true;
    public bool ListIsEmpty => listIsEmpty;

    public List<GameObject> units = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {       
        if (other.GetComponent<UnitMover>())
        {
            units.Add(other.gameObject);           
        }
        CheckList();
    }

    private void OnTriggerExit(Collider other)
    {
        units.Contains(other.gameObject);
        units.Remove(other.gameObject);       
        CheckList();
    }

    private void CheckList()
    {
        listIsEmpty = units.Count == 0;
    }
}
