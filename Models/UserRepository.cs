namespace OAuth_login_API.Models
{
    public static class UserRepository
    {
        public static List<User> Users = new List<User>
    {
        new User { Username = "player1", Password = "player", Role = "player", Regions = new List<string> { "b_game" } },
        new User { Username = "admin1", Password = "admin", Role = "admin", Regions = new List<string> { "b_game", "vip_character_personalize" } }
    };
    }

}
