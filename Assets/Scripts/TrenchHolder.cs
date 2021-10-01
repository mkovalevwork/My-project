using System.Collections.Generic;
using UnityEngine;

public class TrenchHolder : MonoBehaviour
{
    private bool listIsEmpty;
    public bool ListIsEmpty => listIsEmpty;

    public List<GameObject> units = new List<GameObject>();

    public delegate void SomeAction();

    public event SomeAction gameStartAction;

    private void Start()
    {
        listIsEmpty = true;
    }

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
        if (units.Count == 0)
        {
            listIsEmpty = true;
        }
        else
            listIsEmpty = false;
    }

    public void OnClickMoveBtn()
    {
        gameStartAction?.Invoke();
    }
}
