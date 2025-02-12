/*
 * Overview Smart AI Cameras API
 *
 * This the API specifications for the OV20i Smart AI Camera produced by Overview Inc. It works with firmware versions above 2024.23.1.  Some useful links: - [Overview Documentation](https://overview.ai/support)
 *
 * The version of the OpenAPI document: 0.0.1
 * Contact: lucas.vandroux@viun.tech
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using overview_client.Client;
using overview_client.Api;
// uncomment below to import models
//using overview_client.Model;

namespace overview_client.Test.Api
{
    /// <summary>
    ///  Class for testing CaptureApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CaptureApiTests : IDisposable
    {
        private CaptureApi instance;

        public CaptureApiTests()
        {
            instance = new CaptureApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CaptureApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CaptureApi
            //Assert.IsType<CaptureApi>(instance);
        }

        /// <summary>
        /// Test GetCaptures
        /// </summary>
        [Fact]
        public void GetCapturesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //string? order = null;
            //string? select = null;
            //var response = instance.GetCaptures(limit, order, select);
            //Assert.IsType<List<Capture>>(response);
        }
    }
}
