using Enums;
namespace FightClubReports.Entitys.Combat
{
    public class BlockLog
    {
        public int Id { get; set; }
        public PartOfBody hitPart { get; set; }
        public bool isSuccess { get; set; }
    }
}