using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReseptionTrigger : GetCursor
{
    [SerializeField] private GameObject _choicePanel;

    private void Start()
    {
        _choicePanel.SetActive(false);        
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.TryGetComponent(out Player player))
        {
            _choicePanel.SetActive(true);
            isShowCursor = true;
        }
    }

    private void OnTriggerExit(Collider obj)
    {
        if (obj.gameObject.TryGetComponent(out Player player))
        {
            _choicePanel.SetActive(false);
            isShowCursor = false;
        }
    }

    public void RegistrationCitizen()
    {
        Application.OpenURL("http://assyrian.beget.tech/");
    }

    public void PurchaseRealEstate() { }
    public void GetBusinessPermit() { }
}
