using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// �L�����N�^�[
/// </summary>
public class Character : MonoBehaviour
{
    [Header("��̃A�j���[�^�[")]
    [SerializeField] Animator leftAnimator;
    [SerializeField] Animator rightAnimator;

    GameInputs gameInputs;

    void OnDebugPlayerLeftHandUp(InputAction.CallbackContext context)
    {
        leftAnimator.SetBool("isUp", true);
    }

    void Start()
    {
        gameInputs = new GameInputs();
        gameInputs.UI.PlayerLeftHandUpDebug.started += OnDebugPlayerLeftHandUp;

        gameInputs.Enable();
    }

    void OnDestroy()
    {
        gameInputs.Dispose();
    }
}
