using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb2d;
    private Vector2 moveInput;

    [SerializeField] private DialogueUI dialogueUI;

    public DialogueUI DialogueUI => dialogueUI;

    public IInteractable Interactable { get; set; }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        // Movement
        moveInput.x = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        moveInput.y = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        moveInput.Normalize();

        rb2d.velocity = moveInput * moveSpeed;

        //Dialogue
        if (dialogueUI.IsOpen) return;
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        rb2d.MovePosition(rb2d.position + input.normalized * (moveSpeed * Time.fixedDeltaTime * 4));

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Interactable != null)
            {
                Interactable.Interact(player: this);
            }
        }
    }
}