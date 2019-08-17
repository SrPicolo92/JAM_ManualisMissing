using UnityEngine;

public class Buttons : MonoBehaviour
{
    private BoxCollider2D[] buttons;

    private int[] meteorShower  = { 1, 2, 3 };
    private int[] ovniAbduction = { 1, 2, 3 };
    private int[] iceAge        = { 1, 2, 3 };

    private void Start()
    {
        buttons = GetComponentsInChildren<BoxCollider2D>();
    }

    private void Update()
    {
        // TODO(voidmainvoid): fazer comportamento dos botoes!
        if (ButtonPressed() > 0) print("Pressed: " + ButtonPressed());
    }

    int ButtonPressed()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
            switch (hit.collider.gameObject.name)
            {
                case "b0":
                {
                    return 1;
                }
                case "b1":
                {
                    return 2;
                }
                case "b2":
                {
                    return 3;
                }
                case "b3":
                {
                    return 4;
                }
                case "b4":
                {
                    return 5;
                }
                case "b5":
                {
                    return 6;
                }
                case "b6":
                {
                    return 7;
                }
                case "b7":
                {
                    return 8;
                }
                case "b8":
                {
                    return 9;
                }
                default:
                    return (0);
            }
        }
        return 0;
    }

    void LightLed()
    {
        ++Leds.LedState;
    }

    void ResetLeds()
    {
        Leds.LedState = 0;
    }
}
