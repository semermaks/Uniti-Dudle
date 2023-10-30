using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyX : Enemy
{
	public override void Move()
	{
		if (isRightDiorection)
		{
			tr.Translate(Vector2.right * speed * Time.deltaTime);
		}
		else if (!isRightDiorection)
		{
			tr.Translate(Vector2.left * speed * Time.deltaTime);
		}
		if (transform.position.x > startX + 4 || transform.position.x < startX - 4)
		{
			isRightDiorection = !isRightDiorection;
		}
	}
}
