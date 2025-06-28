using UnityEngine;

public class MoveToPoint : MonoBehaviour
{
    public Transform target; // ����� B
    public float speed = 5f; // �������� ����

    private bool isMoving = true;

    void Update()
    {
        if (isMoving)
        {
            // ���������� ������� �� ���
            float step = speed * Time.deltaTime; // ³������, ��� ��'��� ������������ �� ���� ����
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

            // ��� ����������� ��� ������������
            Debug.Log("��� �� �����: " + target.position);
            Debug.Log("������� �������: " + transform.position);

            // ����������, �� ����� ��'��� �����
            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                isMoving = false; // ��������� ���
                Debug.Log("��������� �����: " + target.position);
            }
        }
    }
}
