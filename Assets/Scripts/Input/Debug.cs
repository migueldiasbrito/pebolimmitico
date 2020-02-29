using UnityEngine;
using UnityEngine.UI;

public class Debug : MonoBehaviour
{
    public Text p1KeyMap, p2KeyMap;
    public RectTransform p1LeftAnal, p1RightAnal, p2LeftAnal, p2RightAnal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float p1keeper = Input.GetAxis("LeftKeeper");
        float p1defs = Input.GetAxis("LeftDefenders");

        p1LeftAnal.offsetMin = new Vector2(p1LeftAnal.offsetMin.x, p1keeper * 25);
        p1RightAnal.offsetMin = new Vector2(p1RightAnal.offsetMin.x, p1defs * 25);
        p1LeftAnal.offsetMax = new Vector2(p1LeftAnal.offsetMax.x, p1keeper * 25);
        p1RightAnal.offsetMax = new Vector2(p1RightAnal.offsetMax.x, p1defs * 25);

        float p2keeper = Input.GetAxis("RightKeeper");
        float p2defs = Input.GetAxis("RightDefenders");

        p2LeftAnal.offsetMin = new Vector2(p2LeftAnal.offsetMin.x, p2defs * 25);
        p2RightAnal.offsetMin = new Vector2(p2RightAnal.offsetMin.x, p2keeper * 25);
        p2LeftAnal.offsetMax = new Vector2(p2LeftAnal.offsetMax.x, p2defs * 25);
        p2RightAnal.offsetMax = new Vector2(p2RightAnal.offsetMax.x, p2keeper * 25);

        p1KeyMap.text =
            "joystick 1 button 0 " + Input.GetKey("joystick 1 button 0") + "\n" +
            "joystick 1 button 1 " + Input.GetKey("joystick 1 button 1") + "\n" +
            "joystick 1 button 2 " + Input.GetKey("joystick 1 button 2") + "\n" +
            "joystick 1 button 3 " + Input.GetKey("joystick 1 button 3") + "\n" +
            "joystick 1 button 4 " + Input.GetKey("joystick 1 button 4") + "\n" +
            "joystick 1 button 5 " + Input.GetKey("joystick 1 button 5") + "\n" +
            "joystick 1 button 6 " + Input.GetKey("joystick 1 button 6") + "\n" +
            "joystick 1 button 7 " + Input.GetKey("joystick 1 button 7") + "\n" +
            "joystick 1 button 8 " + Input.GetKey("joystick 1 button 8") + "\n" +
            "joystick 1 button 9 " + Input.GetKey("joystick 1 button 9") + "\n" +
            "joystick 1 button 10 " + Input.GetKey("joystick 1 button 10") + "\n" +
            "joystick 1 button 11 " + Input.GetKey("joystick 1 button 11") + "\n" +
            "LeftKeeper " + Input.GetAxis("LeftKeeper") + "\n" +
            "LeftDefenders " + Input.GetAxis("LeftDefenders") + "\n" +
            "";

        p2KeyMap.text =
            "joystick 2 button 0 " + Input.GetKey("joystick 2 button 0") + "\n" +
            "joystick 2 button 1 " + Input.GetKey("joystick 2 button 1") + "\n" +
            "joystick 2 button 2 " + Input.GetKey("joystick 2 button 2") + "\n" +
            "joystick 2 button 3 " + Input.GetKey("joystick 2 button 3") + "\n" +
            "joystick 2 button 4 " + Input.GetKey("joystick 2 button 4") + "\n" +
            "joystick 2 button 5 " + Input.GetKey("joystick 2 button 5") + "\n" +
            "joystick 2 button 6 " + Input.GetKey("joystick 2 button 6") + "\n" +
            "joystick 2 button 7 " + Input.GetKey("joystick 2 button 7") + "\n" +
            "joystick 2 button 8 " + Input.GetKey("joystick 2 button 8") + "\n" +
            "joystick 2 button 9 " + Input.GetKey("joystick 2 button 9") + "\n" +
            "joystick 2 button 10 " + Input.GetKey("joystick 2 button 10") + "\n" +
            "joystick 2 button 11 " + Input.GetKey("joystick 2 button 11") + "\n" +
            "RightKeeper " + Input.GetAxis("RightKeeper") + "\n" +
            "RightDefenders " + Input.GetAxis("RightDefenders") + "\n" +
            "";
    }
}
