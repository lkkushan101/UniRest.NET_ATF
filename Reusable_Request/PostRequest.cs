using WebServicesFramework.ExtentReports1;
namespace WebServicesFramework.ReusableRequest
{
    class PostRequest
    {
        public void postRequest(string url, object body_content)
        {
            unirest_net.http.HttpResponse<string> response = unirest_net.http.Unirest.post(url).body(body_content).asString();

            ExtentReprts extRept = new ExtentReprts();

            extRept.reportSetup("PostTest.html");
            extRept.createTest("Post Test");
            extRept.logReportStatement(AventStack.ExtentReports.Status.Pass, response.Body.ToString());
            extRept.flushReport();
        }
    }

}