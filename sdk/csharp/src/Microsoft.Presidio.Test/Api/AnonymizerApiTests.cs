/*
 * Presidio
 *
 * Context aware, pluggable and customizable PII anonymization service for text and images.
 *
 * The version of the OpenAPI document: 2.0
 * Contact: presidio@microsoft.com
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

using Microsoft.Presidio.Client;
using Microsoft.Presidio.Api;
using Microsoft.Presidio.Model;

namespace Microsoft.Presidio.Test.Api
{
    /// <summary>
    ///  Class for testing AnonymizerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AnonymizerApiTests : IDisposable
    {
        private AnonymizerApi instance;

        public AnonymizerApiTests()
        {
            instance = new AnonymizerApi();
            instance.Configuration = new Configuration(null, null, null, "http://127.0.0.1:3000");
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AnonymizerApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<AnonymizerApi>(instance);
        }

        /// <summary>
        /// Test AnonymizePost
        /// </summary>
        [Fact]
        public void AnonymizePostTest()
        {
           var encrypt = new Encrypt("encrypt", "3t6w9z$C&F)J@NcR");
            var anonymizers = new Dictionary<string, Anonymizer>() {{"PERSON", new Anonymizer(encrypt)}};
            var result = new RecognizerResult(start: 11, end: 24, score: 0.9, entityType: "PERSON");
            var analyzerResults = new List<RecognizerResult>() {result};
            var originalText = "My name is Inigo Montoya, you killed my father prepare to die.";
            AnonymizeRequest body = new AnonymizeRequest(
                text: originalText, anonymizers: anonymizers,
                analyzerResults: analyzerResults);
            var response = instance.AnonymizePost(body);
            Assert.NotEqual(response.Text, originalText);
            Assert.IsType<AnonymizeResponse>(response);

        }

        /// <summary>
        /// Test AnonymizersGet
        /// </summary>
        [Fact]
        public void AnonymizersGetTest()
        {
            var response = instance.AnonymizersGet();
            Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test DeanonymizersGet
        /// </summary>
        [Fact]
        public void DeanonymizersGetTest()
        {
            var response = instance.DeanonymizersGet();
            Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test HealthGet
        /// </summary>
        [Fact]
        public void HealthGetTest()
        {
            var response = instance.HealthGet();
            Assert.IsType<string>(response);
        }
    }
}
