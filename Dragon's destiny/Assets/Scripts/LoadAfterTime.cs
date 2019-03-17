using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAfterTime : MonoBehaviour
{
    private IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(5.0f); // таймер, через 10 секунд
        Application.LoadLevel(1); // выполнится эта строка
    }
}
