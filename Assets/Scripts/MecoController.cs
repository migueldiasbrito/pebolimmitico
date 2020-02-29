using UnityEngine;

public class MecoController : MonoBehaviour
{
    public string axis;
    public float speed;
    public float range;

    private float m_origin;

    // Start is called before the first frame update
    void Start()
    {
        m_origin = transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float velocity = Input.GetAxis(axis) * speed;
        
        transform.position = new Vector3(
        Mathf.Max(m_origin - range, Mathf.Min(m_origin + range, transform.position.x + velocity * Time.deltaTime)),
        transform.position.y,
        transform.position.z);
    }
}
