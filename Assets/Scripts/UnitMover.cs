using UnityEngine;
using UnityEngine.AI;

public class UnitMover : MonoBehaviour
{
    private SpawnsHolder dataHolder;
    private NavMeshAgent agent;
    private Transform trenchPosition;
    private int roadNumber;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        dataHolder = GameObject.FindGameObjectWithTag("DataHolder").GetComponent<SpawnsHolder>();
        roadNumber = Random.Range(0, 7);
        trenchPosition = dataHolder.TakeTrench(roadNumber);
        agent.SetDestination(trenchPosition.position);
    }
}