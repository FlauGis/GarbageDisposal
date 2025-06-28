using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
    public Transform target; // Точка B
    public float speed = 5f; // Швидкість руху

    private bool isMoving = true;

    void Update()
    {
        if (isMoving)
        {
            // Обчислюємо відстань до цілі
            float step = speed * Time.deltaTime; // Відстань, яку об'єкт переміститься за один кадр
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            // Лог повідомлення для відлагодження
            Debug.Log("Рух до точки: " + target.position);
            Debug.Log("Поточна позиція: " + transform.position);

            // Перевіряємо, чи досяг об'єкт точки
            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                isMoving = false; // Зупиняємо рух
                Debug.Log("Досягнуто точки: " + target.position);
            }
        }
    }
}
