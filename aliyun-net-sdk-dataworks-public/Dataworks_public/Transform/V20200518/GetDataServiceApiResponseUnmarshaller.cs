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
        public static GetDataServiceApiResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDataServiceApiResponse getDataServiceApiResponse = new GetDataServiceApiResponse();

			getDataServiceApiResponse.HttpResponse = _ctx.HttpResponse;
			getDataServiceApiResponse.ErrorCode = _ctx.StringValue("GetDataServiceApi.ErrorCode");
			getDataServiceApiResponse.ErrorMessage = _ctx.StringValue("GetDataServiceApi.ErrorMessage");
			getDataServiceApiResponse.HttpStatusCode = _ctx.IntegerValue("GetDataServiceApi.HttpStatusCode");
			getDataServiceApiResponse.RequestId = _ctx.StringValue("GetDataServiceApi.RequestId");
			getDataServiceApiResponse.Success = _ctx.BooleanValue("GetDataServiceApi.Success");

			GetDataServiceApiResponse.GetDataServiceApi_Data data = new GetDataServiceApiResponse.GetDataServiceApi_Data();
			data.ApiId = _ctx.LongValue("GetDataServiceApi.Data.ApiId");
			data.ApiMode = _ctx.IntegerValue("GetDataServiceApi.Data.ApiMode");
			data.ApiName = _ctx.StringValue("GetDataServiceApi.Data.ApiName");
			data.ApiPath = _ctx.StringValue("GetDataServiceApi.Data.ApiPath");
			data.CreatedTime = _ctx.StringValue("GetDataServiceApi.Data.CreatedTime");
			data.CreatorId = _ctx.StringValue("GetDataServiceApi.Data.CreatorId");
			data.Description = _ctx.StringValue("GetDataServiceApi.Data.Description");
			data.GroupId = _ctx.StringValue("GetDataServiceApi.Data.GroupId");
			data.ModifiedTime = _ctx.StringValue("GetDataServiceApi.Data.ModifiedTime");
			data.OperatorId = _ctx.StringValue("GetDataServiceApi.Data.OperatorId");
			data.ProjectId = _ctx.LongValue("GetDataServiceApi.Data.ProjectId");
			data.RequestMethod = _ctx.IntegerValue("GetDataServiceApi.Data.RequestMethod");
			data.ResponseContentType = _ctx.IntegerValue("GetDataServiceApi.Data.ResponseContentType");
			data.Status = _ctx.IntegerValue("GetDataServiceApi.Data.Status");
			data.TenantId = _ctx.LongValue("GetDataServiceApi.Data.TenantId");
			data.Timeout = _ctx.IntegerValue("GetDataServiceApi.Data.Timeout");
			data.VisibleRange = _ctx.IntegerValue("GetDataServiceApi.Data.VisibleRange");
			data.FolderId = _ctx.LongValue("GetDataServiceApi.Data.FolderId");

			List<string> data_protocols = new List<string>();
			for (int i = 0; i < _ctx.Length("GetDataServiceApi.Data.Protocols.Length"); i++) {
				data_protocols.Add(_ctx.StringValue("GetDataServiceApi.Data.Protocols["+ i +"]"));
			}
			data.Protocols = data_protocols;

			GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails registrationDetails = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails();
			registrationDetails.FailedResultSample = _ctx.StringValue("GetDataServiceApi.Data.RegistrationDetails.FailedResultSample");
			registrationDetails.ServiceContentType = _ctx.IntegerValue("GetDataServiceApi.Data.RegistrationDetails.ServiceContentType");
			registrationDetails.ServiceHost = _ctx.StringValue("GetDataServiceApi.Data.RegistrationDetails.ServiceHost");
			registrationDetails.ServicePath = _ctx.StringValue("GetDataServiceApi.Data.RegistrationDetails.ServicePath");
			registrationDetails.ServiceRequestBodyDescription = _ctx.StringValue("GetDataServiceApi.Data.RegistrationDetails.ServiceRequestBodyDescription");
			registrationDetails.SuccessfulResultSample = _ctx.StringValue("GetDataServiceApi.Data.RegistrationDetails.SuccessfulResultSample");

			List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationErrorCode> registrationDetails_registrationErrorCodes = new List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationErrorCode>();
			for (int i = 0; i < _ctx.Length("GetDataServiceApi.Data.RegistrationDetails.RegistrationErrorCodes.Length"); i++) {
				GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationErrorCode registrationErrorCode = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationErrorCode();
				registrationErrorCode.ErrorCode = _ctx.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationErrorCodes["+ i +"].ErrorCode");
				registrationErrorCode.ErrorMessage = _ctx.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationErrorCodes["+ i +"].ErrorMessage");
				registrationErrorCode.ErrorSolution = _ctx.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationErrorCodes["+ i +"].ErrorSolution");

				registrationDetails_registrationErrorCodes.Add(registrationErrorCode);
			}
			registrationDetails.RegistrationErrorCodes = registrationDetails_registrationErrorCodes;

			List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationRequestParameter> registrationDetails_registrationRequestParameters = new List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationRequestParameter>();
			for (int i = 0; i < _ctx.Length("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters.Length"); i++) {
				GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationRequestParameter registrationRequestParameter = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_RegistrationDetails.GetDataServiceApi_RegistrationRequestParameter();
				registrationRequestParameter.ColumnName = _ctx.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ColumnName");
				registrationRequestParameter.DefaultValue = _ctx.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].DefaultValue");
				registrationRequestParameter.ExampleValue = _ctx.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ExampleValue");
				registrationRequestParameter.IsRequiredParameter = _ctx.BooleanValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].IsRequiredParameter");
				registrationRequestParameter.ParameterDataType = _ctx.IntegerValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterDataType");
				registrationRequestParameter.ParameterDescription = _ctx.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterDescription");
				registrationRequestParameter.ParameterName = _ctx.StringValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterName");
				registrationRequestParameter.ParameterOperator = _ctx.IntegerValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterOperator");
				registrationRequestParameter.ParameterPosition = _ctx.IntegerValue("GetDataServiceApi.Data.RegistrationDetails.RegistrationRequestParameters["+ i +"].ParameterPosition");

				registrationDetails_registrationRequestParameters.Add(registrationRequestParameter);
			}
			registrationDetails.RegistrationRequestParameters = registrationDetails_registrationRequestParameters;
			data.RegistrationDetails = registrationDetails;

			GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails scriptDetails = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails();
			scriptDetails.IsPagedResponse = _ctx.BooleanValue("GetDataServiceApi.Data.ScriptDetails.IsPagedResponse");
			scriptDetails.Script = _ctx.StringValue("GetDataServiceApi.Data.ScriptDetails.Script");

			GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptConnection scriptConnection = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptConnection();
			scriptConnection.ConnectionId = _ctx.LongValue("GetDataServiceApi.Data.ScriptDetails.ScriptConnection.ConnectionId");
			scriptConnection.TableName = _ctx.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptConnection.TableName");
			scriptDetails.ScriptConnection = scriptConnection;

			List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptRequestParameter> scriptDetails_scriptRequestParameters = new List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptRequestParameter>();
			for (int i = 0; i < _ctx.Length("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters.Length"); i++) {
				GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptRequestParameter scriptRequestParameter = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptRequestParameter();
				scriptRequestParameter.ColumnName = _ctx.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ColumnName");
				scriptRequestParameter.DefaultValue = _ctx.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].DefaultValue");
				scriptRequestParameter.ExampleValue = _ctx.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ExampleValue");
				scriptRequestParameter.IsRequiredParameter = _ctx.BooleanValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].IsRequiredParameter");
				scriptRequestParameter.ParameterDataType = _ctx.IntegerValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterDataType");
				scriptRequestParameter.ParameterDescription = _ctx.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterDescription");
				scriptRequestParameter.ParameterName = _ctx.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterName");
				scriptRequestParameter.ParameterOperator = _ctx.IntegerValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterOperator");
				scriptRequestParameter.ParameterPosition = _ctx.IntegerValue("GetDataServiceApi.Data.ScriptDetails.ScriptRequestParameters["+ i +"].ParameterPosition");

				scriptDetails_scriptRequestParameters.Add(scriptRequestParameter);
			}
			scriptDetails.ScriptRequestParameters = scriptDetails_scriptRequestParameters;

			List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptResponseParameter> scriptDetails_scriptResponseParameters = new List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptResponseParameter>();
			for (int i = 0; i < _ctx.Length("GetDataServiceApi.Data.ScriptDetails.ScriptResponseParameters.Length"); i++) {
				GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptResponseParameter scriptResponseParameter = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_ScriptDetails.GetDataServiceApi_ScriptResponseParameter();
				scriptResponseParameter.ColumnName = _ctx.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ColumnName");
				scriptResponseParameter.ExampleValue = _ctx.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ExampleValue");
				scriptResponseParameter.ParameterDataType = _ctx.IntegerValue("GetDataServiceApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ParameterDataType");
				scriptResponseParameter.ParameterDescription = _ctx.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ParameterDescription");
				scriptResponseParameter.ParameterName = _ctx.StringValue("GetDataServiceApi.Data.ScriptDetails.ScriptResponseParameters["+ i +"].ParameterName");

				scriptDetails_scriptResponseParameters.Add(scriptResponseParameter);
			}
			scriptDetails.ScriptResponseParameters = scriptDetails_scriptResponseParameters;
			data.ScriptDetails = scriptDetails;

			GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails wizardDetails = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails();
			wizardDetails.IsPagedResponse = _ctx.BooleanValue("GetDataServiceApi.Data.WizardDetails.IsPagedResponse");

			GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardConnection wizardConnection = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardConnection();
			wizardConnection.ConnectionId = _ctx.LongValue("GetDataServiceApi.Data.WizardDetails.WizardConnection.ConnectionId");
			wizardConnection.TableName = _ctx.StringValue("GetDataServiceApi.Data.WizardDetails.WizardConnection.TableName");
			wizardDetails.WizardConnection = wizardConnection;

			List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardRequestParameter> wizardDetails_wizardRequestParameters = new List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardRequestParameter>();
			for (int i = 0; i < _ctx.Length("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters.Length"); i++) {
				GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardRequestParameter wizardRequestParameter = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardRequestParameter();
				wizardRequestParameter.ColumnName = _ctx.StringValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ColumnName");
				wizardRequestParameter.DefaultValue = _ctx.StringValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].DefaultValue");
				wizardRequestParameter.ExampleValue = _ctx.StringValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ExampleValue");
				wizardRequestParameter.IsRequiredParameter = _ctx.BooleanValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].IsRequiredParameter");
				wizardRequestParameter.ParameterDataType = _ctx.IntegerValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterDataType");
				wizardRequestParameter.ParameterDescription = _ctx.StringValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterDescription");
				wizardRequestParameter.ParameterName = _ctx.StringValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterName");
				wizardRequestParameter.ParameterOperator = _ctx.IntegerValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterOperator");
				wizardRequestParameter.ParameterPosition = _ctx.IntegerValue("GetDataServiceApi.Data.WizardDetails.WizardRequestParameters["+ i +"].ParameterPosition");

				wizardDetails_wizardRequestParameters.Add(wizardRequestParameter);
			}
			wizardDetails.WizardRequestParameters = wizardDetails_wizardRequestParameters;

			List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardResponseParameter> wizardDetails_wizardResponseParameters = new List<GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardResponseParameter>();
			for (int i = 0; i < _ctx.Length("GetDataServiceApi.Data.WizardDetails.WizardResponseParameters.Length"); i++) {
				GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardResponseParameter wizardResponseParameter = new GetDataServiceApiResponse.GetDataServiceApi_Data.GetDataServiceApi_WizardDetails.GetDataServiceApi_WizardResponseParameter();
				wizardResponseParameter.ColumnName = _ctx.StringValue("GetDataServiceApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ColumnName");
				wizardResponseParameter.ExampleValue = _ctx.StringValue("GetDataServiceApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ExampleValue");
				wizardResponseParameter.ParameterDataType = _ctx.IntegerValue("GetDataServiceApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ParameterDataType");
				wizardResponseParameter.ParameterDescription = _ctx.StringValue("GetDataServiceApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ParameterDescription");
				wizardResponseParameter.ParameterName = _ctx.StringValue("GetDataServiceApi.Data.WizardDetails.WizardResponseParameters["+ i +"].ParameterName");

				wizardDetails_wizardResponseParameters.Add(wizardResponseParameter);
			}
			wizardDetails.WizardResponseParameters = wizardDetails_wizardResponseParameters;
			data.WizardDetails = wizardDetails;
			getDataServiceApiResponse.Data = data;
        
			return getDataServiceApiResponse;
        }
    }
}
