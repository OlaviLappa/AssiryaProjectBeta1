using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHouseEnter : MonoBehaviour
{
    [SerializeField] private GameObject _confirmWindow;
    public static bool isShowCursor = false;
    

    private void Awake()
    {
        _confirmWindow.SetActive(false);
    }

    public void UpdateState()
    {
        _confirmWindow.SetActive(false);
        isShowCursor = false;
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.TryGetComponent(out Player player))
        {
            _confirmWindow.SetActive(true);
            isShowCursor = true;
        }
    }

    private void OnTriggerExit(Collider obj)
    {
        if (obj.gameObject.TryGetComponent(out Player player))
        {
            UpdateState();
        }
    }

    public void AnswerYes()
    {

    }

    public void AnswerNo()
    {
        UpdateState();
    }
}
