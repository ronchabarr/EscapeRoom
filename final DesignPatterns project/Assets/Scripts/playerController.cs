using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class playerController : MonoBehaviour
{

    public float speed;

    public float jumpForce;

    public float downRayDistance;
    Camera viewCam;

    Text text;
    public string successText = "You are in!";
    public string emptyText = " ";


    [SerializeField] float interractRange;
    private PlayerInventory _playerInventory;
    private Rigidbody rb;
    [SerializeField] LayerMask targetLayer;
    private float hAxis, vAxis;
    // Start is called before the first frame update
    private Ray MiddleScreenRay;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        viewCam = GetComponentInChildren<Camera>();
       // MiddleScreenRay = ;
        _playerInventory = GetComponent<PlayerInventory>();
        hAxis = 0;
        vAxis = 0;

        text = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        Jump();


        if (Input.GetKeyDown(KeyCode.F)&&AbleToInterract())
        {
            Debug.Log("Interraction Try");
            Interract();
        }


    }

    public void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.fixedDeltaTime;

        Vector3 newPos = rb.position + rb.transform.TransformDirection(movement);

        rb.MovePosition(newPos);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (IsGrounded())
            {
                rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            }
        }
    }

    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, downRayDistance);
    }

    public void Interract()
    {
        if(Physics.Raycast(viewCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)), out RaycastHit hit, interractRange, targetLayer))
        {
        InterractionHandler(hit);
        }
        
    }
    public bool AbleToInterract()
    {
        return Physics.Raycast(viewCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)), interractRange,targetLayer);
    }
    public void InterractionHandler(RaycastHit hit)
    {

        InterractableObject interractableObject= hit.collider.GetComponent<InterractableObject>();

        
        switch (interractableObject.MyInterractType)
        {
            case InterractionTypes.Accessable: 
                AccessObj(interractableObject.GetComponent<AccessableObject>());
                break;

            case InterractionTypes.Pickable:
                PickUpItem(interractableObject.GetComponent<PickAbleObject>());
                break;

            case InterractionTypes.Pressable:
                PressObj(interractableObject.GetComponent<PressableObject>());
                break;

        }

            

    }
    public void PickUpItem(PickAbleObject _pickAbleObject)
    {
        
        _playerInventory.AddPickableObj(_pickAbleObject, _pickAbleObject.gameObject);
        _pickAbleObject.GetInterracted();
        
    }
    public void AccessObj(AccessableObject _accessableObject)
    {
        bool accessApllied=false;
        foreach(PickAbleObject found in _playerInventory.myObjects.Keys)
        {
            Key keyHolder;
            
            if (found.GetComponent<Key>() != null)
            {
                keyHolder = found.GetComponent<Key>();
                if (_accessableObject.TryAccess(keyHolder.Destinbarracade))
                {
                    text.text = successText;
                    //Debug.Log("yes i got in");
                    accessApllied = true;
                    _accessableObject.GetInterracted();

                    StartCoroutine(TextEscape());

                    IEnumerator TextEscape()
                    {
                        yield return new WaitForSecondsRealtime(3);

                        text.text = emptyText;
                    }

                    break;
                }
            }
        }
        Debug.Log(accessApllied);
          
        
    }
    public void PressObj(PressableObject _pressableObject)
    {
        _pressableObject.GetInterracted();
    }

 
}
 
