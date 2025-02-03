/*
 * Overview Smart AI Cameras API
 *
 * This the API specifications for the OV20i Smart AI Camera produced by Overview Inc. It works with firmware versions above 2024.23.1.  Some useful links: - [Overview Documentation](https://overview.ai/support)
 *
 * The version of the OpenAPI document: 0.0.1
 * Contact: lucas.vandroux@viun.tech
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using overview_client.Model;
using overview_client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace overview_client.Test.Model
{
    /// <summary>
    ///  Class for testing CaptureClassificationResultInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CaptureClassificationResultInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CaptureClassificationResultInner
        //private CaptureClassificationResultInner instance;

        public CaptureClassificationResultInnerTests()
        {
            // TODO uncomment below to create an instance of CaptureClassificationResultInner
            //instance = new CaptureClassificationResultInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CaptureClassificationResultInner
        /// </summary>
        [Fact]
        public void CaptureClassificationResultInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" CaptureClassificationResultInner
            //Assert.IsType<CaptureClassificationResultInner>(instance);
        }

        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }

        /// <summary>
        /// Test the property 'Confidence'
        /// </summary>
        [Fact]
        public void ConfidenceTest()
        {
            // TODO unit test for the property 'Confidence'
        }

        /// <summary>
        /// Test the property 'BlockClassificationClasses'
        /// </summary>
        [Fact]
        public void BlockClassificationClassesTest()
        {
            // TODO unit test for the property 'BlockClassificationClasses'
        }

        /// <summary>
        /// Test the property 'RoiResult'
        /// </summary>
        [Fact]
        public void RoiResultTest()
        {
            // TODO unit test for the property 'RoiResult'
        }
    }
}
