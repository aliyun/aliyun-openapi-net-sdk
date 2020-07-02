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
        public static ListDataServiceApisResponse Unmarshall(UnmarshallerContext context)
        {
			ListDataServiceApisResponse listDataServiceApisResponse = new ListDataServiceApisResponse();

			listDataServiceApisResponse.HttpResponse = context.HttpResponse;
			listDataServiceApisResponse.ErrorCode = context.StringValue("ListDataServiceApis.ErrorCode");
			listDataServiceApisResponse.ErrorMessage = context.StringValue("ListDataServiceApis.ErrorMessage");
			listDataServiceApisResponse.HttpStatusCode = context.IntegerValue("ListDataServiceApis.HttpStatusCode");
			listDataServiceApisResponse.RequestId = context.StringValue("ListDataServiceApis.RequestId");
			listDataServiceApisResponse.Success = context.BooleanValue("ListDataServiceApis.Success");

			ListDataServiceApisResponse.ListDataServiceApis_Data data = new ListDataServiceApisResponse.ListDataServiceApis_Data();
			data.PageNumber = context.IntegerValue("ListDataServiceApis.Data.PageNumber");
			data.PageSize = context.IntegerValue("ListDataServiceApis.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListDataServiceApis.Data.TotalCount");

			List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api> data_apis = new List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api>();
			for (int i = 0; i < context.Length("ListDataServiceApis.Data.Apis.Length"); i++) {
				ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api api = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api();
				api.ApiId = context.LongValue("ListDataServiceApis.Data.Apis["+ i +"].ApiId");
				api.ApiMode = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].ApiMode");
				api.ApiName = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ApiName");
				api.ApiPath = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ApiPath");
				api.CreatedTime = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].CreatedTime");
				api.CreatorId = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].CreatorId");
				api.Description = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].Description");
				api.GroupId = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].GroupId");
				api.ModifiedTime = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ModifiedTime");
				api.OperatorId = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].OperatorId");
				api.ProjectId = context.LongValue("ListDataServiceApis.Data.Apis["+ i +"].ProjectId");
				api.RequestMethod = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].RequestMethod");
				api.ResponseContentType = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].ResponseContentType");
				api.Status = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].Status");
				api.TenantId = context.LongValue("ListDataServiceApis.Data.Apis["+ i +"].TenantId");
				api.Timeout = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].Timeout");
				api.VisibleRange = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].VisibleRange");

				List<string> api_protocols = new List<string>();
				for (int j = 0; j < context.Length("ListDataServiceApis.Data.Apis["+ i +"].Protocols.Length"); j++) {
					api_protocols.Add(context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].Protocols["+ j +"]"));
				}
				api.Protocols = api_protocols;

				ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails registrationDetails = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails();
				registrationDetails.FailedResultSample = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.FailedResultSample");
				registrationDetails.ServiceContentType = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.ServiceContentType");
				registrationDetails.ServiceHost = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.ServiceHost");
				registrationDetails.ServicePath = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.ServicePath");
				registrationDetails.ServiceRequestBodyDescription = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.ServiceRequestBodyDescription");
				registrationDetails.SuccessfulResultSample = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.SuccessfulResultSample");

				List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationErrorCode> registrationDetails_registrationErrorCodes = new List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationErrorCode>();
				for (int j = 0; j < context.Length("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationErrorCodes.Length"); j++) {
					ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationErrorCode registrationErrorCode = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationErrorCode();
					registrationErrorCode.ErrorCode = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationErrorCodes["+ j +"].ErrorCode");
					registrationErrorCode.ErrorMessage = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationErrorCodes["+ j +"].ErrorMessage");
					registrationErrorCode.ErrorSolution = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationErrorCodes["+ j +"].ErrorSolution");

					registrationDetails_registrationErrorCodes.Add(registrationErrorCode);
				}
				registrationDetails.RegistrationErrorCodes = registrationDetails_registrationErrorCodes;

				List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationRequestParameter> registrationDetails_registrationRequestParameters = new List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationRequestParameter>();
				for (int j = 0; j < context.Length("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters.Length"); j++) {
					ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationRequestParameter registrationRequestParameter = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_RegistrationDetails.ListDataServiceApis_RegistrationRequestParameter();
					registrationRequestParameter.ColumnName = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ColumnName");
					registrationRequestParameter.DefaultValue = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].DefaultValue");
					registrationRequestParameter.ExampleValue = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ExampleValue");
					registrationRequestParameter.IsRequiredParameter = context.BooleanValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].IsRequiredParameter");
					registrationRequestParameter.ParameterDataType = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterDataType");
					registrationRequestParameter.ParameterDescription = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterDescription");
					registrationRequestParameter.ParameterName = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterName");
					registrationRequestParameter.ParameterOperator = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterOperator");
					registrationRequestParameter.ParameterPosition = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].RegistrationDetails.RegistrationRequestParameters["+ j +"].ParameterPosition");

					registrationDetails_registrationRequestParameters.Add(registrationRequestParameter);
				}
				registrationDetails.RegistrationRequestParameters = registrationDetails_registrationRequestParameters;
				api.RegistrationDetails = registrationDetails;

				ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails scriptDetails = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails();
				scriptDetails.IsPagedResponse = context.BooleanValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.IsPagedResponse");
				scriptDetails.Script = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.Script");

				ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptConnection scriptConnection = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptConnection();
				scriptConnection.ConnectionId = context.LongValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptConnection.ConnectionId");
				scriptConnection.TableName = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptConnection.TableName");
				scriptDetails.ScriptConnection = scriptConnection;

				List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptRequestParameter> scriptDetails_scriptRequestParameters = new List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptRequestParameter>();
				for (int j = 0; j < context.Length("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters.Length"); j++) {
					ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptRequestParameter scriptRequestParameter = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptRequestParameter();
					scriptRequestParameter.ColumnName = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ColumnName");
					scriptRequestParameter.DefaultValue = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].DefaultValue");
					scriptRequestParameter.ExampleValue = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ExampleValue");
					scriptRequestParameter.IsRequiredParameter = context.BooleanValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].IsRequiredParameter");
					scriptRequestParameter.ParameterDataType = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterDataType");
					scriptRequestParameter.ParameterDescription = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterDescription");
					scriptRequestParameter.ParameterName = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterName");
					scriptRequestParameter.ParameterOperator = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterOperator");
					scriptRequestParameter.ParameterPosition = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptRequestParameters["+ j +"].ParameterPosition");

					scriptDetails_scriptRequestParameters.Add(scriptRequestParameter);
				}
				scriptDetails.ScriptRequestParameters = scriptDetails_scriptRequestParameters;

				List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptResponseParameter> scriptDetails_scriptResponseParameters = new List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptResponseParameter>();
				for (int j = 0; j < context.Length("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters.Length"); j++) {
					ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptResponseParameter scriptResponseParameter = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_ScriptDetails.ListDataServiceApis_ScriptResponseParameter();
					scriptResponseParameter.ColumnName = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters["+ j +"].ColumnName");
					scriptResponseParameter.ExampleValue = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters["+ j +"].ExampleValue");
					scriptResponseParameter.ParameterDataType = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters["+ j +"].ParameterDataType");
					scriptResponseParameter.ParameterDescription = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters["+ j +"].ParameterDescription");
					scriptResponseParameter.ParameterName = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].ScriptDetails.ScriptResponseParameters["+ j +"].ParameterName");

					scriptDetails_scriptResponseParameters.Add(scriptResponseParameter);
				}
				scriptDetails.ScriptResponseParameters = scriptDetails_scriptResponseParameters;
				api.ScriptDetails = scriptDetails;

				ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails wizardDetails = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails();
				wizardDetails.IsPagedResponse = context.BooleanValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.IsPagedResponse");

				ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardConnection wizardConnection = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardConnection();
				wizardConnection.ConnectionId = context.LongValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardConnection.ConnectionId");
				wizardConnection.TableName = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardConnection.TableName");
				wizardDetails.WizardConnection = wizardConnection;

				List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardRequestParameter> wizardDetails_wizardRequestParameters = new List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardRequestParameter>();
				for (int j = 0; j < context.Length("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters.Length"); j++) {
					ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardRequestParameter wizardRequestParameter = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardRequestParameter();
					wizardRequestParameter.ColumnName = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ColumnName");
					wizardRequestParameter.DefaultValue = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].DefaultValue");
					wizardRequestParameter.ExampleValue = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ExampleValue");
					wizardRequestParameter.IsRequiredParameter = context.BooleanValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].IsRequiredParameter");
					wizardRequestParameter.ParameterDataType = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterDataType");
					wizardRequestParameter.ParameterDescription = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterDescription");
					wizardRequestParameter.ParameterName = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterName");
					wizardRequestParameter.ParameterOperator = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterOperator");
					wizardRequestParameter.ParameterPosition = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardRequestParameters["+ j +"].ParameterPosition");

					wizardDetails_wizardRequestParameters.Add(wizardRequestParameter);
				}
				wizardDetails.WizardRequestParameters = wizardDetails_wizardRequestParameters;

				List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardResponseParameter> wizardDetails_wizardResponseParameters = new List<ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardResponseParameter>();
				for (int j = 0; j < context.Length("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters.Length"); j++) {
					ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardResponseParameter wizardResponseParameter = new ListDataServiceApisResponse.ListDataServiceApis_Data.ListDataServiceApis_Api.ListDataServiceApis_WizardDetails.ListDataServiceApis_WizardResponseParameter();
					wizardResponseParameter.ColumnName = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters["+ j +"].ColumnName");
					wizardResponseParameter.ExampleValue = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters["+ j +"].ExampleValue");
					wizardResponseParameter.ParameterDataType = context.IntegerValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters["+ j +"].ParameterDataType");
					wizardResponseParameter.ParameterDescription = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters["+ j +"].ParameterDescription");
					wizardResponseParameter.ParameterName = context.StringValue("ListDataServiceApis.Data.Apis["+ i +"].WizardDetails.WizardResponseParameters["+ j +"].ParameterName");

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
