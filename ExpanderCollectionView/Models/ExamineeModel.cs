using CommunityToolkit.Mvvm.ComponentModel;

namespace ExpanderCollectionView.Models
{
    public partial class ExamineeModel : ObservableObject
    {
        [ObservableProperty]
        private string username = string.Empty;

        [ObservableProperty]
        private string name = string.Empty;

        [ObservableProperty]
        private string groupName = string.Empty;

        [ObservableProperty]
        private double progress = 0;
    }

    public class ExamineeGenerator
    {
        private static readonly List<string> FirstNames =
        [
            "James", "Mary", "John", "Patricia", "Robert",
        ];

        private static readonly List<string> LastNames =
        [
            "Smith", "Johnson", "Williams", "Brown", "Jones",
        ];

        private static readonly List<string> GroupNames =
        [
            "Group A", "Group B", "Group C", "Group D", "Group E",
        ];

        private static readonly Random Random = new();

        public static List<ExamineeModel> GenerateExaminees(int count)
        {
            var examinees = new List<ExamineeModel>();

            for (int i = 0; i < count; i++)
            {
                var firstName = FirstNames[Random.Next(FirstNames.Count)];
                var lastName = LastNames[Random.Next(LastNames.Count)];
                var groupName = GroupNames[Random.Next(GroupNames.Count)];
                var progress = Random.NextDouble() * 100;

                var examinee = new ExamineeModel
                {
                    Username = $"{firstName}.{lastName}".ToLower(),
                    Name = $"{firstName} {lastName}",
                    GroupName = groupName,
                    Progress = Math.Round(progress, 2)
                };

                examinees.Add(examinee);
            }

            return examinees;
        }
    }
}