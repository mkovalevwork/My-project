using UnityEngine;
using UnityEngine.AI;

public class UnitMover : MonoBehaviour
{
    private SpawnsHolder dataHolder;
    private NavMeshAgent agent;
    private Transform trenchPosition;
    private int roadNumber;


    private void OnEnable()
    {
        TrenchUi.OnClicked += MoveTo;
    }

    private void OnDisable()
    {
        TrenchUi.OnClicked -= MoveTo;
    }

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        dataHolder = GameObject.FindGameObjectWithTag("DataHolder").GetComponent<SpawnsHolder>();
        roadNumber = Random.Range(0, 7);
        trenchPosition = dataHolder.TakeTrench(roadNumber);
    }

    private void Update()
    {
        agent.SetDestination(trenchPosition.position);
    }

    private void MoveTo()
    {
        Debug.Log("Move to endpoint");
    }
}