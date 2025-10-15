namespace WorkGroup_RPGHelp.DL.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Users> User { get; set; } = [];
    }
}
