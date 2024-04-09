namespace HubSpot.NET.Core.OAuth
{
    using RestSharp;
    using RestSharp.Serializers;

    internal class FakeSerializer : IRestSerializer
    {
        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }
        public ContentType ContentType { get; set; }

        public ISerializer Serializer => throw new System.NotImplementedException();

        public IDeserializer Deserializer => throw new System.NotImplementedException();

        public string[] AcceptedContentTypes => throw new System.NotImplementedException();

        public SupportsContentType SupportsContentType => throw new System.NotImplementedException();

        public DataFormat DataFormat => throw new System.NotImplementedException();

        internal FakeSerializer()
        {
            ContentType = "application/x-www-form-urlencoded";
        }
        public string Serialize(object obj)
        {
            return obj.ToString();
        }

        public string Serialize(Parameter parameter)
        {
            throw new System.NotImplementedException();
        }
    }
}