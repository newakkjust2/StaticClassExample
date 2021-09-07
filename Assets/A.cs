using System;
using UnityEngine;

public class A : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    
    private B m_BScript;
    private Transform m_BTransform;

    public void Button(bool methodType)
    {
        if(!methodType) DirectLinkMethod();
        else StaticMethod();
    }
    
    private void DirectLinkMethod()     //метод прямой ссылки
    {
        m_BScript = FindObjectOfType<B>(); // самый частый способ
        if (m_BScript != null) m_BTransform = m_BScript.m_object.transform;
    }
    
    private void StaticMethod()     //метод статического поля
    {
        m_BScript = SomeStaticClass.bScript;
        if (m_BScript != null) m_BTransform = m_BScript.m_object.transform;
    }

    private void Update()                 
    {
        if (m_BTransform != null)
        {
            m_BTransform.Rotate(Vector3.one, speed * Time.deltaTime);
        }
    }
}
