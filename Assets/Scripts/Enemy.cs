using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	[SerializeField] protected float speed;
	protected float startX;
	protected float startY;
	protected bool isRightDiorection;
	public Transform tr;
	public GameObject player;
	Player playerobj;

	public virtual void Move() { }

	public void SetPosition()
	{
		playerobj = player.GetComponent<Player>();
		resetXY();
		gameObject.SetActive(true);
	}

	public void resetXY()
	{
		startX = transform.position.x;
		startY = transform.position.y;
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			Debug.Log("You Looose, your Store:" + playerobj.store);
			player.SetActive(false);
		}
	}
}
