namespace tracking.client
{
    internal class IssueDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priorities { get; set; }
        public IssueType IssueTypes { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }

        public enum Priority
        {
            Low, Medium, High
        }

        public enum IssueType
        {
            Feature, Bug, Documentation
        }
    }
}
 