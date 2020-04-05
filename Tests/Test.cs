﻿using System;
using NUnit.Framework;
using WebServicesFramework.ReusableRequest;
using WebServicesFramework.JSONReader;
public class GetTest
{
    [Test]

    public void testGet()
    {
        JSONReaderFile jsonRead = new JSONReaderFile();
        GetRequest reqGet = new GetRequest();
        reqGet.getRequest(jsonRead.jsonReader("Data.json", "Request_Get"));
        PostRequest reqPost = new PostRequest();
        reqPost.postRequest(jsonRead.jsonReader("Data.json", "Request_Post"), " { email : " + jsonRead.jsonReader("Data.json", "email") + ", password :" + jsonRead.jsonReader("Data.json", "password") + "}");
        DeleteRequest reqDelete = new DeleteRequest();
        reqDelete.deleteRequest(jsonRead.jsonReader("Data.json", "Request_Delete"));
    }


}