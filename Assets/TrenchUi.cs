using UnityEngine;

public class TrenchUi : MonoBehaviour
{
    [SerializeField] private GameObject moveBtn;
    private TrenchHolder trenchHolder;

    public delegate void ClickAction();
    public static event ClickAction OnClicked;

    private void Start()
    {
        trenchHolder = GetComponent<TrenchHolder>();
    }

    private void Update()
    {
        if (!trenchHolder.ListIsEmpty)
        {
            moveBtn.SetActive(true);
        }
        else
            moveBtn.SetActive(false);
    }

    public void OnPressBtn()
    {
        if (OnClicked != null)
        {
            OnClicked();
        }    
    }
}
