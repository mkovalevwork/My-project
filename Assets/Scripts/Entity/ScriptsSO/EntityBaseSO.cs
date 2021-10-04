using UnityEngine;

public abstract class EntityBaseSO : ScriptableObject
{
    [SerializeField] private GameObject entity;
    [SerializeField] private string entityName;

    public GameObject Entity => entity;
    public string EntityName => entityName;
}