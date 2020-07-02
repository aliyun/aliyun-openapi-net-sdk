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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class GetDataServiceApiResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private string requestId;

		private bool? success;

		private GetDataServiceApi_Data data;

		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public GetDataServiceApi_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetDataServiceApi_Data
		{

			private long? apiId;

			private int? apiMode;

			private string apiName;

			private string apiPath;

			private string createdTime;

			private string creatorId;

			private string description;

			private string groupId;

			private string modifiedTime;

			private string operatorId;

			private long? projectId;

			private int? requestMethod;

			private int? responseContentType;

			private int? status;

			private long? tenantId;

			private int? timeout;

			private int? visibleRange;

			private List<string> protocols;

			private GetDataServiceApi_RegistrationDetails registrationDetails;

			private GetDataServiceApi_ScriptDetails scriptDetails;

			private GetDataServiceApi_WizardDetails wizardDetails;

			public long? ApiId
			{
				get
				{
					return apiId;
				}
				set	
				{
					apiId = value;
				}
			}

			public int? ApiMode
			{
				get
				{
					return apiMode;
				}
				set	
				{
					apiMode = value;
				}
			}

			public string ApiName
			{
				get
				{
					return apiName;
				}
				set	
				{
					apiName = value;
				}
			}

			public string ApiPath
			{
				get
				{
					return apiPath;
				}
				set	
				{
					apiPath = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public string CreatorId
			{
				get
				{
					return creatorId;
				}
				set	
				{
					creatorId = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
				}
			}

			public string OperatorId
			{
				get
				{
					return operatorId;
				}
				set	
				{
					operatorId = value;
				}
			}

			public long? ProjectId
			{
				get
				{
					return projectId;
				}
				set	
				{
					projectId = value;
				}
			}

			public int? RequestMethod
			{
				get
				{
					return requestMethod;
				}
				set	
				{
					requestMethod = value;
				}
			}

			public int? ResponseContentType
			{
				get
				{
					return responseContentType;
				}
				set	
				{
					responseContentType = value;
				}
			}

			public int? Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public long? TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public int? Timeout
			{
				get
				{
					return timeout;
				}
				set	
				{
					timeout = value;
				}
			}

			public int? VisibleRange
			{
				get
				{
					return visibleRange;
				}
				set	
				{
					visibleRange = value;
				}
			}

			public List<string> Protocols
			{
				get
				{
					return protocols;
				}
				set	
				{
					protocols = value;
				}
			}

			public GetDataServiceApi_RegistrationDetails RegistrationDetails
			{
				get
				{
					return registrationDetails;
				}
				set	
				{
					registrationDetails = value;
				}
			}

			public GetDataServiceApi_ScriptDetails ScriptDetails
			{
				get
				{
					return scriptDetails;
				}
				set	
				{
					scriptDetails = value;
				}
			}

			public GetDataServiceApi_WizardDetails WizardDetails
			{
				get
				{
					return wizardDetails;
				}
				set	
				{
					wizardDetails = value;
				}
			}

			public class GetDataServiceApi_RegistrationDetails
			{

				private string failedResultSample;

				private int? serviceContentType;

				private string serviceHost;

				private string servicePath;

				private string serviceRequestBodyDescription;

				private string successfulResultSample;

				private List<GetDataServiceApi_RegistrationErrorCode> registrationErrorCodes;

				private List<GetDataServiceApi_RegistrationRequestParameter> registrationRequestParameters;

				public string FailedResultSample
				{
					get
					{
						return failedResultSample;
					}
					set	
					{
						failedResultSample = value;
					}
				}

				public int? ServiceContentType
				{
					get
					{
						return serviceContentType;
					}
					set	
					{
						serviceContentType = value;
					}
				}

				public string ServiceHost
				{
					get
					{
						return serviceHost;
					}
					set	
					{
						serviceHost = value;
					}
				}

				public string ServicePath
				{
					get
					{
						return servicePath;
					}
					set	
					{
						servicePath = value;
					}
				}

				public string ServiceRequestBodyDescription
				{
					get
					{
						return serviceRequestBodyDescription;
					}
					set	
					{
						serviceRequestBodyDescription = value;
					}
				}

				public string SuccessfulResultSample
				{
					get
					{
						return successfulResultSample;
					}
					set	
					{
						successfulResultSample = value;
					}
				}

				public List<GetDataServiceApi_RegistrationErrorCode> RegistrationErrorCodes
				{
					get
					{
						return registrationErrorCodes;
					}
					set	
					{
						registrationErrorCodes = value;
					}
				}

				public List<GetDataServiceApi_RegistrationRequestParameter> RegistrationRequestParameters
				{
					get
					{
						return registrationRequestParameters;
					}
					set	
					{
						registrationRequestParameters = value;
					}
				}

				public class GetDataServiceApi_RegistrationErrorCode
				{

					private string errorCode;

					private string errorMessage;

					private string errorSolution;

					public string ErrorCode
					{
						get
						{
							return errorCode;
						}
						set	
						{
							errorCode = value;
						}
					}

					public string ErrorMessage
					{
						get
						{
							return errorMessage;
						}
						set	
						{
							errorMessage = value;
						}
					}

					public string ErrorSolution
					{
						get
						{
							return errorSolution;
						}
						set	
						{
							errorSolution = value;
						}
					}
				}

				public class GetDataServiceApi_RegistrationRequestParameter
				{

					private string columnName;

					private string defaultValue;

					private string exampleValue;

					private bool? isRequiredParameter;

					private int? parameterDataType;

					private string parameterDescription;

					private string parameterName;

					private int? parameterOperator;

					private int? parameterPosition;

					public string ColumnName
					{
						get
						{
							return columnName;
						}
						set	
						{
							columnName = value;
						}
					}

					public string DefaultValue
					{
						get
						{
							return defaultValue;
						}
						set	
						{
							defaultValue = value;
						}
					}

					public string ExampleValue
					{
						get
						{
							return exampleValue;
						}
						set	
						{
							exampleValue = value;
						}
					}

					public bool? IsRequiredParameter
					{
						get
						{
							return isRequiredParameter;
						}
						set	
						{
							isRequiredParameter = value;
						}
					}

					public int? ParameterDataType
					{
						get
						{
							return parameterDataType;
						}
						set	
						{
							parameterDataType = value;
						}
					}

					public string ParameterDescription
					{
						get
						{
							return parameterDescription;
						}
						set	
						{
							parameterDescription = value;
						}
					}

					public string ParameterName
					{
						get
						{
							return parameterName;
						}
						set	
						{
							parameterName = value;
						}
					}

					public int? ParameterOperator
					{
						get
						{
							return parameterOperator;
						}
						set	
						{
							parameterOperator = value;
						}
					}

					public int? ParameterPosition
					{
						get
						{
							return parameterPosition;
						}
						set	
						{
							parameterPosition = value;
						}
					}
				}
			}

			public class GetDataServiceApi_ScriptDetails
			{

				private bool? isPagedResponse;

				private string script;

				private List<GetDataServiceApi_ScriptRequestParameter> scriptRequestParameters;

				private List<GetDataServiceApi_ScriptResponseParameter> scriptResponseParameters;

				private GetDataServiceApi_ScriptConnection scriptConnection;

				public bool? IsPagedResponse
				{
					get
					{
						return isPagedResponse;
					}
					set	
					{
						isPagedResponse = value;
					}
				}

				public string Script
				{
					get
					{
						return script;
					}
					set	
					{
						script = value;
					}
				}

				public List<GetDataServiceApi_ScriptRequestParameter> ScriptRequestParameters
				{
					get
					{
						return scriptRequestParameters;
					}
					set	
					{
						scriptRequestParameters = value;
					}
				}

				public List<GetDataServiceApi_ScriptResponseParameter> ScriptResponseParameters
				{
					get
					{
						return scriptResponseParameters;
					}
					set	
					{
						scriptResponseParameters = value;
					}
				}

				public GetDataServiceApi_ScriptConnection ScriptConnection
				{
					get
					{
						return scriptConnection;
					}
					set	
					{
						scriptConnection = value;
					}
				}

				public class GetDataServiceApi_ScriptRequestParameter
				{

					private string columnName;

					private string defaultValue;

					private string exampleValue;

					private bool? isRequiredParameter;

					private int? parameterDataType;

					private string parameterDescription;

					private string parameterName;

					private int? parameterOperator;

					private int? parameterPosition;

					public string ColumnName
					{
						get
						{
							return columnName;
						}
						set	
						{
							columnName = value;
						}
					}

					public string DefaultValue
					{
						get
						{
							return defaultValue;
						}
						set	
						{
							defaultValue = value;
						}
					}

					public string ExampleValue
					{
						get
						{
							return exampleValue;
						}
						set	
						{
							exampleValue = value;
						}
					}

					public bool? IsRequiredParameter
					{
						get
						{
							return isRequiredParameter;
						}
						set	
						{
							isRequiredParameter = value;
						}
					}

					public int? ParameterDataType
					{
						get
						{
							return parameterDataType;
						}
						set	
						{
							parameterDataType = value;
						}
					}

					public string ParameterDescription
					{
						get
						{
							return parameterDescription;
						}
						set	
						{
							parameterDescription = value;
						}
					}

					public string ParameterName
					{
						get
						{
							return parameterName;
						}
						set	
						{
							parameterName = value;
						}
					}

					public int? ParameterOperator
					{
						get
						{
							return parameterOperator;
						}
						set	
						{
							parameterOperator = value;
						}
					}

					public int? ParameterPosition
					{
						get
						{
							return parameterPosition;
						}
						set	
						{
							parameterPosition = value;
						}
					}
				}

				public class GetDataServiceApi_ScriptResponseParameter
				{

					private string columnName;

					private string exampleValue;

					private int? parameterDataType;

					private string parameterDescription;

					private string parameterName;

					public string ColumnName
					{
						get
						{
							return columnName;
						}
						set	
						{
							columnName = value;
						}
					}

					public string ExampleValue
					{
						get
						{
							return exampleValue;
						}
						set	
						{
							exampleValue = value;
						}
					}

					public int? ParameterDataType
					{
						get
						{
							return parameterDataType;
						}
						set	
						{
							parameterDataType = value;
						}
					}

					public string ParameterDescription
					{
						get
						{
							return parameterDescription;
						}
						set	
						{
							parameterDescription = value;
						}
					}

					public string ParameterName
					{
						get
						{
							return parameterName;
						}
						set	
						{
							parameterName = value;
						}
					}
				}

				public class GetDataServiceApi_ScriptConnection
				{

					private long? connectionId;

					private string tableName;

					public long? ConnectionId
					{
						get
						{
							return connectionId;
						}
						set	
						{
							connectionId = value;
						}
					}

					public string TableName
					{
						get
						{
							return tableName;
						}
						set	
						{
							tableName = value;
						}
					}
				}
			}

			public class GetDataServiceApi_WizardDetails
			{

				private bool? isPagedResponse;

				private List<GetDataServiceApi_WizardRequestParameter> wizardRequestParameters;

				private List<GetDataServiceApi_WizardResponseParameter> wizardResponseParameters;

				private GetDataServiceApi_WizardConnection wizardConnection;

				public bool? IsPagedResponse
				{
					get
					{
						return isPagedResponse;
					}
					set	
					{
						isPagedResponse = value;
					}
				}

				public List<GetDataServiceApi_WizardRequestParameter> WizardRequestParameters
				{
					get
					{
						return wizardRequestParameters;
					}
					set	
					{
						wizardRequestParameters = value;
					}
				}

				public List<GetDataServiceApi_WizardResponseParameter> WizardResponseParameters
				{
					get
					{
						return wizardResponseParameters;
					}
					set	
					{
						wizardResponseParameters = value;
					}
				}

				public GetDataServiceApi_WizardConnection WizardConnection
				{
					get
					{
						return wizardConnection;
					}
					set	
					{
						wizardConnection = value;
					}
				}

				public class GetDataServiceApi_WizardRequestParameter
				{

					private string columnName;

					private string defaultValue;

					private string exampleValue;

					private bool? isRequiredParameter;

					private int? parameterDataType;

					private string parameterDescription;

					private string parameterName;

					private int? parameterOperator;

					private int? parameterPosition;

					public string ColumnName
					{
						get
						{
							return columnName;
						}
						set	
						{
							columnName = value;
						}
					}

					public string DefaultValue
					{
						get
						{
							return defaultValue;
						}
						set	
						{
							defaultValue = value;
						}
					}

					public string ExampleValue
					{
						get
						{
							return exampleValue;
						}
						set	
						{
							exampleValue = value;
						}
					}

					public bool? IsRequiredParameter
					{
						get
						{
							return isRequiredParameter;
						}
						set	
						{
							isRequiredParameter = value;
						}
					}

					public int? ParameterDataType
					{
						get
						{
							return parameterDataType;
						}
						set	
						{
							parameterDataType = value;
						}
					}

					public string ParameterDescription
					{
						get
						{
							return parameterDescription;
						}
						set	
						{
							parameterDescription = value;
						}
					}

					public string ParameterName
					{
						get
						{
							return parameterName;
						}
						set	
						{
							parameterName = value;
						}
					}

					public int? ParameterOperator
					{
						get
						{
							return parameterOperator;
						}
						set	
						{
							parameterOperator = value;
						}
					}

					public int? ParameterPosition
					{
						get
						{
							return parameterPosition;
						}
						set	
						{
							parameterPosition = value;
						}
					}
				}

				public class GetDataServiceApi_WizardResponseParameter
				{

					private string columnName;

					private string exampleValue;

					private int? parameterDataType;

					private string parameterDescription;

					private string parameterName;

					public string ColumnName
					{
						get
						{
							return columnName;
						}
						set	
						{
							columnName = value;
						}
					}

					public string ExampleValue
					{
						get
						{
							return exampleValue;
						}
						set	
						{
							exampleValue = value;
						}
					}

					public int? ParameterDataType
					{
						get
						{
							return parameterDataType;
						}
						set	
						{
							parameterDataType = value;
						}
					}

					public string ParameterDescription
					{
						get
						{
							return parameterDescription;
						}
						set	
						{
							parameterDescription = value;
						}
					}

					public string ParameterName
					{
						get
						{
							return parameterName;
						}
						set	
						{
							parameterName = value;
						}
					}
				}

				public class GetDataServiceApi_WizardConnection
				{

					private long? connectionId;

					private string tableName;

					public long? ConnectionId
					{
						get
						{
							return connectionId;
						}
						set	
						{
							connectionId = value;
						}
					}

					public string TableName
					{
						get
						{
							return tableName;
						}
						set	
						{
							tableName = value;
						}
					}
				}
			}
		}
	}
}
