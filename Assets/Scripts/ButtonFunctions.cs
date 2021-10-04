using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
    [Header("Scene References")] [SerializeField]
    private SpawnsHolder spawnHolder;

    [SerializeField] private EntityHandler entityHandler;

    public void SpawnRandomUnit()
    {
        entityHandler.OnRandomEntityRequest(spawnHolder.GetRandomSpawnPosition().position);
    }
}