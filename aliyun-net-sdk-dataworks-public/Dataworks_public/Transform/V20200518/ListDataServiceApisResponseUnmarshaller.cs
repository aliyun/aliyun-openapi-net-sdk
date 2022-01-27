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
    public class ListDataServiceApisResponseUnmarshaller
    {
        public static ListDataServiceApisResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataServiceApisResponse listDataServiceApisResponse = new ListDataServiceApisResponse();

			listDataServiceApisResponse.HttpResponse = _ctx.HttpResponse;
			listDataServiceApisResponse.ErrorCode = _ctx.StringValue("ListDataServiceApis.ErrorCode");
			listDataServiceApisResponse.ErrorMessage = _ctx.StringValue("ListDataServiceApis.ErrorMessage");
			listDataServiceApisResponse.HttpStatusCode = _ctx.IntegerValue("ListDataServiceApis.HttpStatusCode");
			listDataServiceApisResponse.RequestId = _ctx.StringValue("ListDataServiceApis.RequestId");
			listDataServiceApisResponse.Success = _ctx.BooleanValue("ListDataServiceApis.Success");

			ListDataServiceApisResponse.ListDataServiceApis_Data data = new ListDataServiceApisResponse.ListDataServiceApis_Data();
			data.PageNumber = _ctx.IntegerValue("ListDataServiceApis.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListDataServiceApis.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListDataServiceApis.Data.TotalCount");

			List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api> data_apis = new List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api>();
			for (int i = 0; i < _ctx.Length("ListDataServiceApis.Data.Apis.Length"); i++) {
				ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api api = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api();
				api.ApiId = _ctx.LongValue("ListDataServiceApis.Data.Apis["+ i +"].ApiId");
				api.ApiMode = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].ApiMode");
				api.ApiName = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ApiName");
				api.ApiPath = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ApiPath");
				api.CreatedTime = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].CreatedTime");
				api.CreatorId = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].CreatorId");
				api.Description = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].Description");
				api.GroupId = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].GroupId");
				api.ModifiedTime = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ModifiedTime");
				api.OperatorId = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].OperatorId");
				api.ProjectId = _ctx.LongValue("ListDataServiceApis.Data.Apis["+ i +"].ProjectId");
				api.RequestMethod = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].RequestMethod");
				api.ResponseContentType = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].ResponseContentType");
				api.Status = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].Status");
				api.TenantId = _ctx.LongValue("ListDataServiceApis.Data.Apis["+ i +"].TenantId");
				api.Timeout = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].Timeout");
				api.VisibleRange = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].VisibleRange");
				api.FolderId = _ctx.LongValue("ListDataServiceApis.Data.Apis["+ i +"].FolderId");

				List<string> api_protocols = new List<string>();
				for (int j = 0; j < _ctx.Length("ListDataServiceApis.Data.Apis["+ i +"].Protocols.Length"); j++) {
					api_protocols.Add(_ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].Protocols["+ j +"]"));
				}
				api.Protocols = api_protocols;

				ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails registrationDetails = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails();
				registrationDetails.FailedResultSample = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.FailedResultSample");
				registrationDetails.ServiceContentType = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.ServiceContentType");
				registrationDetails.ServiceHost = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.ServiceHost");
				registrationDetails.ServicePath = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.ServicePath");
				registrationDetails.ServiceRequestBodyDescription = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.ServiceRequestBodyDescription");
				registrationDetails.SuccessfulResultSample = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.SuccessfulResultSample");

				List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationErrorCode> registrationDetails_registrationErrorCodes = new List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationErrorCode>();
				for (int j = 0; j < _ctx.Length("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationErrorCodes.Length"); j++) {
					ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationErrorCode registrationErrorCode = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationErrorCode();
					registrationErrorCode.ErrorCode = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationErrorCodes["+ j +"].ErrorCode");
					registrationErrorCode.ErrorMessage = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationErrorCodes["+ j +"].ErrorMessage");
					registrationErrorCode.ErrorSolution = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationErrorCodes["+ j +"].ErrorSolution");

					registrationDetails_registrationErrorCodes.Add(registrationErrorCode);
				}
				registrationDetails.RegistrationErrorCodes = registrationDetails_registrationErrorCodes;

				List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationRequestParameter> registrationDetails_registrationRequestParameters = new List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationRequestParameter>();
				for (int j = 0; j < _ctx.Length("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters.Length"); j++) {
					ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationRequestParameter registrationRequestParameter = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationRequestParameter();
					registrationRequestParameter.ColumnName = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ColumnName");
					registrationRequestParameter.DefaultValue = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].DefaultValue");
					registrationRequestParameter.ExampleValue = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ExampleValue");
					registrationRequestParameter.IsRequiredParameter = _ctx.BooleanValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].IsRequiredParameter");
					registrationRequestParameter.ParameterDataType = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterDataType");
					registrationRequestParameter.ParameterDescription = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterDescription");
					registrationRequestParameter.ParameterName = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterName");
					registrationRequestParameter.ParameterOperator = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterOperator");
					registrationRequestParameter.ParameterPosition = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterPosition");

					registrationDetails_registrationRequestParameters.Add(registrationRequestParameter);
				}
				registrationDetails.RegistrationRequestParameters = registrationDetails_registrationRequestParameters;
				api.RegistrationDetails = registrationDetails;

				ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails scriptDetails = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails();
				scriptDetails.IsPagedResponse = _ctx.BooleanValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.IsPagedResponse");
				scriptDetails.Script = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.Script");

				ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptConnection scriptConnection = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptConnection();
				scriptConnection.ConnectionId = _ctx.LongValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptConnection.ConnectionId");
				scriptConnection.TableName = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptConnection.TableName");
				scriptDetails.ScriptConnection = scriptConnection;

				List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptRequestParameter> scriptDetails_scriptRequestParameters = new List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptRequestParameter>();
				for (int j = 0; j < _ctx.Length("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters.Length"); j++) {
					ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptRequestParameter scriptRequestParameter = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptRequestParameter();
					scriptRequestParameter.ColumnName = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ColumnName");
					scriptRequestParameter.DefaultValue = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].DefaultValue");
					scriptRequestParameter.ExampleValue = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ExampleValue");
					scriptRequestParameter.IsRequiredParameter = _ctx.BooleanValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].IsRequiredParameter");
					scriptRequestParameter.ParameterDataType = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterDataType");
					scriptRequestParameter.ParameterDescription = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterDescription");
					scriptRequestParameter.ParameterName = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterName");
					scriptRequestParameter.ParameterOperator = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterOperator");
					scriptRequestParameter.ParameterPosition = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterPosition");

					scriptDetails_scriptRequestParameters.Add(scriptRequestParameter);
				}
				scriptDetails.ScriptRequestParameters = scriptDetails_scriptRequestParameters;

				List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptResponseParameter> scriptDetails_scriptResponseParameters = new List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptResponseParameter>();
				for (int j = 0; j < _ctx.Length("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters.Length"); j++) {
					ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptResponseParameter scriptResponseParameter = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptResponseParameter();
					scriptResponseParameter.ColumnName = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters["+ j +"].ColumnName");
					scriptResponseParameter.ExampleValue = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters["+ j +"].ExampleValue");
					scriptResponseParameter.ParameterDataType = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters["+ j +"].ParameterDataType");
					scriptResponseParameter.ParameterDescription = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters["+ j +"].ParameterDescription");
					scriptResponseParameter.ParameterName = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters["+ j +"].ParameterName");

					scriptDetails_scriptResponseParameters.Add(scriptResponseParameter);
				}
				scriptDetails.ScriptResponseParameters = scriptDetails_scriptResponseParameters;
				api.ScriptDetails = scriptDetails;

				ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails wizardDetails = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails();
				wizardDetails.IsPagedResponse = _ctx.BooleanValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.IsPagedResponse");

				ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardConnection wizardConnection = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardConnection();
				wizardConnection.ConnectionId = _ctx.LongValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardConnection.ConnectionId");
				wizardConnection.TableName = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardConnection.TableName");
				wizardDetails.WizardConnection = wizardConnection;

				List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardRequestParameter> wizardDetails_wizardRequestParameters = new List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardRequestParameter>();
				for (int j = 0; j < _ctx.Length("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters.Length"); j++) {
					ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardRequestParameter wizardRequestParameter = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardRequestParameter();
					wizardRequestParameter.ColumnName = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ColumnName");
					wizardRequestParameter.DefaultValue = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].DefaultValue");
					wizardRequestParameter.ExampleValue = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ExampleValue");
					wizardRequestParameter.IsRequiredParameter = _ctx.BooleanValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].IsRequiredParameter");
					wizardRequestParameter.ParameterDataType = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterDataType");
					wizardRequestParameter.ParameterDescription = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterDescription");
					wizardRequestParameter.ParameterName = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterName");
					wizardRequestParameter.ParameterOperator = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterOperator");
					wizardRequestParameter.ParameterPosition = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterPosition");

					wizardDetails_wizardRequestParameters.Add(wizardRequestParameter);
				}
				wizardDetails.WizardRequestParameters = wizardDetails_wizardRequestParameters;

				List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardResponseParameter> wizardDetails_wizardResponseParameters = new List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardResponseParameter>();
				for (int j = 0; j < _ctx.Length("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters.Length"); j++) {
					ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardResponseParameter wizardResponseParameter = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardResponseParameter();
					wizardResponseParameter.ColumnName = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters["+ j +"].ColumnName");
					wizardResponseParameter.ExampleValue = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters["+ j +"].ExampleValue");
					wizardResponseParameter.ParameterDataType = _ctx.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters["+ j +"].ParameterDataType");
					wizardResponseParameter.ParameterDescription = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters["+ j +"].ParameterDescription");
					wizardResponseParameter.ParameterName = _ctx.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters["+ j +"].ParameterName");

					wizardDetails_wizardResponseParameters.Add(wizardResponseParameter);
				}
				wizardDetails.WizardResponseParameters = wizardDetails_wizardResponseParameters;
				api.WizardDetails = wizardDetails;

				data_apis.Add(api);
			}
			data.Apis = data_apis;
			listDataServiceApisResponse.Data = data;
        
			return listDataServiceApisResponse;
        }
    }
}
