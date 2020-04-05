using WebServicesFramework.ExtentReports1;
namespace WebServicesFramework.ReusableRequest
{
    class PutRequest
    {
        public void putRequest(string url, object body)
        {
            ExtentReprts extRept = new ExtentReprts();
            unirest_net.http.HttpResponse<string> response = unirest_net.http.Unirest.put(url).body(body).asString();
            extRept.reportSetup("PutTest.html");
            extRept.createTest("Put Test");
            extRept.logReportStatement(AventStack.ExtentReports.Status.Pass, response.Body.ToString());
            extRept.flushReport();
        }
    }
}