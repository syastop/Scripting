using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    // вход в область
    void OnTriggerEnter(Collider other)
    {
        // изменение силы прыжка
        other.GetComponent<Jump>().jumpStrength = 4.0f;
    }

    // выход
    void OnTriggerExit(Collider other)
    {
        // возвращение прежнего значения
        other.GetComponent<Jump>().jumpStrength = 2.0f;
    }
}
