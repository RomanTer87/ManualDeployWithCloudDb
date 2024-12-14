namespace ManualDeployWithCloudDb
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Abbreviated { get; set; } = string.Empty;

        public Country() { }
    }
}
