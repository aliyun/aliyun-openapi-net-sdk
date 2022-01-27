/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListDataServicePublishedApisResponseUnmarshaller
    {
        public static ListDataServicePublishedApisResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataServicePublishedApisResponse listDataServicePublishedApisResponse = new ListDataServicePublishedApisResponse();

			listDataServicePublishedApisResponse.HttpResponse = _ctx.HttpResponse;
			listDataServicePublishedApisResponse.ErrorCode = _ctx.StringValue("ListDataServicePublishedApis.ErrorCode");
			listDataServicePublishedApisResponse.ErrorMessage = _ctx.StringValue("ListDataServicePublishedApis.ErrorMessage");
			listDataServicePublishedApisResponse.HttpStatusCode = _ctx.IntegerValue("ListDataServicePublishedApis.HttpStatusCode");
			listDataServicePublishedApisResponse.RequestId = _ctx.StringValue("ListDataServicePublishedApis.RequestId");
			listDataServicePublishedApisResponse.Success = _ctx.BooleanValue("ListDataServicePublishedApis.Success");

			ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data data = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data();
			data.PageNumber = _ctx.IntegerValue("ListDataServicePublishedApis.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListDataServicePublishedApis.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListDataServicePublishedApis.Data.TotalCount");

			List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api> data_apis = new List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api>();
			for (int i = 0; i < _ctx.Length("ListDataServicePublishedApis.Data.Apis.Length"); i++) {
				ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api api = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api();
				api.ApiId = _ctx.LongValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ApiId");
				api.ApiMode = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ApiMode");
				api.ApiName = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ApiName");
				api.ApiPath = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ApiPath");
				api.CreatedTime = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].CreatedTime");
				api.CreatorId = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].CreatorId");
				api.Description = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].Description");
				api.GroupId = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].GroupId");
				api.ModifiedTime = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ModifiedTime");
				api.OperatorId = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].OperatorId");
				api.ProjectId = _ctx.LongValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ProjectId");
				api.RequestMethod = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RequestMethod");
				api.ResponseContentType = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ResponseContentType");
				api.Status = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].Status");
				api.TenantId = _ctx.LongValue("ListDataServicePublishedApis.Data.Apis["+ i +"].TenantId");
				api.Timeout = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].Timeout");
				api.VisibleRange = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].VisibleRange");

				List<string> api_protocols = new List<string>();
				for (int j = 0; j < _ctx.Length("ListDataServicePublishedApis.Data.Apis["+ i +"].Protocols.Length"); j++) {
					api_protocols.Add(_ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].Protocols["+ j +"]"));
				}
				api.Protocols = api_protocols;

				ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_RegistrationDetails registrationDetails = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_RegistrationDetails();
				registrationDetails.FailedResultSample = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.FailedResultSample");
				registrationDetails.ServiceContentType = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.ServiceContentType");
				registrationDetails.ServiceHost = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.ServiceHost");
				registrationDetails.ServicePath = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.ServicePath");
				registrationDetails.ServiceRequestBodyDescription = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.ServiceRequestBodyDescription");
				registrationDetails.SuccessfulResultSample = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.SuccessfulResultSample");

				List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_RegistrationDetails.ListDataServicePublishedApis_RegistrationErrorCode> registrationDetails_registrationErrorCodes = new List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_RegistrationDetails.ListDataServicePublishedApis_RegistrationErrorCode>();
				for (int j = 0; j < _ctx.Length("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationErrorCodes.Length"); j++) {
					ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_RegistrationDetails.ListDataServicePublishedApis_RegistrationErrorCode registrationErrorCode = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_RegistrationDetails.ListDataServicePublishedApis_RegistrationErrorCode();
					registrationErrorCode.ErrorCode = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationErrorCodes["+ j +"].ErrorCode");
					registrationErrorCode.ErrorMessage = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationErrorCodes["+ j +"].ErrorMessage");
					registrationErrorCode.ErrorSolution = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationErrorCodes["+ j +"].ErrorSolution");

					registrationDetails_registrationErrorCodes.Add(registrationErrorCode);
				}
				registrationDetails.RegistrationErrorCodes = registrationDetails_registrationErrorCodes;

				List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_RegistrationDetails.ListDataServicePublishedApis_RegistrationRequestParameter> registrationDetails_registrationRequestParameters = new List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_RegistrationDetails.ListDataServicePublishedApis_RegistrationRequestParameter>();
				for (int j = 0; j < _ctx.Length("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters.Length"); j++) {
					ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_RegistrationDetails.ListDataServicePublishedApis_RegistrationRequestParameter registrationRequestParameter = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_RegistrationDetails.ListDataServicePublishedApis_RegistrationRequestParameter();
					registrationRequestParameter.DefaultValue = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].DefaultValue");
					registrationRequestParameter.ExampleValue = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ExampleValue");
					registrationRequestParameter.IsRequiredParameter = _ctx.BooleanValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].IsRequiredParameter");
					registrationRequestParameter.ParameterDataType = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterDataType");
					registrationRequestParameter.ParameterDescription = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterDescription");
					registrationRequestParameter.ParameterName = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterName");
					registrationRequestParameter.ParameterOperator = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterOperator");
					registrationRequestParameter.ParameterPosition = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterPosition");

					registrationDetails_registrationRequestParameters.Add(registrationRequestParameter);
				}
				registrationDetails.RegistrationRequestParameters = registrationDetails_registrationRequestParameters;
				api.RegistrationDetails = registrationDetails;

				ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails scriptDetails = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails();
				scriptDetails.FailedResultSample = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.FailedResultSample");
				scriptDetails.IsPagedResponse = _ctx.BooleanValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.IsPagedResponse");
				scriptDetails.Script = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.Script");
				scriptDetails.SuccessfulResultSample = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.SuccessfulResultSample");

				ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails.ListDataServicePublishedApis_ScriptConnection scriptConnection = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails.ListDataServicePublishedApis_ScriptConnection();
				scriptConnection.ConnectionId = _ctx.LongValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptConnection.ConnectionId");
				scriptConnection.TableName = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptConnection.TableName");
				scriptDetails.ScriptConnection = scriptConnection;

				List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails.ListDataServicePublishedApis_ScriptErrorCode> scriptDetails_scriptErrorCodes = new List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails.ListDataServicePublishedApis_ScriptErrorCode>();
				for (int j = 0; j < _ctx.Length("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptErrorCodes.Length"); j++) {
					ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails.ListDataServicePublishedApis_ScriptErrorCode scriptErrorCode = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails.ListDataServicePublishedApis_ScriptErrorCode();
					scriptErrorCode.ErrorCode = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptErrorCodes["+ j +"].ErrorCode");
					scriptErrorCode.ErrorMessage = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptErrorCodes["+ j +"].ErrorMessage");
					scriptErrorCode.ErrorSolution = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptErrorCodes["+ j +"].ErrorSolution");

					scriptDetails_scriptErrorCodes.Add(scriptErrorCode);
				}
				scriptDetails.ScriptErrorCodes = scriptDetails_scriptErrorCodes;

				List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails.ListDataServicePublishedApis_ScriptRequestParameter> scriptDetails_scriptRequestParameters = new List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails.ListDataServicePublishedApis_ScriptRequestParameter>();
				for (int j = 0; j < _ctx.Length("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters.Length"); j++) {
					ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails.ListDataServicePublishedApis_ScriptRequestParameter scriptRequestParameter = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails.ListDataServicePublishedApis_ScriptRequestParameter();
					scriptRequestParameter.DefaultValue = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].DefaultValue");
					scriptRequestParameter.ExampleValue = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ExampleValue");
					scriptRequestParameter.IsRequiredParameter = _ctx.BooleanValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].IsRequiredParameter");
					scriptRequestParameter.ParameterDataType = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterDataType");
					scriptRequestParameter.ParameterDescription = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterDescription");
					scriptRequestParameter.ParameterName = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterName");
					scriptRequestParameter.ParameterOperator = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterOperator");
					scriptRequestParameter.ParameterPosition = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterPosition");

					scriptDetails_scriptRequestParameters.Add(scriptRequestParameter);
				}
				scriptDetails.ScriptRequestParameters = scriptDetails_scriptRequestParameters;

				List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails.ListDataServicePublishedApis_ScriptResponseParameter> scriptDetails_scriptResponseParameters = new List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails.ListDataServicePublishedApis_ScriptResponseParameter>();
				for (int j = 0; j < _ctx.Length("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters.Length"); j++) {
					ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails.ListDataServicePublishedApis_ScriptResponseParameter scriptResponseParameter = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_ScriptDetails.ListDataServicePublishedApis_ScriptResponseParameter();
					scriptResponseParameter.ExampleValue = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters["+ j +"].ExampleValue");
					scriptResponseParameter.ParameterDataType = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters["+ j +"].ParameterDataType");
					scriptResponseParameter.ParameterDescription = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters["+ j +"].ParameterDescription");
					scriptResponseParameter.ParameterName = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters["+ j +"].ParameterName");

					scriptDetails_scriptResponseParameters.Add(scriptResponseParameter);
				}
				scriptDetails.ScriptResponseParameters = scriptDetails_scriptResponseParameters;
				api.ScriptDetails = scriptDetails;

				ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails wizardDetails = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails();
				wizardDetails.FailedResultSample = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.FailedResultSample");
				wizardDetails.IsPagedResponse = _ctx.BooleanValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.IsPagedResponse");
				wizardDetails.SuccessfulResultSample = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.SuccessfulResultSample");

				ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails.ListDataServicePublishedApis_WizardConnection wizardConnection = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails.ListDataServicePublishedApis_WizardConnection();
				wizardConnection.ConnectionId = _ctx.LongValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardConnection.ConnectionId");
				wizardConnection.TableName = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardConnection.TableName");
				wizardDetails.WizardConnection = wizardConnection;

				List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails.ListDataServicePublishedApis_WizardErrorCode> wizardDetails_wizardErrorCodes = new List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails.ListDataServicePublishedApis_WizardErrorCode>();
				for (int j = 0; j < _ctx.Length("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardErrorCodes.Length"); j++) {
					ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails.ListDataServicePublishedApis_WizardErrorCode wizardErrorCode = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails.ListDataServicePublishedApis_WizardErrorCode();
					wizardErrorCode.ErrorCode = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardErrorCodes["+ j +"].ErrorCode");
					wizardErrorCode.ErrorMessage = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardErrorCodes["+ j +"].ErrorMessage");
					wizardErrorCode.ErrorSolution = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardErrorCodes["+ j +"].ErrorSolution");

					wizardDetails_wizardErrorCodes.Add(wizardErrorCode);
				}
				wizardDetails.WizardErrorCodes = wizardDetails_wizardErrorCodes;

				List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails.ListDataServicePublishedApis_WizardRequestParameter> wizardDetails_wizardRequestParameters = new List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails.ListDataServicePublishedApis_WizardRequestParameter>();
				for (int j = 0; j < _ctx.Length("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters.Length"); j++) {
					ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails.ListDataServicePublishedApis_WizardRequestParameter wizardRequestParameter = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails.ListDataServicePublishedApis_WizardRequestParameter();
					wizardRequestParameter.DefaultValue = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].DefaultValue");
					wizardRequestParameter.ExampleValue = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ExampleValue");
					wizardRequestParameter.IsRequiredParameter = _ctx.BooleanValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].IsRequiredParameter");
					wizardRequestParameter.ParameterDataType = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterDataType");
					wizardRequestParameter.ParameterDescription = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterDescription");
					wizardRequestParameter.ParameterName = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterName");
					wizardRequestParameter.ParameterOperator = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterOperator");
					wizardRequestParameter.ParameterPosition = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterPosition");

					wizardDetails_wizardRequestParameters.Add(wizardRequestParameter);
				}
				wizardDetails.WizardRequestParameters = wizardDetails_wizardRequestParameters;

				List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails.ListDataServicePublishedApis_WizardResponseParameter> wizardDetails_wizardResponseParameters = new List<ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails.ListDataServicePublishedApis_WizardResponseParameter>();
				for (int j = 0; j < _ctx.Length("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters.Length"); j++) {
					ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails.ListDataServicePublishedApis_WizardResponseParameter wizardResponseParameter = new ListDataServicePublishedApisResponse.ListDataServicePublishedApis_Data.ListDataServicePublishedApis_Api.ListDataServicePublishedApis_WizardDetails.ListDataServicePublishedApis_WizardResponseParameter();
					wizardResponseParameter.ExampleValue = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters["+ j +"].ExampleValue");
					wizardResponseParameter.ParameterDataType = _ctx.IntegerValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters["+ j +"].ParameterDataType");
					wizardResponseParameter.ParameterDescription = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters["+ j +"].ParameterDescription");
					wizardResponseParameter.ParameterName = _ctx.StringValue("ListDataServicePublishedApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters["+ j +"].ParameterName");

					wizardDetails_wizardResponseParameters.Add(wizardResponseParameter);
				}
				wizardDetails.WizardResponseParameters = wizardDetails_wizardResponseParameters;
				api.WizardDetails = wizardDetails;

				data_apis.Add(api);
			}
			data.Apis = data_apis;
			listDataServicePublishedApisResponse.Data = data;
        
			return listDataServicePublishedApisResponse;
        }
    }
}
