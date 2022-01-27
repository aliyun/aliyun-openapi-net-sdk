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
    public class GetDataServicePublishedApiResponseUnmarshaller
    {
        public static GetDataServicePublishedApiResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDataServicePublishedApiResponse getDataServicePublishedApiResponse = new GetDataServicePublishedApiResponse();

			getDataServicePublishedApiResponse.HttpResponse = _ctx.HttpResponse;
			getDataServicePublishedApiResponse.ErrorCode = _ctx.StringValue("GetDataServicePublishedApi.ErrorCode");
			getDataServicePublishedApiResponse.ErrorMessage = _ctx.StringValue("GetDataServicePublishedApi.ErrorMessage");
			getDataServicePublishedApiResponse.HttpStatusCode = _ctx.IntegerValue("GetDataServicePublishedApi.HttpStatusCode");
			getDataServicePublishedApiResponse.RequestId = _ctx.StringValue("GetDataServicePublishedApi.RequestId");
			getDataServicePublishedApiResponse.Success = _ctx.BooleanValue("GetDataServicePublishedApi.Success");

			GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data data = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data();
			data.ApiId = _ctx.LongValue("GetDataServicePublishedApi.Data.ApiId");
			data.ApiMode = _ctx.IntegerValue("GetDataServicePublishedApi.Data.ApiMode");
			data.ApiName = _ctx.StringValue("GetDataServicePublishedApi.Data.ApiName");
			data.ApiPath = _ctx.StringValue("GetDataServicePublishedApi.Data.ApiPath");
			data.CreatedTime = _ctx.StringValue("GetDataServicePublishedApi.Data.CreatedTime");
			data.CreatorId = _ctx.StringValue("GetDataServicePublishedApi.Data.CreatorId");
			data.Description = _ctx.StringValue("GetDataServicePublishedApi.Data.Description");
			data.GroupId = _ctx.StringValue("GetDataServicePublishedApi.Data.GroupId");
			data.ModifiedTime = _ctx.StringValue("GetDataServicePublishedApi.Data.ModifiedTime");
			data.OperatorId = _ctx.StringValue("GetDataServicePublishedApi.Data.OperatorId");
			data.ProjectId = _ctx.LongValue("GetDataServicePublishedApi.Data.ProjectId");
			data.RequestMethod = _ctx.IntegerValue("GetDataServicePublishedApi.Data.RequestMethod");
			data.ResponseContentType = _ctx.IntegerValue("GetDataServicePublishedApi.Data.ResponseContentType");
			data.Status = _ctx.IntegerValue("GetDataServicePublishedApi.Data.Status");
			data.TenantId = _ctx.LongValue("GetDataServicePublishedApi.Data.TenantId");
			data.Timeout = _ctx.IntegerValue("GetDataServicePublishedApi.Data.Timeout");
			data.VisibleRange = _ctx.IntegerValue("GetDataServicePublishedApi.Data.VisibleRange");

			List<string> data_protocols = new List<string>();
			for (int i = 0; i < _ctx.Length("GetDataServicePublishedApi.Data.Protocols.Length"); i++) {
				data_protocols.Add(_ctx.StringValue("GetDataServicePublishedApi.Data.Protocols["+ i +"]"));
			}
			data.Protocols = data_protocols;

			GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails registrationDetails = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails();
			registrationDetails.FailedResultSample = _ctx.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.FailedResultSample");
			registrationDetails.ServiceContentType = _ctx.IntegerValue("GetDataServicePublishedApi.Data.RegistrationDetails.ServiceContentType");
			registrationDetails.ServiceHost = _ctx.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.ServiceHost");
			registrationDetails.ServicePath = _ctx.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.ServicePath");
			registrationDetails.ServiceRequestBodyDescription = _ctx.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.ServiceRequestBodyDescription");
			registrationDetails.SuccessfulResultSample = _ctx.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.SuccessfulResultSample");

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationErrorCode> registrationDetails_registrationErrorCodes = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationErrorCode>();
			for (int i = 0; i < _ctx.Length("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationErrorCodes.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationErrorCode registrationErrorCode = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationErrorCode();
				registrationErrorCode.ErrorCode = _ctx.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationErrorCodes["+ i +"].ErrorCode");
				registrationErrorCode.ErrorMessage = _ctx.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationErrorCodes["+ i +"].ErrorMessage");
				registrationErrorCode.ErrorSolution = _ctx.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationErrorCodes["+ i +"].ErrorSolution");

				registrationDetails_registrationErrorCodes.Add(registrationErrorCode);
			}
			registrationDetails.RegistrationErrorCodes = registrationDetails_registrationErrorCodes;

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationRequestParameter> registrationDetails_registrationRequestParameters = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationRequestParameter>();
			for (int i = 0; i < _ctx.Length("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationRequestParameter registrationRequestParameter = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationRequestParameter();
				registrationRequestParameter.DefaultValue = _ctx.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].DefaultValue");
				registrationRequestParameter.ExampleValue = _ctx.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ExampleValue");
				registrationRequestParameter.IsRequiredParameter = _ctx.BooleanValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].IsRequiredParameter");
				registrationRequestParameter.ParameterDataType = _ctx.IntegerValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterDataType");
				registrationRequestParameter.ParameterDescription = _ctx.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterDescription");
				registrationRequestParameter.ParameterName = _ctx.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterName");
				registrationRequestParameter.ParameterOperator = _ctx.IntegerValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterOperator");
				registrationRequestParameter.ParameterPosition = _ctx.IntegerValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterPosition");

				registrationDetails_registrationRequestParameters.Add(registrationRequestParameter);
			}
			registrationDetails.RegistrationRequestParameters = registrationDetails_registrationRequestParameters;
			data.RegistrationDetails = registrationDetails;

			GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails scriptDetails = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails();
			scriptDetails.FailedResultSample = _ctx.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.FailedResultSample");
			scriptDetails.IsPagedResponse = _ctx.BooleanValue("GetDataServicePublishedApi.Data.ScriptDetails.IsPagedResponse");
			scriptDetails.Script = _ctx.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.Script");
			scriptDetails.SuccessfulResultSample = _ctx.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.SuccessfulResultSample");

			GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptConnection scriptConnection = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptConnection();
			scriptConnection.ConnectionId = _ctx.LongValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptConnection.ConnectionId");
			scriptConnection.TableName = _ctx.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptConnection.TableName");
			scriptDetails.ScriptConnection = scriptConnection;

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptErrorCode> scriptDetails_scriptErrorCodes = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptErrorCode>();
			for (int i = 0; i < _ctx.Length("GetDataServicePublishedApi.Data.ScriptDetails.ScriptErrorCodes.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptErrorCode scriptErrorCode = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptErrorCode();
				scriptErrorCode.ErrorCode = _ctx.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptErrorCodes["+ i +"].ErrorCode");
				scriptErrorCode.ErrorMessage = _ctx.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptErrorCodes["+ i +"].ErrorMessage");
				scriptErrorCode.ErrorSolution = _ctx.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptErrorCodes["+ i +"].ErrorSolution");

				scriptDetails_scriptErrorCodes.Add(scriptErrorCode);
			}
			scriptDetails.ScriptErrorCodes = scriptDetails_scriptErrorCodes;

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptRequestParameter> scriptDetails_scriptRequestParameters = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptRequestParameter>();
			for (int i = 0; i < _ctx.Length("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptRequestParameter scriptRequestParameter = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptRequestParameter();
				scriptRequestParameter.DefaultValue = _ctx.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].DefaultValue");
				scriptRequestParameter.ExampleValue = _ctx.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ExampleValue");
				scriptRequestParameter.IsRequiredParameter = _ctx.BooleanValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].IsRequiredParameter");
				scriptRequestParameter.ParameterDataType = _ctx.IntegerValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterDataType");
				scriptRequestParameter.ParameterDescription = _ctx.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterDescription");
				scriptRequestParameter.ParameterName = _ctx.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterName");
				scriptRequestParameter.ParameterOperator = _ctx.IntegerValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterOperator");
				scriptRequestParameter.ParameterPosition = _ctx.IntegerValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterPosition");

				scriptDetails_scriptRequestParameters.Add(scriptRequestParameter);
			}
			scriptDetails.ScriptRequestParameters = scriptDetails_scriptRequestParameters;

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptResponseParameter> scriptDetails_scriptResponseParameters = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptResponseParameter>();
			for (int i = 0; i < _ctx.Length("GetDataServicePublishedApi.Data.ScriptDetails.ScriptResponseParameters.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptResponseParameter scriptResponseParameter = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptResponseParameter();
				scriptResponseParameter.ExampleValue = _ctx.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ExampleValue");
				scriptResponseParameter.ParameterDataType = _ctx.IntegerValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ParameterDataType");
				scriptResponseParameter.ParameterDescription = _ctx.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ParameterDescription");
				scriptResponseParameter.ParameterName = _ctx.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ParameterName");

				scriptDetails_scriptResponseParameters.Add(scriptResponseParameter);
			}
			scriptDetails.ScriptResponseParameters = scriptDetails_scriptResponseParameters;
			data.ScriptDetails = scriptDetails;

			GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails wizardDetails = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails();
			wizardDetails.FailedResultSample = _ctx.StringValue("GetDataServicePublishedApi.Data.WizardDetails.FailedResultSample");
			wizardDetails.IsPagedResponse = _ctx.BooleanValue("GetDataServicePublishedApi.Data.WizardDetails.IsPagedResponse");
			wizardDetails.SuccessfulResultSample = _ctx.StringValue("GetDataServicePublishedApi.Data.WizardDetails.SuccessfulResultSample");

			GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardConnection wizardConnection = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardConnection();
			wizardConnection.ConnectionId = _ctx.LongValue("GetDataServicePublishedApi.Data.WizardDetails.WizardConnection.ConnectionId");
			wizardConnection.TableName = _ctx.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardConnection.TableName");
			wizardDetails.WizardConnection = wizardConnection;

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardErrorCode> wizardDetails_wizardErrorCodes = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardErrorCode>();
			for (int i = 0; i < _ctx.Length("GetDataServicePublishedApi.Data.WizardDetails.WizardErrorCodes.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardErrorCode wizardErrorCode = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardErrorCode();
				wizardErrorCode.ErrorCode = _ctx.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardErrorCodes["+ i +"].ErrorCode");
				wizardErrorCode.ErrorMessage = _ctx.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardErrorCodes["+ i +"].ErrorMessage");
				wizardErrorCode.ErrorSolution = _ctx.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardErrorCodes["+ i +"].ErrorSolution");

				wizardDetails_wizardErrorCodes.Add(wizardErrorCode);
			}
			wizardDetails.WizardErrorCodes = wizardDetails_wizardErrorCodes;

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardRequestParameter> wizardDetails_wizardRequestParameters = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardRequestParameter>();
			for (int i = 0; i < _ctx.Length("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardRequestParameter wizardRequestParameter = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardRequestParameter();
				wizardRequestParameter.DefaultValue = _ctx.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].DefaultValue");
				wizardRequestParameter.ExampleValue = _ctx.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ExampleValue");
				wizardRequestParameter.IsRequiredParameter = _ctx.BooleanValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].IsRequiredParameter");
				wizardRequestParameter.ParameterDataType = _ctx.IntegerValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterDataType");
				wizardRequestParameter.ParameterDescription = _ctx.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterDescription");
				wizardRequestParameter.ParameterName = _ctx.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterName");
				wizardRequestParameter.ParameterOperator = _ctx.IntegerValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterOperator");
				wizardRequestParameter.ParameterPosition = _ctx.IntegerValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterPosition");

				wizardDetails_wizardRequestParameters.Add(wizardRequestParameter);
			}
			wizardDetails.WizardRequestParameters = wizardDetails_wizardRequestParameters;

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardResponseParameter> wizardDetails_wizardResponseParameters = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardResponseParameter>();
			for (int i = 0; i < _ctx.Length("GetDataServicePublishedApi.Data.WizardDetails.WizardResponseParameters.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardResponseParameter wizardResponseParameter = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardResponseParameter();
				wizardResponseParameter.ExampleValue = _ctx.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ExampleValue");
				wizardResponseParameter.ParameterDataType = _ctx.IntegerValue("GetDataServicePublishedApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ParameterDataType");
				wizardResponseParameter.ParameterDescription = _ctx.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ParameterDescription");
				wizardResponseParameter.ParameterName = _ctx.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ParameterName");

				wizardDetails_wizardResponseParameters.Add(wizardResponseParameter);
			}
			wizardDetails.WizardResponseParameters = wizardDetails_wizardResponseParameters;
			data.WizardDetails = wizardDetails;
			getDataServicePublishedApiResponse.Data = data;
        
			return getDataServicePublishedApiResponse;
        }
    }
}
