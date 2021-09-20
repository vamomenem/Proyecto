using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class MovimientosBasicos : MonoBehaviour
{
    public CharacterController cuntroles;
    public float spEed = 5;
    private Vector3 movementInput;
     Vector3 moveVector;


    [SerializeField] KeyCode uparrow;
    
    [SerializeField] KeyCode downarrow;
    
    [SerializeField] KeyCode rightarrow;
    
    [SerializeField] KeyCode leftarrow;

    public float TurnSmoothTime = 0.001f;
    float TurnSmoothVelocity;

    private void Update()
    {


      float horizontal = 0;
      float vertical = 0;

      if (Input.GetKey(uparrow)){
         switch (vertical){
            case 1:
              break;
            case 0:
              vertical = 1;
              break;
            case -1:
              vertical = 0;
              break;
         }
      }

      if (Input.GetKey(downarrow)){
         switch (vertical){
            case 1:
              vertical = 0;
              break;
            case 0:
              vertical = -1;
              break;
            case -1:
              break;
         }
      }

            if (Input.GetKey(rightarrow)){
         switch (horizontal){
            case 1:
              break;
            case 0:
              horizontal = 1;
              break;
            case -1:
              horizontal = 0;
              break;
         }
      }

            if (Input.GetKey(leftarrow)){
         switch (horizontal){
            case 1:
              horizontal = 0;
              break;
            case 0:
              horizontal = -1;
              break;
            case -1:
              break;
         }
      }


      Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

      if(direction.magnitude >= 0.1f)
      {
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        //NO ES IMPOSTOR!!!
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref TurnSmoothVelocity, TurnSmoothTime);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);

          cuntroles.Move(direction * spEed * Time.deltaTime);
          //transform.Translate(new Vector3(, 0, ) * spEed * Time.deltaTime);
      }

      moveVector = Vector3.zero;

      if (cuntroles.isGrounded == false)
         {
             moveVector += Physics.gravity;
         }
 
         cuntroles.Move(moveVector * Time.deltaTime);

        
    }
    public void OnMove(InputAction.CallbackContext ctx) => movementInput = ctx.ReadValue<Vector3>();

    
}
