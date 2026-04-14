using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToffeeTavern.Models
{
    [Table("Q_QUEST")]
    public class Quest
    {
        [Key]
        [Column("Q_ID")]
        public int Id { get; set; }

        [Column("Q_C_ID")]
        public int CharacterId { get; set; }

        [Column("Q_TITLE")]
        public string Title { get; set; }

        [Column("Q_DESCRIPTION")]
        public string Description { get; set; }

        [Column("Q_QUEST_GIVER")]
        public string QuestGiver { get; set; }

        [Column("Q_LOCATION")]
        public string Location { get; set; }

        [Column("Q_PRIORITY")]
        public Priority Priority { get; set; }

        [Column("Q_TYPE")]
        public QuestType Type { get; set; }

        [Column("Q_STATUS")]
        public QuestStatus Status { get; set; }
    }

    public enum Priority
    {
        LOW,
        MEDIUM,
        HIGH
    }

    public enum QuestType
    {
        PERSONAL,
        PARTY
    }

    public enum QuestStatus
    {
        NOT_STARTED,
        IN_PROGRESS,
        COMPLETED,
        FAILED
    }
}
