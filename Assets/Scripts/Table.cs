using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    public float tiltUp;
    public float tiltDown;
    public float angleUp;
    public float moveForward;
    public float moveUp;

    private Vector3 m_originalPos;
    private Vector3 m_TiltPos;
    private Quaternion m_originalAngle;
    private Quaternion m_90Angle;
    private bool m_tiltUp;
    private bool m_tiltDown;
    private float m_counter;
    // Start is called before the first frame update
    void Start()
    {
        m_originalAngle = transform.rotation;
        m_90Angle = Quaternion.AngleAxis(-angleUp, transform.forward);
        m_originalPos = transform.position;
        m_TiltPos = transform.position + moveForward * transform.right + moveUp * transform.up;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_tiltDown)
        {
            m_counter += Time.deltaTime;
            transform.rotation = Quaternion.Lerp(transform.rotation, m_originalAngle, m_counter * tiltDown * Time.deltaTime);
            transform.position = Vector3.Lerp(transform.position, m_originalPos, m_counter * tiltDown * Time.deltaTime);

            if (transform.rotation == m_originalAngle)
            {
                m_tiltDown = false;
                m_counter = 0;
            }
        }
        else if (m_tiltUp)
        {
            m_counter += Time.deltaTime;
            transform.rotation = Quaternion.Lerp(transform.rotation, m_90Angle, m_counter * tiltUp * Time.deltaTime);
            transform.position = Vector3.Lerp(transform.position, m_TiltPos, m_counter * tiltUp * Time.deltaTime);
            
            if (transform.rotation == m_90Angle)
            {
                m_tiltDown = true;
                m_tiltUp = false;
                m_counter = 0;
            }
        }
        else if(Input.GetKeyDown(KeyCode.V))
        {
            m_tiltUp = true;
            m_counter = 0;
        }

    }
}
