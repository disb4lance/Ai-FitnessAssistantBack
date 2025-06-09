using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ai_FitnessAssistant.Infrastructure.Models
{
    [Table("workout_sessions")]
    public class WorkoutSession
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("exercise_type")]
        public string ExerciseType { get; set; } = string.Empty;

        [Column("sets")]
        public int Sets { get; set; }

        [Column("reps_per_set")]
        public int RepsPerSet { get; set; }

        [Column("weight")]
        public float Weight { get; set; }

        [Column("mood")]
        public int Mood { get; set; }  // Оценка настроения 1-10

        [Column("sleep_hours")]
        public float SleepHours { get; set; }

        [Column("is_effective")]
        public bool? IsEffective { get; set; }
    }
}
