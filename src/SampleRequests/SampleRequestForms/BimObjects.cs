namespace SampleRequestForms
{


    public class BimResponse
    {
        public Response response { get; set; }
    }

    public class Response
    {
        public Result[] result { get; set; }
    }

    public class Result
    {
        public string __type { get; set; }
        public int checkinInProgress { get; set; }
        public object[] checkouts { get; set; }
        public int[] concreteRevisions { get; set; }
        public int createdById { get; set; }
        public long createdDate { get; set; }
        public string description { get; set; }
        public string exportLengthMeasurePrefix { get; set; }
        public int[] extendedData { get; set; }
        public int geoTagId { get; set; }
        public int[] hasAuthorizedUsers { get; set; }
        public int id { get; set; }
        public int lastConcreteRevisionId { get; set; }
        public int lastRevisionId { get; set; }
        public int[] logs { get; set; }
        public int[] modelCheckers { get; set; }
        public string name { get; set; }
        public object[] newServices { get; set; }
        public int oid { get; set; }
        public int parentId { get; set; }
        public int[] revisions { get; set; }
        public int rid { get; set; }
        public string schema { get; set; }
        public bool sendEmailOnNewRevision { get; set; }
        public object[] services { get; set; }
        public string state { get; set; }
        public object[] subProjects { get; set; }
        public string uuid { get; set; }
    }


    public class BimRequest
    {
        public string token { get; set; }
        public Request request { get; set; }
    }

    public class Request
    {
        public string @interface { get; set; }
        public string method { get; set; }
        public Parameters parameters { get; set; }
    }

    public class Parameters
    {
        public string name { get; set; }
    }
}
