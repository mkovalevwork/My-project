using UnityEngine;

public class RoadTrenchPos : MonoBehaviour
{
    [SerializeField] private Transform trench;
    public Transform Trench => trench;

    [SerializeField] private Transform endPos;
    public Transform EndPos => endPos;
}
