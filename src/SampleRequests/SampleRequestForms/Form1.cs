using System;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SampleRequestForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var body = new BimRequest();
            body.token = "50cefff41e589d0d6eb525006ece49d1c998b221f027d5faa58eb8f0126baea5e672d66656f077f44302590aedc630b7";
            var par = new Parameters() { name = "Connect020_V3" };
            var request = new Request() { @interface = "ServiceInterface", method = "getProjectsByName", parameters = par };
            body.request = request;
            var json = JsonConvert.SerializeObject(body);
            var s = new StringContent(json);

            var result = await httpClient.PostAsync("http://localhost:8082/json", s);
            string resp = result.Content.ReadAsStringAsync().Result;
            var bimResponse = JsonConvert.DeserializeObject<BimResponse>(resp);
            button1.Text = bimResponse.response.result[0].__type;

        }
    }
}
