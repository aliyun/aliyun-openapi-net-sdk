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
    public class GetDataServiceApiResponseUnmarshaller
    {
        public static GetDataServiceApiResponse Unmarshall(UnmarshallerContext context)
        {
			GetDataServiceApiResponse getDataServiceApiResponse = new GetDataServiceApiResponse();

			getDataServiceApiResponse.HttpResponse = context.HttpResponse;
			getDataServiceApiResponse.ErrorCode = context.StringValue("GetDataServiceApi.ErrorCode");
			getDataServiceApiResponse.ErrorMessage = context.StringValue("GetDataServiceApi.ErrorMessage");
			getDataServiceApiResponse.HttpStatusCode = context.IntegerValue("GetDataServiceApi.HttpStatusCode");
			getDataServiceApiResponse.RequestId = context.StringValue("GetDataServiceApi.RequestId");
			getDataServiceApiResponse.Success = context.BooleanValue("GetDataServiceApi.Success");

			GetDataServiceApiResponse.GetDataServiceApi_Data data = new GetDataServiceApiResponse.GetDataServiceApi_Data();
			data.ApiId = context.LongValue("GetDataServiceApi.Data.ApiId");
			data.ApiMode = context.IntegerValue("GetDataServiceApi.Data.ApiMode");
			data.ApiName = context.StringValue("GetDataServiceApi.Data.ApiName");
			data.ApiPath = context.StringValue("GetDataServiceApi.Data.ApiPath");
			data.CreatedTime = context.StringValue("GetDataServiceApi.Data.CreatedTime");
			data.CreatorId = context.StringValue("GetDataServiceApi.Data.CreatorId");
			data.Description = context.StringValue("GetDataServiceApi.Data.Description");
			data.GroupId = context.StringValue("GetDataServiceApi.Data.GroupId");
			data.ModifiedTime = context.StringValue("GetDataServiceApi.Data.ModifiedTime");
			data.OperatorId = context.StringValue("GetDataServiceApi.Data.OperatorId");
			data.ProjectId = context.LongValue("GetDataServiceApi.Data.ProjectId");
			data.RequestMethod = context.IntegerValue("GetDataServiceApi.Data.RequestMethod");
			data.ResponseContentType = context.IntegerValue("GetDataServiceApi.Data.ResponseContentType");
			data.Status = context.IntegerValue("GetDataServiceApi.Data.Status");
			data.TenantId = context.LongValue("GetDataServiceApi.Data.TenantId");
			data.Timeout = context.IntegerValue("GetDataServiceApi.Data.Timeout");
			data.VisibleRange = context.IntegerValue("GetDataServiceApi.Data.VisibleRange");

			List<string> data_protocols = new List<string>();
			for (int i = 0; i < context.Length("GetDataServiceApi.Data.Protocols.Length"); i++) {
				data_protocols.Add(context.StringValue("GetDataServiceApi.Data.Protocols["+ i +"]"));
			}
			data.Protocols = data_protocols;

			GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails registrationDetails = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails();
			registrationDetails.FailedResultSample = context.StringValue("GetDataServiceApi.Data.RegistrationDetails.FailedResultSample");
			registrationDetails.ServiceContentType = context.IntegerValue("GetDataServiceApi.Data.RegistrationDetails.ServiceContentType");
			registrationDetails.ServiceHost = context.StringValue("GetDataServiceApi.Data.RegistrationDetails.ServiceHost");
			registrationDetails.ServicePath = context.StringValue("GetDataServiceApi.Data.RegistrationDetails.ServicePath");
			registrationDetails.ServiceRequestBodyDescription = context.StringValue("GetDataServiceApi.Data.RegistrationDetails.ServiceRequestBodyDescription");
			registrationDetails.SuccessfulResultSample = context.StringValue("GetDataServiceApi.Data.RegistrationDetails.SuccessfulResultSample");

			List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationErrorCode> registrationDetails_registrationErrorCodes = new List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationErrorCode>();
			for (int i = 0; i < context.Length("GetDataServiceApi.Data.RegistrationDetails.RegistrationErrorCodes.Length"); i++) {
				GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationErrorCode registrationErrorCode = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationErrorCode();
				registrationErrorCode.ErrorCode = context.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationErrorCodes["+ i +"].ErrorCode");
				registrationErrorCode.ErrorMessage = context.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationErrorCodes["+ i +"].ErrorMessage");
				registrationErrorCode.ErrorSolution = context.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationErrorCodes["+ i +"].ErrorSolution");

				registrationDetails_registrationErrorCodes.Add(registrationErrorCode);
			}
			registrationDetails.RegistrationErrorCodes = registrationDetails_registrationErrorCodes;

			List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationRequestParameter> registrationDetails_registrationRequestParameters = new List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationRequestParameter>();
			for (int i = 0; i < context.Length("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters.Length"); i++) {
				GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationRequestParameter registrationRequestParameter = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationRequestParameter();
				registrationRequestParameter.ColumnName = context.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ColumnName");
				registrationRequestParameter.DefaultValue = context.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].DefaultValue");
				registrationRequestParameter.ExampleValue = context.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ExampleValue");
				registrationRequestParameter.IsRequiredParameter = context.BooleanValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].IsRequiredParameter");
				registrationRequestParameter.ParameterDataType = context.IntegerValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterDataType");
				registrationRequestParameter.ParameterDescription = context.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterDescription");
				registrationRequestParameter.ParameterName = context.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterName");
				registrationRequestParameter.ParameterOperator = context.IntegerValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterOperator");
				registrationRequestParameter.ParameterPosition = context.IntegerValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterPosition");

				registrationDetails_registrationRequestParameters.Add(registrationRequestParameter);
			}
			registrationDetails.RegistrationRequestParameters = registrationDetails_registrationRequestParameters;
			data.RegistrationDetails = registrationDetails;

			GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails scriptDetails = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails();
			scriptDetails.IsPagedResponse = context.BooleanValue("GetDataServiceApi.Data.ScriptDetails.IsPagedResponse");
			scriptDetails.Script = context.StringValue("GetDataServiceApi.Data.ScriptDetails.Script");

			GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptConnection scriptConnection = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptConnection();
			scriptConnection.ConnectionId = context.LongValue("GetDataServiceApi.Data.ScriptDetails.ScriptConnection.ConnectionId");
			scriptConnection.TableName = context.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptConnection.TableName");
			scriptDetails.ScriptConnection = scriptConnection;

			List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptRequestParameter> scriptDetails_scriptRequestParameters = new List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptRequestParameter>();
			for (int i = 0; i < context.Length("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters.Length"); i++) {
				GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptRequestParameter scriptRequestParameter = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptRequestParameter();
				scriptRequestParameter.ColumnName = context.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ColumnName");
				scriptRequestParameter.DefaultValue = context.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].DefaultValue");
				scriptRequestParameter.ExampleValue = context.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ExampleValue");
				scriptRequestParameter.IsRequiredParameter = context.BooleanValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].IsRequiredParameter");
				scriptRequestParameter.ParameterDataType = context.IntegerValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterDataType");
				scriptRequestParameter.ParameterDescription = context.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterDescription");
				scriptRequestParameter.ParameterName = context.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterName");
				scriptRequestParameter.ParameterOperator = context.IntegerValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterOperator");
				scriptRequestParameter.ParameterPosition = context.IntegerValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterPosition");

				scriptDetails_scriptRequestParameters.Add(scriptRequestParameter);
			}
			scriptDetails.ScriptRequestParameters = scriptDetails_scriptRequestParameters;

			List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptResponseParameter> scriptDetails_scriptResponseParameters = new List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptResponseParameter>();
			for (int i = 0; i < context.Length("GetDataServiceApi.Data.ScriptDetails.ScriptResponseParameters.Length"); i++) {
				GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptResponseParameter scriptResponseParameter = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptResponseParameter();
				scriptResponseParameter.ColumnName = context.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ColumnName");
				scriptResponseParameter.ExampleValue = context.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ExampleValue");
				scriptResponseParameter.ParameterDataType = context.IntegerValue("GetDataServiceApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ParameterDataType");
				scriptResponseParameter.ParameterDescription = context.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ParameterDescription");
				scriptResponseParameter.ParameterName = context.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ParameterName");

				scriptDetails_scriptResponseParameters.Add(scriptResponseParameter);
			}
			scriptDetails.ScriptResponseParameters = scriptDetails_scriptResponseParameters;
			data.ScriptDetails = scriptDetails;

			GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails wizardDetails = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails();
			wizardDetails.IsPagedResponse = context.BooleanValue("GetDataServiceApi.Data.WizardDetails.IsPagedResponse");

			GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardConnection wizardConnection = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardConnection();
			wizardConnection.ConnectionId = context.LongValue("GetDataServiceApi.Data.WizardDetails.WizardConnection.ConnectionId");
			wizardConnection.TableName = context.StringValue("GetDataServiceApi.Data.WizardDetails.WizardConnection.TableName");
			wizardDetails.WizardConnection = wizardConnection;

			List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardRequestParameter> wizardDetails_wizardRequestParameters = new List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardRequestParameter>();
			for (int i = 0; i < context.Length("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters.Length"); i++) {
				GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardRequestParameter wizardRequestParameter = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardRequestParameter();
				wizardRequestParameter.ColumnName = context.StringValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ColumnName");
				wizardRequestParameter.DefaultValue = context.StringValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].DefaultValue");
				wizardRequestParameter.ExampleValue = context.StringValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ExampleValue");
				wizardRequestParameter.IsRequiredParameter = context.BooleanValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].IsRequiredParameter");
				wizardRequestParameter.ParameterDataType = context.IntegerValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterDataType");
				wizardRequestParameter.ParameterDescription = context.StringValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterDescription");
				wizardRequestParameter.ParameterName = context.StringValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterName");
				wizardRequestParameter.ParameterOperator = context.IntegerValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterOperator");
				wizardRequestParameter.ParameterPosition = context.IntegerValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterPosition");

				wizardDetails_wizardRequestParameters.Add(wizardRequestParameter);
			}
			wizardDetails.WizardRequestParameters = wizardDetails_wizardRequestParameters;

			List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardResponseParameter> wizardDetails_wizardResponseParameters = new List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardResponseParameter>();
			for (int i = 0; i < context.Length("GetDataServiceApi.Data.WizardDetails.WizardResponseParameters.Length"); i++) {
				GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardResponseParameter wizardResponseParameter = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardResponseParameter();
				wizardResponseParameter.ColumnName = context.StringValue("GetDataServiceApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ColumnName");
				wizardResponseParameter.ExampleValue = context.StringValue("GetDataServiceApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ExampleValue");
				wizardResponseParameter.ParameterDataType = context.IntegerValue("GetDataServiceApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ParameterDataType");
				wizardResponseParameter.ParameterDescription = context.StringValue("GetDataServiceApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ParameterDescription");
				wizardResponseParameter.ParameterName = context.StringValue("GetDataServiceApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ParameterName");

				wizardDetails_wizardResponseParameters.Add(wizardResponseParameter);
			}
			wizardDetails.WizardResponseParameters = wizardDetails_wizardResponseParameters;
			data.WizardDetails = wizardDetails;
			getDataServiceApiResponse.Data = data;
        
			return getDataServiceApiResponse;
        }
    }
}
