using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
	[SerializeField] protected float speed;
	protected float startX;
	protected float startY;
	protected bool isRightDiorection;
	public BoxCollider2D bc;
	public GameObject player;
	public Transform tr;

	public virtual void Move() { }

	public void SetPosition()
	{
		resetXY();
		gameObject.SetActive(true);
	}

	public void resetXY()
	{
		startX = transform.position.x;
		startY = transform.position.y;
	}


	private void Update()
	{
		if((player.transform.position.y - 2) > tr.position.y)
		{
			bc.isTrigger = false;
		}
		else if (player.transform.position.y <= tr.position.y)
		{
			bc.isTrigger = true;
		}
	}
}
