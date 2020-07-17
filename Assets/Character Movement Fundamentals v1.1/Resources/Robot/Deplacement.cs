using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;


public class Deplacement : MonoBehaviour
{

    //Slope limit;
    [Range(0f, 90f)]
    [SerializeField] public float slopeLimit = 30f;

    //Collider variables;
    [Range(0f, 1f)] public float stepHeight = 0.25f;
    [SerializeField] public float colliderHeight = 2f;
    [SerializeField] public float colliderThickness = 1f;
    [SerializeField] public Vector3 colliderOffset = Vector3.zero;

    //References to attached collider(s);
    BoxCollider boxCollider;
    SphereCollider sphereCollider;
    CapsuleCollider capsuleCollider;


    BasicWalkerController controller;
    public int speed = 5;
    public int coefRot = 200;
    private Animator anim;
    


    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        
    }
    
    
    
    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()

    {


        //Déplacement
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * coefRot * Time.deltaTime);


        //Animations

        ///MARCHE
        if (Input.GetAxis("Vertical") != 0)
        {
            anim.SetBool("Walk", true);


        }
        else
        {
            anim.SetBool("Walk", false);

        }
        

        /// MARCHE + JUMP
        if ((Input.GetAxis("Vertical") > 0)) 
            if (Input.GetKeyDown(KeyCode.C))

        {
            
            anim.SetBool("Walk", false);
            anim.SetTrigger("JumpForward");


        }
        else
        {
            anim.SetBool("Walk", true);

        }



        /// JUMP SUR PLACE
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }

        
        
        /// LOOKING
        if (Input.GetButtonDown("LookingTo"))
        {
            anim.SetTrigger("LookingTo");
        }


        ///MARCHE ARRIERE
        //if (VerticalSpeed < 0)
        //{
        // anim.Trigger("Fall");

        //}





    }
}
