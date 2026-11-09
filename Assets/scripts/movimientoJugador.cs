using UnityEngine;
using UnityEngine.InputSystem;

public class movimientoJugador : MonoBehaviour
{
    public float speed = 1;
    public bool JugadorA;

    // Update is called once per frame
    void Update()
    {

        Vector3 dir = new Vector3(0, 0);
        
        if (JugadorA == true)
        {
            if (Keyboard.current.wKey.isPressed)
            {
                dir.y = 1;
            }
            if (Keyboard.current.sKey.isPressed)
            {
                dir.y = -1;
            }
        }
        
        else
        {
            if (Keyboard.current.upArrowKey.isPressed)
            {
                dir.y = 1;
            }
            if (Keyboard.current.downArrowKey.isPressed)
            {
                dir.y = -1;
            }
            

        }

        
        
        

        //la nueva posicion es al posicion actual sumada a la direccion
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }

}
