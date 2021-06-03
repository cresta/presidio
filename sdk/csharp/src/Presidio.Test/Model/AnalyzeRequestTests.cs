/*
 * Presidio
 *
 * Context aware, pluggable and customizable PII anonymization service for text and images.
 *
 * The version of the OpenAPI document: 2.0
 * Contact: presidio@microsoft.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Presidio.Api;
using Presidio.Model;
using Presidio.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Presidio.Test.Model
{
    /// <summary>
    ///  Class for testing AnalyzeRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AnalyzeRequestTests : IDisposable
    {

        private AnalyzeRequest instance;

        public AnalyzeRequestTests()
        {
            var entities = new List<string>() { "test" };
            instance = new AnalyzeRequest(text:"hello world", language:"en", correlationId:"1234", scoreThreshold:0.4, entities: entities, returnDecisionProcess: false);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AnalyzeRequest
        /// </summary>
        [Fact]
        public void AnalyzeRequestInstanceTest()
        {
            Assert.IsType<AnalyzeRequest>(instance);
        }


        /// <summary>
        /// Test the property 'Text'
        /// </summary>
        [Fact]
        public void TextTest()
        {
            Assert.Equal(instance.Text, "hello world");
        }
        /// <summary>
        /// Test the property 'Language'
        /// </summary>
        [Fact]
        public void LanguageTest()
        {
            Assert.Equal(instance.Language, "en");
        }
        /// <summary>
        /// Test the property 'CorrelationId'
        /// </summary>
        [Fact]
        public void CorrelationIdTest()
        {
            Assert.Equal(instance.CorrelationId, "1234");
        }
        /// <summary>
        /// Test the property 'ScoreThreshold'
        /// </summary>
        [Fact]
        public void ScoreThresholdTest()
        {
            Assert.Equal(instance.ScoreThreshold, 0.4);
        }
        /// <summary>
        /// Test the property 'Entities'
        /// </summary>
        [Fact]
        public void EntitiesTest()
        {
            Assert.Equal(instance.Entities.Count, 1);
        }
        /// <summary>
        /// Test the property 'ReturnDecisionProcess'
        /// </summary>
        [Fact]
        public void ReturnDecisionProcessTest()
        {
            Assert.False(instance.ReturnDecisionProcess);
        }


    }

}