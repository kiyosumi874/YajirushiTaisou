using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DificultSelector : MonoBehaviour
{
    static readonly float DificultUIDistance = 30.0f * 3.0f;

    [SerializeField] RectTransform selector;

    GameInputs gameInputs;
    DificultType currentDificultType = DificultType.Easy;

    /// <summary>
    /// 一度だけの初期化
    /// </summary>
    public void InitializeOnce()
    {
        gameInputs = new GameInputs();
        gameInputs.UI.Select.started += OnSelected;
        gameInputs.UI.Navigate.started += OnNavigated;
        gameInputs.UI.NavigateUpDebug.started += OnDebugUpNavigated;
        gameInputs.UI.NavigateDownDebug.started += OnDebugDownNavigated;

        gameInputs.Enable();
    }

    /// <summary>
    /// 決定ボタンが押されたとき
    /// </summary>
    void OnSelected(InputAction.CallbackContext context)
    {
        SceneChanger.Instance.LoadSceneFaded("Rule");
    }

    /// <summary>
    /// Lスティックが入力されたとき
    /// </summary>
    void OnNavigated(InputAction.CallbackContext context)
    {
        if (!context.started) { return; }

        var inputValue = context.ReadValue<Vector2>();

        if (inputValue.x != 0)
        {
            return;
        }

        var vec3 = Vector3.zero;
        if (inputValue.y > 0)
        {
            switch (currentDificultType)
            {
                case DificultType.Easy:
                    break;
                case DificultType.Normal:
                    vec3.y += DificultUIDistance;
                    selector.position += vec3;
                    currentDificultType = DificultType.Easy;
                    break;
                case DificultType.hard:
                    vec3.y += DificultUIDistance;
                    selector.position += vec3;
                    currentDificultType = DificultType.Normal;
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch (currentDificultType)
            {
                case DificultType.Easy:
                    vec3.y -= DificultUIDistance;
                    selector.position += vec3;
                    currentDificultType = DificultType.Normal;
                    break;
                case DificultType.Normal:
                    vec3.y -= DificultUIDistance;
                    selector.position += vec3;
                    currentDificultType = DificultType.hard;
                    break;
                case DificultType.hard:
                    break;
                default:
                    break;
            }
        }
    }

    void OnDebugUpNavigated(InputAction.CallbackContext context)
    {
        var vec3 = Vector3.zero;
        switch (currentDificultType)
        {
            case DificultType.Easy:
                break;
            case DificultType.Normal:
                vec3.y += DificultUIDistance;
                selector.position += vec3;
                currentDificultType = DificultType.Easy;
                break;
            case DificultType.hard:
                vec3.y += DificultUIDistance;
                selector.position += vec3;
                currentDificultType = DificultType.Normal;
                break;
            default:
                break;
        }
    }

    void OnDebugDownNavigated(InputAction.CallbackContext context)
    {
        var vec3 = Vector3.zero;
        switch (currentDificultType)
        {
            case DificultType.Easy:
                vec3.y -= DificultUIDistance;
                selector.position += vec3;
                currentDificultType = DificultType.Normal;
                break;
            case DificultType.Normal:
                vec3.y -= DificultUIDistance;
                selector.position += vec3;
                currentDificultType = DificultType.hard;
                break;
            case DificultType.hard:
                break;
            default:
                break;
        }
    }

    void OnDestroy()
    {
        gameInputs.Dispose();
    }

}
