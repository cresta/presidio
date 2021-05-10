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
using Microsoft.Presidio.Api;
using Microsoft.Presidio.Model;
using Microsoft.Presidio.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Microsoft.Presidio.Test.Model
{
    /// <summary>
    ///  Class for testing AnalysisExplanation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AnalysisExplanationTests : IDisposable
    {
        private AnalysisExplanation instance;

        public AnalysisExplanationTests()
        {
            instance = new AnalysisExplanation(recognizer:"recognizer", patternName:"patternName", pattern: "pattern",
                originalScore:0.5, score:0.4, textualExplanation: "explanation", scoreContextImprovement:0.2, supportiveContextWord:"word",
                validationResult:0.1);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AnalysisExplanation
        /// </summary>
        [Fact]
        public void AnalysisExplanationInstanceTest()
        {
            Assert.IsType<AnalysisExplanation>(instance);
        }


        /// <summary>
        /// Test the property 'Recognizer'
        /// </summary>
        [Fact]
        public void RecognizerTest()
        {
             Assert.Equal(instance.Recognizer, "recognizer");
        }
        /// <summary>
        /// Test the property 'PatternName'
        /// </summary>
        [Fact]
        public void PatternNameTest()
        {
            Assert.Equal(instance.PatternName, "patternName");
        }
        /// <summary>
        /// Test the property 'Pattern'
        /// </summary>
        [Fact]
        public void PatternTest()
        {
            Assert.Equal(instance.Pattern, "pattern");
        }
        /// <summary>
        /// Test the property 'OriginalScore'
        /// </summary>
        [Fact]
        public void OriginalScoreTest()
        {
            Assert.Equal(instance.OriginalScore, 0.5);
        }
        /// <summary>
        /// Test the property 'Score'
        /// </summary>
        [Fact]
        public void ScoreTest()
        {
            Assert.Equal(instance.Score, 0.4);
        }
        /// <summary>
        /// Test the property 'TextualExplanation'
        /// </summary>
        [Fact]
        public void TextualExplanationTest()
        {
            Assert.Equal(instance.TextualExplanation, "explanation");
        }
        /// <summary>
        /// Test the property 'ScoreContextImprovement'
        /// </summary>
        [Fact]
        public void ScoreContextImprovementTest()
        {
            Assert.Equal(instance.ScoreContextImprovement, 0.2);
        }
        /// <summary>
        /// Test the property 'SupportiveContextWord'
        /// </summary>
        [Fact]
        public void SupportiveContextWordTest()
        {
            Assert.Equal(instance.SupportiveContextWord, "word");
        }
        /// <summary>
        /// Test the property 'ValidationResult'
        /// </summary>
        [Fact]
        public void ValidationResultTest()
        {
            Assert.Equal(instance.ValidationResult, 0.1);
        }

    }

}
