using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class RigidbodyCharacter : MonoBehaviour
{

	public float Speed = 5f;
	public float JumpHeight = 2f;
	public float GroundDistance = 0.2f;
	public float DashDistance = 5f;
	public LayerMask Ground;

	public Rigidbody _body;
	private Vector3 _inputs = Vector3.zero;
	public bool _isGrounded = true;
	public Transform _groundChecker;

    public bool isClimbing = false;

    public bool IsInputEnabled = true;

    public GameObject climbableObj;

    bool isPlayingAudio = false;
    public AudioSource UniversalAudioSource;
    public AudioClip walkClip;

	void Start()
	{
		_body = GetComponent<Rigidbody>();
		
	}

	void Update()
	{
        

        //print("Climbing: " + isClimbing);
        if (!IsInputEnabled)
        {
            return;
        }

        _isGrounded = Physics.CheckSphere(_groundChecker.position, GroundDistance, Ground, QueryTriggerInteraction.Ignore);
        //_isGrounded = _groundChecker.GetComponent<NavMeshAgent>().isOnNavMesh;
        //print(_groundChecker.GetComponent<NavMeshAgent>().isOnNavMesh);

		_inputs = Vector3.zero;
        _inputs.x = Input.GetAxis("Horizontal");
		_inputs.z = Input.GetAxis("Vertical");
		if (_inputs != Vector3.zero)
		{
            if (_isGrounded) {
                if (!isPlayingAudio)
                {
                    UniversalAudioSource.PlayOneShot(walkClip);
                    isPlayingAudio = true;
                    Invoke("ToggleWalkSound", 0.4f);

                }
            }



            transform.forward = _inputs;
		}
		if (Input.GetButtonDown("Jump") && _isGrounded)
		{
			_body.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange);
		}
        //if (Input.GetButtonDown("Dash"))
        //{
        //	Vector3 dashVelocity = Vector3.Scale(transform.forward, DashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * _body.drag + 1)) / -Time.deltaTime), 0, (Mathf.Log(1f / (Time.deltaTime * _body.drag + 1)) / -Time.deltaTime)));
        //	_body.AddForce(dashVelocity, ForceMode.VelocityChange);
        //}

        if (isClimbing)
        {
            Vector3 targetPosition = new Vector3(climbableObj.transform.position.x, transform.position.y, climbableObj.transform.position.z);
            transform.LookAt(targetPosition);
        }

    }


    void FixedUpdate()
	{
		_body.MovePosition(_body.position + _inputs * Speed * Time.fixedDeltaTime);
	}


    void ToggleWalkSound()
    {
        isPlayingAudio = false;
    }
}
