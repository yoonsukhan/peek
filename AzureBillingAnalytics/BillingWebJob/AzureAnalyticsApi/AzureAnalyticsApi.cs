﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Net.Http;
using Microsoft.Rest;
using System.Configuration;

namespace BillingWebJob
{
    public partial class AzureAnalyticsApi : ServiceClient<AzureAnalyticsApi>, IAzureAnalyticsApi
    {
        private Uri _baseUri;

        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
            set { this._baseUri = value; }
        }

        private ServiceClientCredentials _credentials;

        /// <summary>
        /// Credentials for authenticating with the service.
        /// </summary>
        public ServiceClientCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        private ICspBilling _cspBilling;

        public virtual ICspBilling CspBilling
        {
            get { return this._cspBilling; }
        }

        private ICspSummary _cspSummary;

        public virtual ICspSummary CspSummary
        {
            get { return this._cspSummary; }
        }

        private ICspUsage _cspUsage;

        public virtual ICspUsage CspUsage
        {
            get { return this._cspUsage; }
        }

        private IEaBilling _eaBilling;

        public virtual IEaBilling EaBilling
        {
            get { return this._eaBilling; }
        }

        private IUserBilling _userBilling;

        public virtual IUserBilling UserBilling
        {
            get { return this._userBilling; }
        }

        /// <summary>
        /// Initializes a new instance of the AzureAnalyticsApi class.
        /// </summary>
        public AzureAnalyticsApi()
            : base()
        {
            this._cspBilling = new CspBilling(this);
            this._cspSummary = new CspSummary(this);
            this._cspUsage = new CspUsage(this);
            this._eaBilling = new EaBilling(this);
            this._userBilling = new UserBilling(this);
            this._baseUri = new Uri(ConfigurationManager.AppSettings["WebApiUrl"]);
        }

        /// <summary>
        /// Initializes a new instance of the AzureAnalyticsApi class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public AzureAnalyticsApi(params DelegatingHandler[] handlers)
            : base(handlers)
        {
            this._cspBilling = new CspBilling(this);
            this._cspSummary = new CspSummary(this);
            this._cspUsage = new CspUsage(this);
            this._eaBilling = new EaBilling(this);
            this._userBilling = new UserBilling(this);
            this._baseUri = new Uri(ConfigurationManager.AppSettings["WebApiUrl"]);
        }

        /// <summary>
        /// Initializes a new instance of the AzureAnalyticsApi class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public AzureAnalyticsApi(HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
            : base(rootHandler, handlers)
        {
            this._cspBilling = new CspBilling(this);
            this._cspSummary = new CspSummary(this);
            this._cspUsage = new CspUsage(this);
            this._eaBilling = new EaBilling(this);
            this._userBilling = new UserBilling(this);
            this._baseUri = new Uri(ConfigurationManager.AppSettings["WebApiUrl"]);
        }

        /// <summary>
        /// Initializes a new instance of the AzureAnalyticsApi class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public AzureAnalyticsApi(Uri baseUri, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._baseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the AzureAnalyticsApi class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public AzureAnalyticsApi(ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;

            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the AzureAnalyticsApi class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials for authenticating with the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The set of delegating handlers to insert in the http
        /// client pipeline.
        /// </param>
        public AzureAnalyticsApi(Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers)
            : this(handlers)
        {
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._baseUri = baseUri;
            this._credentials = credentials;

            if (this.Credentials != null)
            {
                this.Credentials.InitializeServiceClient(this);
            }
        }
    }
}