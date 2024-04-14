using UnityEngine;

public class KeyboardMapping : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            PerformAttack();
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            Crouch();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            SummonEntity();
        }
    }

    private void PerformAttack()
    {
        animator.SetTrigger("Attack");

        hitbox.Damage();
    }

    private void Crouch()
    {
        animator.SetBool("Crouch", true);
        characterController.SetState("Hidden");
    }

    private void SummonEntity()
    {
        if (CheckInventory())
        {
            // Призыв существа, его надо дописать. Определить логику призыва с ГД и Алексея, я мертвяк.
            Entity entity = Instantiate(entityPrefab, transform.position, Quaternion.identity);

            // Прикрутить инвентарь, указать что тратится, более подробно ткнуть логику.
            inventory.UseItems();
        }
        else
        {
            // Можете придумать что выскочит на экран, пока в логи.
            Debug.Log("Not enough items in the inventory.");
        }
    }
}