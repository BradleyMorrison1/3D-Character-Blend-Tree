using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
[RequireComponent(typeof(PlayerMovement))]

public class PlayerInput : MonoBehaviour
{

    private Player player;
    private PlayerMovement playerMovement;
   
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        player.AddMovementInput(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));

        if (Input.GetKeyDown(KeyCode.CapsLock))
        {
            player.ToggleRun();

        }
    }
}
