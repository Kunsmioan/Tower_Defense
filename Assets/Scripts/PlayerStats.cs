using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour {

	public static int Money;
	public int startMoney = 400;

	public static int Lives;
	public int startLives = 10;

	public static int Rounds;

	void Start ()
	{
		// tiền bắt đầu
		Money = startMoney;
		Lives = startLives;

		Rounds = 0;
	}

}
