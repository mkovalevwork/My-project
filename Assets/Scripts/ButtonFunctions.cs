using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
    public GameObject unitToSpawn;
    public Transform transformToSpawn;
    private int roadNumber;
    private SpawnsHolder spawnHolder;

    private void Start()
    {        
        spawnHolder = GameObject.FindGameObjectWithTag("DataHolder").GetComponent<SpawnsHolder>();
    }

    public void Spawn()
    {
        roadNumber = Random.Range(0, 7);
        Instantiate(unitToSpawn, spawnHolder.TakeSpawn(roadNumber).position, Quaternion.identity);
        
    }

    public void GoNext()
    {

    }
    
}
