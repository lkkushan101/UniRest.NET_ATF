using WebServicesFramework.ExtentReports1;
namespace WebServicesFramework.ReusableRequest
{
    class DeleteRequest
    {
        public void deleteRequest(string url)
        {
            ExtentReprts extRept = new ExtentReprts();
            unirest_net.http.HttpResponse<string> jsonResponse = unirest_net.http.Unirest.delete(url).asString();
            extRept.reportSetup("DeleteTest.html");
            extRept.createTest("Delete Test");
            extRept.logReportStatement(AventStack.ExtentReports.Status.Pass, jsonResponse.Code.ToString());
            extRept.flushReport();
        }
    }
}