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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Presidio.Client;
using Presidio.Model;

namespace Presidio.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAnalyzerApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Analyze Text
        /// </summary>
        /// <remarks>
        /// Recognizes PII entities in a given text and returns their types, locations and score
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="analyzeRequest"></param>
        /// <returns>List&lt;RecognizerResultWithAnalysis&gt;</returns>
        List<RecognizerResultWithAnalysis> AnalyzePost(AnalyzeRequest analyzeRequest);

        /// <summary>
        /// Analyze Text
        /// </summary>
        /// <remarks>
        /// Recognizes PII entities in a given text and returns their types, locations and score
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="analyzeRequest"></param>
        /// <returns>ApiResponse of List&lt;RecognizerResultWithAnalysis&gt;</returns>
        ApiResponse<List<RecognizerResultWithAnalysis>> AnalyzePostWithHttpInfo(AnalyzeRequest analyzeRequest);
        /// <summary>
        /// Healthcheck
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        string HealthGet();

        /// <summary>
        /// Healthcheck
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> HealthGetWithHttpInfo();
        /// <summary>
        /// Get Recognizers
        /// </summary>
        /// <remarks>
        /// Get the available PII recognizers for a given language
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> RecognizersGet(string language = default(string));

        /// <summary>
        /// Get Recognizers
        /// </summary>
        /// <remarks>
        /// Get the available PII recognizers for a given language
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> RecognizersGetWithHttpInfo(string language = default(string));
        /// <summary>
        /// Get supported entities
        /// </summary>
        /// <remarks>
        /// Get the list of PII entities Presidio-Analyzer is capable of detecting
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        List<string> SupportedentitiesGet(string language = default(string));

        /// <summary>
        /// Get supported entities
        /// </summary>
        /// <remarks>
        /// Get the list of PII entities Presidio-Analyzer is capable of detecting
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        ApiResponse<List<string>> SupportedentitiesGetWithHttpInfo(string language = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAnalyzerApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Analyze Text
        /// </summary>
        /// <remarks>
        /// Recognizes PII entities in a given text and returns their types, locations and score
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="analyzeRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;RecognizerResultWithAnalysis&gt;</returns>
        System.Threading.Tasks.Task<List<RecognizerResultWithAnalysis>> AnalyzePostAsync(AnalyzeRequest analyzeRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Analyze Text
        /// </summary>
        /// <remarks>
        /// Recognizes PII entities in a given text and returns their types, locations and score
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="analyzeRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;RecognizerResultWithAnalysis&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<RecognizerResultWithAnalysis>>> AnalyzePostWithHttpInfoAsync(AnalyzeRequest analyzeRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Healthcheck
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> HealthGetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Healthcheck
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> HealthGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get Recognizers
        /// </summary>
        /// <remarks>
        /// Get the available PII recognizers for a given language
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> RecognizersGetAsync(string language = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Recognizers
        /// </summary>
        /// <remarks>
        /// Get the available PII recognizers for a given language
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> RecognizersGetWithHttpInfoAsync(string language = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get supported entities
        /// </summary>
        /// <remarks>
        /// Get the list of PII entities Presidio-Analyzer is capable of detecting
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        System.Threading.Tasks.Task<List<string>> SupportedentitiesGetAsync(string language = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get supported entities
        /// </summary>
        /// <remarks>
        /// Get the list of PII entities Presidio-Analyzer is capable of detecting
        /// </remarks>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<string>>> SupportedentitiesGetWithHttpInfoAsync(string language = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAnalyzerApi : IAnalyzerApiSync, IAnalyzerApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AnalyzerApi : IAnalyzerApi
    {
        private Presidio.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AnalyzerApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AnalyzerApi(String basePath)
        {
            this.Configuration = Presidio.Client.Configuration.MergeConfigurations(
                Presidio.Client.GlobalConfiguration.Instance,
                new Presidio.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Presidio.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Presidio.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Presidio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AnalyzerApi(Presidio.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Presidio.Client.Configuration.MergeConfigurations(
                Presidio.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Presidio.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Presidio.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Presidio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzerApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AnalyzerApi(Presidio.Client.ISynchronousClient client, Presidio.Client.IAsynchronousClient asyncClient, Presidio.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Presidio.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Presidio.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Presidio.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Presidio.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Presidio.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Analyze Text Recognizes PII entities in a given text and returns their types, locations and score
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="analyzeRequest"></param>
        /// <returns>List&lt;RecognizerResultWithAnalysis&gt;</returns>
        public List<RecognizerResultWithAnalysis> AnalyzePost(AnalyzeRequest analyzeRequest)
        {
            Presidio.Client.ApiResponse<List<RecognizerResultWithAnalysis>> localVarResponse = AnalyzePostWithHttpInfo(analyzeRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Analyze Text Recognizes PII entities in a given text and returns their types, locations and score
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="analyzeRequest"></param>
        /// <returns>ApiResponse of List&lt;RecognizerResultWithAnalysis&gt;</returns>
        public Presidio.Client.ApiResponse<List<RecognizerResultWithAnalysis>> AnalyzePostWithHttpInfo(AnalyzeRequest analyzeRequest)
        {
            // verify the required parameter 'analyzeRequest' is set
            if (analyzeRequest == null)
                throw new Presidio.Client.ApiException(400, "Missing required parameter 'analyzeRequest' when calling AnalyzerApi->AnalyzePost");

            Presidio.Client.RequestOptions localVarRequestOptions = new Presidio.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Presidio.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Presidio.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = analyzeRequest;


            // make the HTTP request
            var localVarResponse = this.Client.Post<List<RecognizerResultWithAnalysis>>("/analyze", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AnalyzePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Analyze Text Recognizes PII entities in a given text and returns their types, locations and score
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="analyzeRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;RecognizerResultWithAnalysis&gt;</returns>
        public async System.Threading.Tasks.Task<List<RecognizerResultWithAnalysis>> AnalyzePostAsync(AnalyzeRequest analyzeRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Presidio.Client.ApiResponse<List<RecognizerResultWithAnalysis>> localVarResponse = await AnalyzePostWithHttpInfoAsync(analyzeRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Analyze Text Recognizes PII entities in a given text and returns their types, locations and score
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="analyzeRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;RecognizerResultWithAnalysis&gt;)</returns>
        public async System.Threading.Tasks.Task<Presidio.Client.ApiResponse<List<RecognizerResultWithAnalysis>>> AnalyzePostWithHttpInfoAsync(AnalyzeRequest analyzeRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'analyzeRequest' is set
            if (analyzeRequest == null)
                throw new Presidio.Client.ApiException(400, "Missing required parameter 'analyzeRequest' when calling AnalyzerApi->AnalyzePost");


            Presidio.Client.RequestOptions localVarRequestOptions = new Presidio.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Presidio.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Presidio.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = analyzeRequest;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<List<RecognizerResultWithAnalysis>>("/analyze", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AnalyzePost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Healthcheck 
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>string</returns>
        public string HealthGet()
        {
            Presidio.Client.ApiResponse<string> localVarResponse = HealthGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Healthcheck 
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of string</returns>
        public Presidio.Client.ApiResponse<string> HealthGetWithHttpInfo()
        {
            Presidio.Client.RequestOptions localVarRequestOptions = new Presidio.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain"
            };

            var localVarContentType = Presidio.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Presidio.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get<string>("/health", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HealthGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Healthcheck 
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> HealthGetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Presidio.Client.ApiResponse<string> localVarResponse = await HealthGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Healthcheck 
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<Presidio.Client.ApiResponse<string>> HealthGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Presidio.Client.RequestOptions localVarRequestOptions = new Presidio.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain"
            };


            var localVarContentType = Presidio.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Presidio.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<string>("/health", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("HealthGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Recognizers Get the available PII recognizers for a given language
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> RecognizersGet(string language = default(string))
        {
            Presidio.Client.ApiResponse<List<string>> localVarResponse = RecognizersGetWithHttpInfo(language);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Recognizers Get the available PII recognizers for a given language
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public Presidio.Client.ApiResponse<List<string>> RecognizersGetWithHttpInfo(string language = default(string))
        {
            Presidio.Client.RequestOptions localVarRequestOptions = new Presidio.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Presidio.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Presidio.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (language != null)
            {
                localVarRequestOptions.QueryParameters.Add(Presidio.Client.ClientUtils.ParameterToMultiMap("", "language", language));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<string>>("/recognizers", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RecognizersGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Recognizers Get the available PII recognizers for a given language
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> RecognizersGetAsync(string language = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Presidio.Client.ApiResponse<List<string>> localVarResponse = await RecognizersGetWithHttpInfoAsync(language, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Recognizers Get the available PII recognizers for a given language
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<Presidio.Client.ApiResponse<List<string>>> RecognizersGetWithHttpInfoAsync(string language = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Presidio.Client.RequestOptions localVarRequestOptions = new Presidio.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Presidio.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Presidio.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (language != null)
            {
                localVarRequestOptions.QueryParameters.Add(Presidio.Client.ClientUtils.ParameterToMultiMap("", "language", language));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<string>>("/recognizers", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RecognizersGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get supported entities Get the list of PII entities Presidio-Analyzer is capable of detecting
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <returns>List&lt;string&gt;</returns>
        public List<string> SupportedentitiesGet(string language = default(string))
        {
            Presidio.Client.ApiResponse<List<string>> localVarResponse = SupportedentitiesGetWithHttpInfo(language);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get supported entities Get the list of PII entities Presidio-Analyzer is capable of detecting
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <returns>ApiResponse of List&lt;string&gt;</returns>
        public Presidio.Client.ApiResponse<List<string>> SupportedentitiesGetWithHttpInfo(string language = default(string))
        {
            Presidio.Client.RequestOptions localVarRequestOptions = new Presidio.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Presidio.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Presidio.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (language != null)
            {
                localVarRequestOptions.QueryParameters.Add(Presidio.Client.ClientUtils.ParameterToMultiMap("", "language", language));
            }


            // make the HTTP request
            var localVarResponse = this.Client.Get<List<string>>("/supportedentities", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SupportedentitiesGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get supported entities Get the list of PII entities Presidio-Analyzer is capable of detecting
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of List&lt;string&gt;</returns>
        public async System.Threading.Tasks.Task<List<string>> SupportedentitiesGetAsync(string language = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Presidio.Client.ApiResponse<List<string>> localVarResponse = await SupportedentitiesGetWithHttpInfoAsync(language, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get supported entities Get the list of PII entities Presidio-Analyzer is capable of detecting
        /// </summary>
        /// <exception cref="Presidio.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">Two characters for the desired language in ISO_639-1 format (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (List&lt;string&gt;)</returns>
        public async System.Threading.Tasks.Task<Presidio.Client.ApiResponse<List<string>>> SupportedentitiesGetWithHttpInfoAsync(string language = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Presidio.Client.RequestOptions localVarRequestOptions = new Presidio.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Presidio.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Presidio.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (language != null)
            {
                localVarRequestOptions.QueryParameters.Add(Presidio.Client.ClientUtils.ParameterToMultiMap("", "language", language));
            }


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<List<string>>("/supportedentities", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SupportedentitiesGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}