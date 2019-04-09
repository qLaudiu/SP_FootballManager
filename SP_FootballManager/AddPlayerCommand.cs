using System;
using System.Text;

namespace SP_FootballManager
{
    public class AddPlayerCommand : RequestCommand<bool>
    {

        private Player _player;

        public AddPlayerCommand(Player player)
        {
            this._player = player;
        }

        public override bool execute()
        {
            CreateFileIfNeeded(PLAYER_JSON_FILE);
            if(IsFileAvailalble(PLAYER_JSON_FILE) && _player != null)
            {
                var json = SerializeObject(_player);
                string db = GetTextFromFile(PLAYER_JSON_FILE);
                var builder = new StringBuilder();

                if (String.IsNullOrEmpty(db))
                {
                    builder.Append("[");
                    builder.Append("\n");
                    builder.Append(json);
                    builder.Append("\n");
                    builder.Append("]");
                }
                else
                {
                    for (int i = 0; i < db.Length; i++)
                    {
                        var s = db[i];
                        if (i == db.Length - 2)
                        {
                            builder.Append(",");
                            builder.Append("\n");
                            builder.Append(json);
                        }
                        builder.Append(s);
                    }
                }
                WriteToFile(PLAYER_JSON_FILE, builder.ToString());
                return true;
            }
            return false;
        }
    }
}
