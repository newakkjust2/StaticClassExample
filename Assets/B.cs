using System;
using UnityEngine;

public class B : MonoBehaviour
{
    public GameObject m_object;

#if UNITY_EDITOR
    private void OnValidate()
    {
        m_object = gameObject;
    }
#endif
}
