namespace BorderControl
{
    public class Robot : IIdentitiable
    {
        private string id;
        private string model;
        public Robot(string model, string id)
        {
            this.Model = model;
            this.ID = id;
        }
        public string ID
        {
            get => id;
            private set => id = value;
        }
        public string Model
        {
            get => model;
            private set => model = value;
        }
    }
}
