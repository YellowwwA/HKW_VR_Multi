using Normal.Realtime;
using TMPro;

public class AvatarAttributesSync : RealtimeComponent<AvatarAttributesModel>
{
  public TextMeshProUGUI playerNameText;

  private string playerName;

  private static string[] adjectives = new string[] {"Player"};

  private static string[] nouns = new string[] { " Nick", " Judy", " Hansel", " Gretel"};

  private bool _isSelf;

  public int i = 0;

  public string Nickname => model.nickname;

  private void Start()
  {
    if (GetComponent<RealtimeAvatar>().isOwnedLocallyInHierarchy)
    {
      _isSelf = true;

      // Generate a funny random name
      playerName = adjectives[UnityEngine.Random.Range(0, adjectives.Length)] + " " + nouns[UnityEngine.Random.Range(0, nouns.Length)];
      i++;

      // Assign the nickname to the model which will automatically be sent to the server and broadcast to other clients
      model.nickname = playerName;

      // We don't need to see our own nickname
      playerNameText.enabled = false;
    }
  }

  protected override void OnRealtimeModelReplaced(AvatarAttributesModel previousModel, AvatarAttributesModel currentModel)
  {
    if (previousModel != null)
    {
      // Unregister from events
      previousModel.nicknameDidChange -= NicknameDidChange;
    }

    if (currentModel != null)
    {
      if (currentModel.isFreshModel)
      {
        currentModel.nickname = "";
      }

      UpdatePlayerName();

      currentModel.nicknameDidChange += NicknameDidChange;
    }
  }

  private void NicknameDidChange(AvatarAttributesModel model, string nickname)
  {
    UpdatePlayerName();
  }

  private void UpdatePlayerName()
  {
    // Update the UI
    playerNameText.text = model.nickname;
  }
}