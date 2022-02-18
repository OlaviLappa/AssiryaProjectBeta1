using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Utility;
using UnityEngine;


namespace UnityStandardAssets.Characters.FirstPerson
{
    public class MainHouseEnter : MonoBehaviour
    {

        [SerializeField] private GameObject _confirmWindow;       
        [SerializeField] private GameObject _avatar;
        [SerializeField] private GameObject _toOfficeTeleport;

        [SerializeField] private FirstPersonController firstPersonController;
        [SerializeField] private CharacterController characterController;

        public static bool isShowCursor = false;


        private void Awake()
        {
            _confirmWindow.SetActive(false);
            firstPersonController = _avatar.GetComponent<FirstPersonController>();
            characterController = _avatar.GetComponent<CharacterController>();
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

        public void AnswerYes() => StartCoroutine(ToTeleport());

        public void AnswerNo() => UpdateState();

        private IEnumerator ToTeleport()
        {
            firstPersonController.enabled = false;
            characterController.enabled = false;
            _avatar.transform.position = _toOfficeTeleport.transform.position;
            firstPersonController.enabled = true;
            characterController.enabled = true;

            UpdateState();

            yield return new WaitForSeconds(0.2f);
        }
    }
}