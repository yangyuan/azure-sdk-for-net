﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary>
    /// Model Settings client that can be used to perform operations for Time Series Model configuration settings.
    /// </summary>
    public class ModelSettingsClient
    {
        private readonly ModelSettingsRestClient _modelSettingsRestClient;
        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary>
        /// Initializes a new instance of ModelSettings. This constructor should only be used for mocking purposes.
        /// </summary>
        protected ModelSettingsClient()
        {
        }

        internal ModelSettingsClient(ModelSettingsRestClient modelSettingsRestClient, ClientDiagnostics clientDiagnostics)
        {
            Argument.AssertNotNull(modelSettingsRestClient, nameof(modelSettingsRestClient));
            Argument.AssertNotNull(clientDiagnostics, nameof(clientDiagnostics));

            _modelSettingsRestClient = modelSettingsRestClient;
            _clientDiagnostics = clientDiagnostics;
        }

        /// <summary>
        /// Gets Time Series model settings asynchronously.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// The model settings which includes model display name, Time Series Id properties and default type Id with the
        /// http response <see cref="Response{TimeSeriesModelSettings}"/>.
        /// </returns>
        public virtual async Task<Response<TimeSeriesModelSettings>> GetModelSettingsAsync(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(GetModelSettings)}");
            scope.Start();
            try
            {
                // To do: Generate client session Id
                Response<ModelSettingsResponse> modelSettings = await _modelSettingsRestClient.GetAsync(null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(modelSettings.Value.ModelSettings, modelSettings.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Gets Time Series model settings synchronously.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>
        /// The model settings which includes model display name, Time Series Id properties and default type Id with the
        /// http response <see cref="Response{TimeSeriesModelSettings}"/>.
        /// </returns>
        public virtual Response<TimeSeriesModelSettings> GetModelSettings(CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(GetModelSettings)}");
            scope.Start();
            try
            {
                // To do: Generate client session Id
                Response<ModelSettingsResponse> modelSettings = _modelSettingsRestClient.Get(null, cancellationToken);
                return Response.FromValue(modelSettings.Value.ModelSettings, modelSettings.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Updates model name on Time Series model settings asynchronously.
        /// </summary>
        /// <param name="name">Model display name which is mutable by the user. Initial value is &quot;DefaultModel&quot;.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The updated model settings with the http response <see cref="Response{TimeSeriesModelSettings}"/>.</returns>
        public virtual async Task<Response<TimeSeriesModelSettings>> UpdateModelSettingsNameAsync(string name, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(UpdateModelSettingsName)}");
            scope.Start();
            try
            {
                // To do: Generate client session Id
                var options = new UpdateModelSettingsRequest { Name = name };
                Response<ModelSettingsResponse> modelSettings = await _modelSettingsRestClient.UpdateAsync(options, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(modelSettings.Value.ModelSettings, modelSettings.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Updates model default type Id on Time Series model settings asynchronously.
        /// </summary>
        /// <param name="defaultTypeId">Default type Id of the model that new instances will automatically belong to.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The updated model settings with the http response <see cref="Response{TimeSeriesModelSettings}"/>.</returns>
        public virtual async Task<Response<TimeSeriesModelSettings>> UpdateModelSettingsDefaultTypeIdAsync(string defaultTypeId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(UpdateModelSettingsDefaultTypeId)}");
            scope.Start();
            try
            {
                // To do: Generate client session Id
                var options = new UpdateModelSettingsRequest { DefaultTypeId = defaultTypeId };
                Response<ModelSettingsResponse> modelSettings = await _modelSettingsRestClient.UpdateAsync(options, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(modelSettings.Value.ModelSettings, modelSettings.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Updates model name on Time Series model settings synchronously.
        /// </summary>
        /// <param name="name">Model display name which is mutable by the user. Initial value is &quot;DefaultModel&quot;.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The updated model settings with the http response <see cref="Response{TimeSeriesModelSettings}"/>.</returns>
        public virtual Response<TimeSeriesModelSettings> UpdateModelSettingsName(string name, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(UpdateModelSettingsName)}");
            scope.Start();
            try
            {
                // To do: Generate client session Id
                var options = new UpdateModelSettingsRequest { Name = name };
                Response<ModelSettingsResponse> modelSettings = _modelSettingsRestClient.Update(options, null, cancellationToken);
                return Response.FromValue(modelSettings.Value.ModelSettings, modelSettings.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }

        /// <summary>
        /// Updates default type Id on Time Series model settings synchronously.
        /// </summary>
        /// <param name="defaultTypeId">Default type Id of the model that new instances will automatically belong to.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The updated model settings with the http response <see cref="Response{TimeSeriesModelSettings}"/>.</returns>
        public virtual Response<TimeSeriesModelSettings> UpdateModelSettingsDefaultTypeId(string defaultTypeId, CancellationToken cancellationToken = default)
        {
            using DiagnosticScope scope = _clientDiagnostics.CreateScope($"{nameof(TimeSeriesInsightsClient)}.{nameof(UpdateModelSettingsDefaultTypeId)}");
            scope.Start();
            try
            {
                // To do: Generate client session Id
                var options = new UpdateModelSettingsRequest { DefaultTypeId = defaultTypeId };
                Response<ModelSettingsResponse> modelSettings = _modelSettingsRestClient.Update(options, null, cancellationToken);
                return Response.FromValue(modelSettings.Value.ModelSettings, modelSettings.GetRawResponse());
            }
            catch (Exception ex)
            {
                scope.Failed(ex);
                throw;
            }
        }
    }
}
