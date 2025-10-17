using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour
{

    public static int Money;
    // Thêm "static" vào đây
    public static int startMoney = 1000;

    public static int Lives;
    // Thêm "static" vào đây
    public static int startLives = 10;

    public static int Rounds;

    void Start()
    {
        // Bây giờ cả hai bên đều là static, code này vẫn chạy đúng
        Money = startMoney;
        Lives = startLives;

        Rounds = 0;
    }

}