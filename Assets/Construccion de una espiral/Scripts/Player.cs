using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
	public static Player player;
	public PipiSystem pipiSystem;
	private Pipe currentPipe;
	public float velocity;
	internal float distanceTraveled;
	private float deltaRotation;
	private float systemRotation;
	private Transform world, rotater;
	private float worldRotation, avatarRotation;
	public float rotationVelocity;
	public float speedPlayer;

	void Awake()
	{
		if(!player)
		{
			player = this;
		}else
		{
			Destroy(this);
		}
	}
	private void Start()
	{
		world = pipiSystem.transform.parent;
		rotater = transform.GetChild(0);
		currentPipe = pipiSystem.SetupFirstPipe();
		SetupCurrentPipe(); 
	}
	private void Update()
	{
		float delta = velocity * Time.deltaTime;
		distanceTraveled += delta;
		systemRotation += delta * deltaRotation;

		if(systemRotation >= currentPipe.CurveAngle)
		{
			delta = (systemRotation - currentPipe.CurveAngle) / deltaRotation;
			currentPipe  = pipiSystem.SetupNextPipe();
			SetupCurrentPipe();
			systemRotation = delta * deltaRotation;
		}
		pipiSystem.transform.localRotation = 
			Quaternion.Euler(0f,0f,systemRotation);

		UpdateAvatarRotation(speedPlayer);
	}

	private void SetupCurrentPipe()
	{
		deltaRotation = 360f / (2f * Mathf.PI * currentPipe.CurveRadius);
		worldRotation += currentPipe.RelativeRotation;
		if(worldRotation < 0f)
		{
			worldRotation += 360f;
		}
		else if(worldRotation >= 360f)
		{
			worldRotation -=360f;
		}
		world.localRotation = Quaternion.Euler(worldRotation, 0f,0f);
	}

	private void UpdateAvatarRotation(float speedPlayer)
	{
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(Vector3.left * speedPlayer * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(-Vector3.right * -speedPlayer * Time.deltaTime);
		}
		

		// float moveHorizontal = Input.GetAxisRaw("Horizontal") * speedPlayer;
		// moveHorizontal *= Time.deltaTime;
		// transform.Translate(moveHorizontal,0f,0f);

		// avatarRotation += rotationVelocity * Time.deltaTime * Input.GetAxis("Horizontal");

		// 	if(avatarRotation < 0f)
		// 	{
		// 		avatarRotation += 360f;
		// 	}
		// 	else if(avatarRotation >= 360f)
		// 	{
		// 		avatarRotation -= 360f;
		// 	}
		// 	rotater.localRotation = Quaternion.Euler(avatarRotation, 0f,0f);
	}

}
