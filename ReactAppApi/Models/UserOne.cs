namespace ReactAppApi.Models
{
    public sealed class UserOne
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Settings> Settings { get; set; }
    }
    public sealed class Settings
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public List<string> Others { get; set; }
    }
}
