using UnityEngine;

public class SpawnsHolder : MonoBehaviour
{
    [SerializeField] private Transform[] spawnsTransforms;

    public Transform GetRandomSpawnPosition()
    {
        return spawnsTransforms[Random.Range(0, spawnsTransforms.Length - 1)];
    }

    public Transform TakeSpawn(int roadNumber)
    {
        Transform transform = spawnsTransforms[roadNumber];
        return transform;
    }

    public Transform TakeTrench(int roadNumber)
    {
        Transform transform = spawnsTransforms[roadNumber].GetComponent<RoadTrenchPos>().Trench;
        return transform;
    }
}