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
        public static GetDataServicePublishedApiResponse Unmarshall(UnmarshallerContext context)
        {
			GetDataServicePublishedApiResponse getDataServicePublishedApiResponse = new GetDataServicePublishedApiResponse();

			getDataServicePublishedApiResponse.HttpResponse = context.HttpResponse;
			getDataServicePublishedApiResponse.ErrorCode = context.StringValue("GetDataServicePublishedApi.ErrorCode");
			getDataServicePublishedApiResponse.ErrorMessage = context.StringValue("GetDataServicePublishedApi.ErrorMessage");
			getDataServicePublishedApiResponse.HttpStatusCode = context.IntegerValue("GetDataServicePublishedApi.HttpStatusCode");
			getDataServicePublishedApiResponse.RequestId = context.StringValue("GetDataServicePublishedApi.RequestId");
			getDataServicePublishedApiResponse.Success = context.BooleanValue("GetDataServicePublishedApi.Success");

			GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data data = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data();
			data.ApiId = context.LongValue("GetDataServicePublishedApi.Data.ApiId");
			data.ApiMode = context.IntegerValue("GetDataServicePublishedApi.Data.ApiMode");
			data.ApiName = context.StringValue("GetDataServicePublishedApi.Data.ApiName");
			data.ApiPath = context.StringValue("GetDataServicePublishedApi.Data.ApiPath");
			data.CreatedTime = context.StringValue("GetDataServicePublishedApi.Data.CreatedTime");
			data.CreatorId = context.StringValue("GetDataServicePublishedApi.Data.CreatorId");
			data.Description = context.StringValue("GetDataServicePublishedApi.Data.Description");
			data.GroupId = context.StringValue("GetDataServicePublishedApi.Data.GroupId");
			data.ModifiedTime = context.StringValue("GetDataServicePublishedApi.Data.ModifiedTime");
			data.OperatorId = context.StringValue("GetDataServicePublishedApi.Data.OperatorId");
			data.ProjectId = context.LongValue("GetDataServicePublishedApi.Data.ProjectId");
			data.RequestMethod = context.IntegerValue("GetDataServicePublishedApi.Data.RequestMethod");
			data.ResponseContentType = context.IntegerValue("GetDataServicePublishedApi.Data.ResponseContentType");
			data.Status = context.IntegerValue("GetDataServicePublishedApi.Data.Status");
			data.TenantId = context.LongValue("GetDataServicePublishedApi.Data.TenantId");
			data.Timeout = context.IntegerValue("GetDataServicePublishedApi.Data.Timeout");
			data.VisibleRange = context.IntegerValue("GetDataServicePublishedApi.Data.VisibleRange");

			List<string> data_protocols = new List<string>();
			for (int i = 0; i < context.Length("GetDataServicePublishedApi.Data.Protocols.Length"); i++) {
				data_protocols.Add(context.StringValue("GetDataServicePublishedApi.Data.Protocols["+ i +"]"));
			}
			data.Protocols = data_protocols;

			GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails registrationDetails = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails();
			registrationDetails.FailedResultSample = context.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.FailedResultSample");
			registrationDetails.ServiceContentType = context.IntegerValue("GetDataServicePublishedApi.Data.RegistrationDetails.ServiceContentType");
			registrationDetails.ServiceHost = context.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.ServiceHost");
			registrationDetails.ServicePath = context.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.ServicePath");
			registrationDetails.ServiceRequestBodyDescription = context.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.ServiceRequestBodyDescription");
			registrationDetails.SuccessfulResultSample = context.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.SuccessfulResultSample");

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationErrorCode> registrationDetails_registrationErrorCodes = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationErrorCode>();
			for (int i = 0; i < context.Length("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationErrorCodes.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationErrorCode registrationErrorCode = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationErrorCode();
				registrationErrorCode.ErrorCode = context.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationErrorCodes["+ i +"].ErrorCode");
				registrationErrorCode.ErrorMessage = context.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationErrorCodes["+ i +"].ErrorMessage");
				registrationErrorCode.ErrorSolution = context.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationErrorCodes["+ i +"].ErrorSolution");

				registrationDetails_registrationErrorCodes.Add(registrationErrorCode);
			}
			registrationDetails.RegistrationErrorCodes = registrationDetails_registrationErrorCodes;

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationRequestParameter> registrationDetails_registrationRequestParameters = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationRequestParameter>();
			for (int i = 0; i < context.Length("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationRequestParameter registrationRequestParameter = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_RegistrationDetails.GetDataServicePublishedApi_RegistrationRequestParameter();
				registrationRequestParameter.DefaultValue = context.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].DefaultValue");
				registrationRequestParameter.ExampleValue = context.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ExampleValue");
				registrationRequestParameter.IsRequiredParameter = context.BooleanValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].IsRequiredParameter");
				registrationRequestParameter.ParameterDataType = context.IntegerValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterDataType");
				registrationRequestParameter.ParameterDescription = context.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterDescription");
				registrationRequestParameter.ParameterName = context.StringValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterName");
				registrationRequestParameter.ParameterOperator = context.IntegerValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterOperator");
				registrationRequestParameter.ParameterPosition = context.IntegerValue("GetDataServicePublishedApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterPosition");

				registrationDetails_registrationRequestParameters.Add(registrationRequestParameter);
			}
			registrationDetails.RegistrationRequestParameters = registrationDetails_registrationRequestParameters;
			data.RegistrationDetails = registrationDetails;

			GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails scriptDetails = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails();
			scriptDetails.FailedResultSample = context.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.FailedResultSample");
			scriptDetails.IsPagedResponse = context.BooleanValue("GetDataServicePublishedApi.Data.ScriptDetails.IsPagedResponse");
			scriptDetails.Script = context.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.Script");
			scriptDetails.SuccessfulResultSample = context.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.SuccessfulResultSample");

			GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptConnection scriptConnection = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptConnection();
			scriptConnection.ConnectionId = context.LongValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptConnection.ConnectionId");
			scriptConnection.TableName = context.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptConnection.TableName");
			scriptDetails.ScriptConnection = scriptConnection;

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptErrorCode> scriptDetails_scriptErrorCodes = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptErrorCode>();
			for (int i = 0; i < context.Length("GetDataServicePublishedApi.Data.ScriptDetails.ScriptErrorCodes.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptErrorCode scriptErrorCode = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptErrorCode();
				scriptErrorCode.ErrorCode = context.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptErrorCodes["+ i +"].ErrorCode");
				scriptErrorCode.ErrorMessage = context.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptErrorCodes["+ i +"].ErrorMessage");
				scriptErrorCode.ErrorSolution = context.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptErrorCodes["+ i +"].ErrorSolution");

				scriptDetails_scriptErrorCodes.Add(scriptErrorCode);
			}
			scriptDetails.ScriptErrorCodes = scriptDetails_scriptErrorCodes;

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptRequestParameter> scriptDetails_scriptRequestParameters = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptRequestParameter>();
			for (int i = 0; i < context.Length("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptRequestParameter scriptRequestParameter = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptRequestParameter();
				scriptRequestParameter.DefaultValue = context.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].DefaultValue");
				scriptRequestParameter.ExampleValue = context.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ExampleValue");
				scriptRequestParameter.IsRequiredParameter = context.BooleanValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].IsRequiredParameter");
				scriptRequestParameter.ParameterDataType = context.IntegerValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterDataType");
				scriptRequestParameter.ParameterDescription = context.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterDescription");
				scriptRequestParameter.ParameterName = context.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterName");
				scriptRequestParameter.ParameterOperator = context.IntegerValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterOperator");
				scriptRequestParameter.ParameterPosition = context.IntegerValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterPosition");

				scriptDetails_scriptRequestParameters.Add(scriptRequestParameter);
			}
			scriptDetails.ScriptRequestParameters = scriptDetails_scriptRequestParameters;

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptResponseParameter> scriptDetails_scriptResponseParameters = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptResponseParameter>();
			for (int i = 0; i < context.Length("GetDataServicePublishedApi.Data.ScriptDetails.ScriptResponseParameters.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptResponseParameter scriptResponseParameter = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_ScriptDetails.GetDataServicePublishedApi_ScriptResponseParameter();
				scriptResponseParameter.ExampleValue = context.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ExampleValue");
				scriptResponseParameter.ParameterDataType = context.IntegerValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ParameterDataType");
				scriptResponseParameter.ParameterDescription = context.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ParameterDescription");
				scriptResponseParameter.ParameterName = context.StringValue("GetDataServicePublishedApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ParameterName");

				scriptDetails_scriptResponseParameters.Add(scriptResponseParameter);
			}
			scriptDetails.ScriptResponseParameters = scriptDetails_scriptResponseParameters;
			data.ScriptDetails = scriptDetails;

			GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails wizardDetails = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails();
			wizardDetails.FailedResultSample = context.StringValue("GetDataServicePublishedApi.Data.WizardDetails.FailedResultSample");
			wizardDetails.IsPagedResponse = context.BooleanValue("GetDataServicePublishedApi.Data.WizardDetails.IsPagedResponse");
			wizardDetails.SuccessfulResultSample = context.StringValue("GetDataServicePublishedApi.Data.WizardDetails.SuccessfulResultSample");

			GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardConnection wizardConnection = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardConnection();
			wizardConnection.ConnectionId = context.LongValue("GetDataServicePublishedApi.Data.WizardDetails.WizardConnection.ConnectionId");
			wizardConnection.TableName = context.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardConnection.TableName");
			wizardDetails.WizardConnection = wizardConnection;

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardErrorCode> wizardDetails_wizardErrorCodes = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardErrorCode>();
			for (int i = 0; i < context.Length("GetDataServicePublishedApi.Data.WizardDetails.WizardErrorCodes.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardErrorCode wizardErrorCode = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardErrorCode();
				wizardErrorCode.ErrorCode = context.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardErrorCodes["+ i +"].ErrorCode");
				wizardErrorCode.ErrorMessage = context.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardErrorCodes["+ i +"].ErrorMessage");
				wizardErrorCode.ErrorSolution = context.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardErrorCodes["+ i +"].ErrorSolution");

				wizardDetails_wizardErrorCodes.Add(wizardErrorCode);
			}
			wizardDetails.WizardErrorCodes = wizardDetails_wizardErrorCodes;

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardRequestParameter> wizardDetails_wizardRequestParameters = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardRequestParameter>();
			for (int i = 0; i < context.Length("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardRequestParameter wizardRequestParameter = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardRequestParameter();
				wizardRequestParameter.DefaultValue = context.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].DefaultValue");
				wizardRequestParameter.ExampleValue = context.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ExampleValue");
				wizardRequestParameter.IsRequiredParameter = context.BooleanValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].IsRequiredParameter");
				wizardRequestParameter.ParameterDataType = context.IntegerValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterDataType");
				wizardRequestParameter.ParameterDescription = context.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterDescription");
				wizardRequestParameter.ParameterName = context.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterName");
				wizardRequestParameter.ParameterOperator = context.IntegerValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterOperator");
				wizardRequestParameter.ParameterPosition = context.IntegerValue("GetDataServicePublishedApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterPosition");

				wizardDetails_wizardRequestParameters.Add(wizardRequestParameter);
			}
			wizardDetails.WizardRequestParameters = wizardDetails_wizardRequestParameters;

			List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardResponseParameter> wizardDetails_wizardResponseParameters = new List<GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardResponseParameter>();
			for (int i = 0; i < context.Length("GetDataServicePublishedApi.Data.WizardDetails.WizardResponseParameters.Length"); i++) {
				GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardResponseParameter wizardResponseParameter = new GetDataServicePublishedApiResponse.GetDataServicePublishedApi_Data.GetDataServicePublishedApi_WizardDetails.GetDataServicePublishedApi_WizardResponseParameter();
				wizardResponseParameter.ExampleValue = context.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ExampleValue");
				wizardResponseParameter.ParameterDataType = context.IntegerValue("GetDataServicePublishedApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ParameterDataType");
				wizardResponseParameter.ParameterDescription = context.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ParameterDescription");
				wizardResponseParameter.ParameterName = context.StringValue("GetDataServicePublishedApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ParameterName");

				wizardDetails_wizardResponseParameters.Add(wizardResponseParameter);
			}
			wizardDetails.WizardResponseParameters = wizardDetails_wizardResponseParameters;
			data.WizardDetails = wizardDetails;
			getDataServicePublishedApiResponse.Data = data;
        
			return getDataServicePublishedApiResponse;
        }
    }
}
