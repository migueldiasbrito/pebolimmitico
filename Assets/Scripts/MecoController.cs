using UnityEngine;

public class MecoController : MonoBehaviour
{
    public string axis;
    public float speed;
    public float range;

    public string rotateAxis;
    public int torque;
    public int rotationSpeed;

    public GameObject cano;

    private float m_origin;
    private Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        m_origin = transform.position.x;
        m_Rigidbody = GetComponent<Rigidbody>();

        m_Rigidbody.centerOfMass = cano.transform.localPosition;
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

        float rotation = Input.GetAxis(rotateAxis);

        //m_Rigidbody.AddTorque(- rotation * transform.forward * torque, ForceMode.Impulse);
        //m_Rigidbody.AddRelativeTorque(-rotation * transform.forward * torque);
        Vector3 m_EulerAngleVelocity = new Vector3(0, 0, - rotation * rotationSpeed);
        Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.deltaTime);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * deltaRotation);
    }
}
