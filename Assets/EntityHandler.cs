using System.Collections.Generic;
using UnityEngine;

public class EntityHandler : MonoBehaviour
{
    [Header("Spawning Options")]
    [SerializeField] private List<EntityBaseSO> entityBaseSos;

    public SpawnRandomEntity OnRandomEntityRequest;
    public SpawnEntity OnEntityRequest = delegate { };
    public EntityRemove OnEntityRemove = delegate { };

    readonly List<GameObject> spawnedEntities = new List<GameObject>();

    
    private void OnEnable()
    {
        OnEntityRequest += OnEventRaised;
        OnRandomEntityRequest += OnEventRaised;
        OnEntityRemove += OnEventReturn;
    }

    private void OnDisable()
    {
        OnEntityRequest -= OnEventRaised;
        OnRandomEntityRequest -= OnEventRaised;
        OnEntityRemove -= OnEventReturn;
    }

    private void OnEventReturn(GameObject entity)
    {
        bool result = spawnedEntities.Remove(entity);

        if (result)
        {
            Destroy(entity);
        }
    }

    private void OnEventRaised(EntityBaseSO entityBaseSo, Vector3 spawnPosition)
    {
        var tempGO = Instantiate(entityBaseSo.Entity, spawnPosition.normalized, Quaternion.identity);
        spawnedEntities.Add(tempGO);
    }

    private void OnEventRaised(Vector3 spawnPosition)
    {
        var tempGO = Instantiate(ReturnRandomEntity().Entity, spawnPosition.normalized, Quaternion.identity);
        spawnedEntities.Add(tempGO);
    }

    private EntityBaseSO ReturnRandomEntity()
    {
        int tempIndex = Random.Range(0, entityBaseSos.Count -1);
        return entityBaseSos[tempIndex];
    }
}

public delegate void SpawnRandomEntity(Vector3 spawnPosition);

public delegate void SpawnEntity(EntityBaseSO entitySO, Vector3 spawnPosition);

public delegate void EntityRemove(GameObject entity);