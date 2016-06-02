using System;
using Domain.Entities.Enum.Setup;

namespace Domain.Entities
{
    public class Event : BaseEntity
    {
        public DateTime EventDate { get; set; }
        public string Description { get; set; }

        public int EventTypeId { get; set; }
        public virtual EventType EventType { get; set; }

        public virtual Vacancy Vacancy { get; set; }
        public virtual Candidate Candidate { get; set; }

        public int ResponsibleId { get; set; }
        public virtual User Responsible { get; set; }
    }
}