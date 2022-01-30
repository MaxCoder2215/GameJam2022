using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Newtonsoft.Json;

public class GameStateManger : MonoBehaviour
{
    /// <summary>
    /// Singleton of the game state manager
    /// </summary>
    public static GameStateManger Instance { get; private set; }

    public UnityEvent<GameStates, GameStates> OnStateTranistion = new UnityEvent<GameStates, GameStates>();

    public GameStates State { get; private set; }

    public Animator[] Curtains;

    // Start is called before the first frame update
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            GameObject.Destroy(this.gameObject);
        }

        Stats testState = new Stats(10, 10, 10, 10, 10, 10, 10);
        Stats statsTwo = new Stats(10, 10, 10, 10, 10, 10, 10);
        Item item = new Item(statsTwo, testState, "avg", "give me avg everything", "", 5, false, 5);

        Stats person = new Stats(10, 10, 10, 10, 10, 10, 10);
        List<Item> items = new List<Item>();
        items.Add(item);
        Entity entity = new Entity("bob",0,person, items);

        Debug.Log(JsonConvert.SerializeObject(entity));
    }

    public void ReadyForNextState()
    {
        GameStates prev = State;
        State = (GameStates)(((int)State + 1) % 3);
    }

    private void StateTranision(GameStates prev, GameStates current)
    {
        OnStateTranistion.Invoke(prev, current);
        foreach (Animator cur in Curtains)
        {
            cur.SetBool("open", true);
        }

    }

    public enum GameStates{
        MAINMENU = 1,
        SHOP = 2,
        GO = 3
    }
}
