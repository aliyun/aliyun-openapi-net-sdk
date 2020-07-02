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
	public class GetDataServicePublishedApiResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private int? httpStatusCode;

		private string requestId;

		private bool? success;

		private GetDataServicePublishedApi_Data data;

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

		public GetDataServicePublishedApi_Data Data
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

		public class GetDataServicePublishedApi_Data
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

			private GetDataServicePublishedApi_RegistrationDetails registrationDetails;

			private GetDataServicePublishedApi_ScriptDetails scriptDetails;

			private GetDataServicePublishedApi_WizardDetails wizardDetails;

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

			public GetDataServicePublishedApi_RegistrationDetails RegistrationDetails
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

			public GetDataServicePublishedApi_ScriptDetails ScriptDetails
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

			public GetDataServicePublishedApi_WizardDetails WizardDetails
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

			public class GetDataServicePublishedApi_RegistrationDetails
			{

				private string failedResultSample;

				private int? serviceContentType;

				private string serviceHost;

				private string servicePath;

				private string serviceRequestBodyDescription;

				private string successfulResultSample;

				private List<GetDataServicePublishedApi_RegistrationErrorCode> registrationErrorCodes;

				private List<GetDataServicePublishedApi_RegistrationRequestParameter> registrationRequestParameters;

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

				public List<GetDataServicePublishedApi_RegistrationErrorCode> RegistrationErrorCodes
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

				public List<GetDataServicePublishedApi_RegistrationRequestParameter> RegistrationRequestParameters
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

				public class GetDataServicePublishedApi_RegistrationErrorCode
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

				public class GetDataServicePublishedApi_RegistrationRequestParameter
				{

					private string defaultValue;

					private string exampleValue;

					private bool? isRequiredParameter;

					private int? parameterDataType;

					private string parameterDescription;

					private string parameterName;

					private int? parameterOperator;

					private int? parameterPosition;

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

			public class GetDataServicePublishedApi_ScriptDetails
			{

				private string failedResultSample;

				private bool? isPagedResponse;

				private string script;

				private string successfulResultSample;

				private List<GetDataServicePublishedApi_ScriptErrorCode> scriptErrorCodes;

				private List<GetDataServicePublishedApi_ScriptRequestParameter> scriptRequestParameters;

				private List<GetDataServicePublishedApi_ScriptResponseParameter> scriptResponseParameters;

				private GetDataServicePublishedApi_ScriptConnection scriptConnection;

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

				public List<GetDataServicePublishedApi_ScriptErrorCode> ScriptErrorCodes
				{
					get
					{
						return scriptErrorCodes;
					}
					set	
					{
						scriptErrorCodes = value;
					}
				}

				public List<GetDataServicePublishedApi_ScriptRequestParameter> ScriptRequestParameters
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

				public List<GetDataServicePublishedApi_ScriptResponseParameter> ScriptResponseParameters
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

				public GetDataServicePublishedApi_ScriptConnection ScriptConnection
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

				public class GetDataServicePublishedApi_ScriptErrorCode
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

				public class GetDataServicePublishedApi_ScriptRequestParameter
				{

					private string defaultValue;

					private string exampleValue;

					private bool? isRequiredParameter;

					private int? parameterDataType;

					private string parameterDescription;

					private string parameterName;

					private int? parameterOperator;

					private int? parameterPosition;

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

				public class GetDataServicePublishedApi_ScriptResponseParameter
				{

					private string exampleValue;

					private int? parameterDataType;

					private string parameterDescription;

					private string parameterName;

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

				public class GetDataServicePublishedApi_ScriptConnection
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

			public class GetDataServicePublishedApi_WizardDetails
			{

				private string failedResultSample;

				private bool? isPagedResponse;

				private string successfulResultSample;

				private List<GetDataServicePublishedApi_WizardErrorCode> wizardErrorCodes;

				private List<GetDataServicePublishedApi_WizardRequestParameter> wizardRequestParameters;

				private List<GetDataServicePublishedApi_WizardResponseParameter> wizardResponseParameters;

				private GetDataServicePublishedApi_WizardConnection wizardConnection;

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

				public List<GetDataServicePublishedApi_WizardErrorCode> WizardErrorCodes
				{
					get
					{
						return wizardErrorCodes;
					}
					set	
					{
						wizardErrorCodes = value;
					}
				}

				public List<GetDataServicePublishedApi_WizardRequestParameter> WizardRequestParameters
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

				public List<GetDataServicePublishedApi_WizardResponseParameter> WizardResponseParameters
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

				public GetDataServicePublishedApi_WizardConnection WizardConnection
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

				public class GetDataServicePublishedApi_WizardErrorCode
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

				public class GetDataServicePublishedApi_WizardRequestParameter
				{

					private string defaultValue;

					private string exampleValue;

					private bool? isRequiredParameter;

					private int? parameterDataType;

					private string parameterDescription;

					private string parameterName;

					private int? parameterOperator;

					private int? parameterPosition;

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

				public class GetDataServicePublishedApi_WizardResponseParameter
				{

					private string exampleValue;

					private int? parameterDataType;

					private string parameterDescription;

					private string parameterName;

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

				public class GetDataServicePublishedApi_WizardConnection
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
