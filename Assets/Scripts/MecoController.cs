using UnityEngine;

public class MecoController : MonoBehaviour
{
    public string axis;
    public float speed;
    public float range;

    public string rotateAxis;
    public int torque;
    public int rotationSpeed;

    public string shotKey;
    public float shotPower;

    public string rufoletaKey;
    public float rufoletaPower;

    public string levantamosKey;
    private bool m_levatados = false;

    public string backpassKey;
    public float backpassPower;

    public string wtfKey;
    public float wtfPower;
    private bool m_wtfMode = false;

    public GameObject cano;

    private float m_origin;
    private Rigidbody m_Rigidbody;

    private GameObject m_Ball;

    // Start is called before the first frame update
    void Start()
    {
        m_origin = transform.position.x;
        m_Rigidbody = GetComponent<Rigidbody>();

        m_Rigidbody.centerOfMass = cano.transform.localPosition;
    }

    private void Update()
    {
        if (Input.GetKeyDown(shotKey))
        {
            // ANIMATE ME!
            if (m_Ball != null)
            {
                if(m_wtfMode)
                {
                    m_Ball.GetComponent<Rigidbody>().AddForce(-transform.right * wtfPower, ForceMode.Impulse);
                    int sign = Random.Range(-1f, 1f) >= 0 ? 1 : -1;
                    m_Ball.GetComponent<Rigidbody>().AddForce(sign * transform.forward * wtfPower, ForceMode.Impulse);
                }
                else
                {
                    m_Ball.GetComponent<Rigidbody>().AddForce(-transform.right * shotPower, ForceMode.Impulse);
                }
            }
        }

        if (rufoletaKey != "" && Input.GetKeyDown(rufoletaKey))
        {
            // ANIMATE ME!
            if (m_Ball != null)
            {
                m_Ball.GetComponent<Rigidbody>().AddForce(-transform.right * rufoletaPower, ForceMode.Impulse);
            }
        }

        if (levantamosKey != "" && Input.GetKeyDown(levantamosKey))
        {
            // CHANGE TO SHHHHHLERP
            m_levatados = !m_levatados;
            if (m_levatados)
            {
                transform.Rotate(new Vector3(0, 0, 90));
            }
            else
            {
                transform.Rotate(new Vector3(0, 0, -90));
            }
        }

        if (backpassKey != "" && Input.GetKeyDown(backpassKey))
        {
            // ANIMATE ME!
            if (m_Ball != null)
            {
                m_Ball.GetComponent<Rigidbody>().AddForce(transform.right * backpassPower, ForceMode.Impulse);
            }
        }

        if (wtfKey != "" && Input.GetKeyDown(wtfKey))
        {
            m_wtfMode = !m_wtfMode;
            // ANIMATE ME!
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float velocity = Input.GetAxis(axis) * speed;

        /*transform.position = new Vector3(
        Mathf.Max(m_origin - range, Mathf.Min(m_origin + range, transform.position.x + velocity * Time.deltaTime)),
        transform.position.y,
        transform.position.z);*/

        m_Rigidbody.velocity = new Vector3(velocity, m_Rigidbody.velocity.y, m_Rigidbody.velocity.z);

        //float rotation = Input.GetAxis(rotateAxis);

        //m_Rigidbody.AddTorque(- rotation * transform.forward * torque, ForceMode.Impulse);
        //m_Rigidbody.AddRelativeTorque(-rotation * transform.forward * torque);
        /*Vector3 m_EulerAngleVelocity = new Vector3(0, 0, - rotation * rotationSpeed);
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.deltaTime);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);*/
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ballz")
        {
            m_Ball = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Ballz")
        {
            m_Ball = null;
        }
    }
}
