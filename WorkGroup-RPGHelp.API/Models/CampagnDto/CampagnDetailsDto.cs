namespace WorkGroup_RPGHelp.API.Models.CampagnDto
{
    public class CampagnDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int IdGM { get; set; }
        public bool isFinish { get; set; }
    }
}
