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

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeApiResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private string apiId;

		private string apiName;

		private string groupId;

		private string groupName;

		private string visibility;

		private string authType;

		private string resultType;

		private string resultSample;

		private string failResultSample;

		private string createdTime;

		private string modifiedTime;

		private string description;

		private string mock;

		private string mockResult;

		private string allowSignatureMethod;

		private string webSocketApiType;

		private string resultBodyModel;

		private bool? forceNonceCheck;

		private bool? disableInternet;

		private string appCodeAuthType;

		private List<DescribeApi_ErrorCodeSample> errorCodeSamples;

		private List<DescribeApi_ResultDescription> resultDescriptions;

		private List<DescribeApi_SystemParameter> systemParameters;

		private List<DescribeApi_CustomSystemParameter> customSystemParameters;

		private List<DescribeApi_ConstantParameter> constantParameters;

		private List<DescribeApi_RequestParameter> requestParameters;

		private List<DescribeApi_ServiceParameter> serviceParameters;

		private List<DescribeApi_ServiceParameterMap> serviceParametersMap;

		private List<DescribeApi_DeployedInfo> deployedInfos;

		private DescribeApi_RequestConfig requestConfig;

		private DescribeApi_ServiceConfig serviceConfig;

		private DescribeApi_OpenIdConnectConfig openIdConnectConfig;

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

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
			}
		}

		public string ApiId
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

		public string GroupName
		{
			get
			{
				return groupName;
			}
			set	
			{
				groupName = value;
			}
		}

		public string Visibility
		{
			get
			{
				return visibility;
			}
			set	
			{
				visibility = value;
			}
		}

		public string AuthType
		{
			get
			{
				return authType;
			}
			set	
			{
				authType = value;
			}
		}

		public string ResultType
		{
			get
			{
				return resultType;
			}
			set	
			{
				resultType = value;
			}
		}

		public string ResultSample
		{
			get
			{
				return resultSample;
			}
			set	
			{
				resultSample = value;
			}
		}

		public string FailResultSample
		{
			get
			{
				return failResultSample;
			}
			set	
			{
				failResultSample = value;
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

		public string Mock
		{
			get
			{
				return mock;
			}
			set	
			{
				mock = value;
			}
		}

		public string MockResult
		{
			get
			{
				return mockResult;
			}
			set	
			{
				mockResult = value;
			}
		}

		public string AllowSignatureMethod
		{
			get
			{
				return allowSignatureMethod;
			}
			set	
			{
				allowSignatureMethod = value;
			}
		}

		public string WebSocketApiType
		{
			get
			{
				return webSocketApiType;
			}
			set	
			{
				webSocketApiType = value;
			}
		}

		public string ResultBodyModel
		{
			get
			{
				return resultBodyModel;
			}
			set	
			{
				resultBodyModel = value;
			}
		}

		public bool? ForceNonceCheck
		{
			get
			{
				return forceNonceCheck;
			}
			set	
			{
				forceNonceCheck = value;
			}
		}

		public bool? DisableInternet
		{
			get
			{
				return disableInternet;
			}
			set	
			{
				disableInternet = value;
			}
		}

		public string AppCodeAuthType
		{
			get
			{
				return appCodeAuthType;
			}
			set	
			{
				appCodeAuthType = value;
			}
		}

		public List<DescribeApi_ErrorCodeSample> ErrorCodeSamples
		{
			get
			{
				return errorCodeSamples;
			}
			set	
			{
				errorCodeSamples = value;
			}
		}

		public List<DescribeApi_ResultDescription> ResultDescriptions
		{
			get
			{
				return resultDescriptions;
			}
			set	
			{
				resultDescriptions = value;
			}
		}

		public List<DescribeApi_SystemParameter> SystemParameters
		{
			get
			{
				return systemParameters;
			}
			set	
			{
				systemParameters = value;
			}
		}

		public List<DescribeApi_CustomSystemParameter> CustomSystemParameters
		{
			get
			{
				return customSystemParameters;
			}
			set	
			{
				customSystemParameters = value;
			}
		}

		public List<DescribeApi_ConstantParameter> ConstantParameters
		{
			get
			{
				return constantParameters;
			}
			set	
			{
				constantParameters = value;
			}
		}

		public List<DescribeApi_RequestParameter> RequestParameters
		{
			get
			{
				return requestParameters;
			}
			set	
			{
				requestParameters = value;
			}
		}

		public List<DescribeApi_ServiceParameter> ServiceParameters
		{
			get
			{
				return serviceParameters;
			}
			set	
			{
				serviceParameters = value;
			}
		}

		public List<DescribeApi_ServiceParameterMap> ServiceParametersMap
		{
			get
			{
				return serviceParametersMap;
			}
			set	
			{
				serviceParametersMap = value;
			}
		}

		public List<DescribeApi_DeployedInfo> DeployedInfos
		{
			get
			{
				return deployedInfos;
			}
			set	
			{
				deployedInfos = value;
			}
		}

		public DescribeApi_RequestConfig RequestConfig
		{
			get
			{
				return requestConfig;
			}
			set	
			{
				requestConfig = value;
			}
		}

		public DescribeApi_ServiceConfig ServiceConfig
		{
			get
			{
				return serviceConfig;
			}
			set	
			{
				serviceConfig = value;
			}
		}

		public DescribeApi_OpenIdConnectConfig OpenIdConnectConfig
		{
			get
			{
				return openIdConnectConfig;
			}
			set	
			{
				openIdConnectConfig = value;
			}
		}

		public class DescribeApi_ErrorCodeSample
		{

			private string code;

			private string message;

			private string description;

			private string model;

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}

			public string Message
			{
				get
				{
					return message;
				}
				set	
				{
					message = value;
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

			public string Model
			{
				get
				{
					return model;
				}
				set	
				{
					model = value;
				}
			}
		}

		public class DescribeApi_ResultDescription
		{

			private string id;

			private string pid;

			private bool? hasChild;

			private string key;

			private string name;

			private bool? mandatory;

			private string type;

			private string description;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Pid
			{
				get
				{
					return pid;
				}
				set	
				{
					pid = value;
				}
			}

			public bool? HasChild
			{
				get
				{
					return hasChild;
				}
				set	
				{
					hasChild = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public bool? Mandatory
			{
				get
				{
					return mandatory;
				}
				set	
				{
					mandatory = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
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
		}

		public class DescribeApi_SystemParameter
		{

			private string parameterName;

			private string serviceParameterName;

			private string location;

			private string demoValue;

			private string description;

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

			public string ServiceParameterName
			{
				get
				{
					return serviceParameterName;
				}
				set	
				{
					serviceParameterName = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string DemoValue
			{
				get
				{
					return demoValue;
				}
				set	
				{
					demoValue = value;
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
		}

		public class DescribeApi_CustomSystemParameter
		{

			private string parameterName;

			private string serviceParameterName;

			private string location;

			private string demoValue;

			private string description;

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

			public string ServiceParameterName
			{
				get
				{
					return serviceParameterName;
				}
				set	
				{
					serviceParameterName = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string DemoValue
			{
				get
				{
					return demoValue;
				}
				set	
				{
					demoValue = value;
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
		}

		public class DescribeApi_ConstantParameter
		{

			private string serviceParameterName;

			private string constantValue;

			private string location;

			private string description;

			public string ServiceParameterName
			{
				get
				{
					return serviceParameterName;
				}
				set	
				{
					serviceParameterName = value;
				}
			}

			public string ConstantValue
			{
				get
				{
					return constantValue;
				}
				set	
				{
					constantValue = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
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
		}

		public class DescribeApi_RequestParameter
		{

			private string apiParameterName;

			private string location;

			private string parameterType;

			private string required;

			private string defaultValue;

			private string demoValue;

			private long? maxValue;

			private long? minValue;

			private long? maxLength;

			private long? minLength;

			private string regularExpression;

			private string jsonScheme;

			private string enumValue;

			private string docShow;

			private int? docOrder;

			private string description;

			private string arrayItemsType;

			public string ApiParameterName
			{
				get
				{
					return apiParameterName;
				}
				set	
				{
					apiParameterName = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string ParameterType
			{
				get
				{
					return parameterType;
				}
				set	
				{
					parameterType = value;
				}
			}

			public string Required
			{
				get
				{
					return required;
				}
				set	
				{
					required = value;
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

			public string DemoValue
			{
				get
				{
					return demoValue;
				}
				set	
				{
					demoValue = value;
				}
			}

			public long? MaxValue
			{
				get
				{
					return maxValue;
				}
				set	
				{
					maxValue = value;
				}
			}

			public long? MinValue
			{
				get
				{
					return minValue;
				}
				set	
				{
					minValue = value;
				}
			}

			public long? MaxLength
			{
				get
				{
					return maxLength;
				}
				set	
				{
					maxLength = value;
				}
			}

			public long? MinLength
			{
				get
				{
					return minLength;
				}
				set	
				{
					minLength = value;
				}
			}

			public string RegularExpression
			{
				get
				{
					return regularExpression;
				}
				set	
				{
					regularExpression = value;
				}
			}

			public string JsonScheme
			{
				get
				{
					return jsonScheme;
				}
				set	
				{
					jsonScheme = value;
				}
			}

			public string EnumValue
			{
				get
				{
					return enumValue;
				}
				set	
				{
					enumValue = value;
				}
			}

			public string DocShow
			{
				get
				{
					return docShow;
				}
				set	
				{
					docShow = value;
				}
			}

			public int? DocOrder
			{
				get
				{
					return docOrder;
				}
				set	
				{
					docOrder = value;
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

			public string ArrayItemsType
			{
				get
				{
					return arrayItemsType;
				}
				set	
				{
					arrayItemsType = value;
				}
			}
		}

		public class DescribeApi_ServiceParameter
		{

			private string serviceParameterName;

			private string location;

			private string parameterType;

			public string ServiceParameterName
			{
				get
				{
					return serviceParameterName;
				}
				set	
				{
					serviceParameterName = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public string ParameterType
			{
				get
				{
					return parameterType;
				}
				set	
				{
					parameterType = value;
				}
			}
		}

		public class DescribeApi_ServiceParameterMap
		{

			private string serviceParameterName;

			private string requestParameterName;

			public string ServiceParameterName
			{
				get
				{
					return serviceParameterName;
				}
				set	
				{
					serviceParameterName = value;
				}
			}

			public string RequestParameterName
			{
				get
				{
					return requestParameterName;
				}
				set	
				{
					requestParameterName = value;
				}
			}
		}

		public class DescribeApi_DeployedInfo
		{

			private string stageName;

			private string effectiveVersion;

			private string deployedStatus;

			public string StageName
			{
				get
				{
					return stageName;
				}
				set	
				{
					stageName = value;
				}
			}

			public string EffectiveVersion
			{
				get
				{
					return effectiveVersion;
				}
				set	
				{
					effectiveVersion = value;
				}
			}

			public string DeployedStatus
			{
				get
				{
					return deployedStatus;
				}
				set	
				{
					deployedStatus = value;
				}
			}
		}

		public class DescribeApi_RequestConfig
		{

			private string requestProtocol;

			private string requestHttpMethod;

			private string requestPath;

			private string bodyFormat;

			private string postBodyDescription;

			private string requestMode;

			private string bodyModel;

			public string RequestProtocol
			{
				get
				{
					return requestProtocol;
				}
				set	
				{
					requestProtocol = value;
				}
			}

			public string RequestHttpMethod
			{
				get
				{
					return requestHttpMethod;
				}
				set	
				{
					requestHttpMethod = value;
				}
			}

			public string RequestPath
			{
				get
				{
					return requestPath;
				}
				set	
				{
					requestPath = value;
				}
			}

			public string BodyFormat
			{
				get
				{
					return bodyFormat;
				}
				set	
				{
					bodyFormat = value;
				}
			}

			public string PostBodyDescription
			{
				get
				{
					return postBodyDescription;
				}
				set	
				{
					postBodyDescription = value;
				}
			}

			public string RequestMode
			{
				get
				{
					return requestMode;
				}
				set	
				{
					requestMode = value;
				}
			}

			public string BodyModel
			{
				get
				{
					return bodyModel;
				}
				set	
				{
					bodyModel = value;
				}
			}
		}

		public class DescribeApi_ServiceConfig
		{

			private string serviceProtocol;

			private string serviceAddress;

			private string serviceHttpMethod;

			private string servicePath;

			private int? serviceTimeout;

			private string contentTypeCatagory;

			private string contentTypeValue;

			private string mock;

			private string mockResult;

			private string serviceVpcEnable;

			private string aoneAppName;

			private int? mockStatusCode;

			private List<DescribeApi_MockHeader> mockHeaders;

			private DescribeApi_VpcConfig vpcConfig;

			private DescribeApi_FunctionComputeConfig functionComputeConfig;

			public string ServiceProtocol
			{
				get
				{
					return serviceProtocol;
				}
				set	
				{
					serviceProtocol = value;
				}
			}

			public string ServiceAddress
			{
				get
				{
					return serviceAddress;
				}
				set	
				{
					serviceAddress = value;
				}
			}

			public string ServiceHttpMethod
			{
				get
				{
					return serviceHttpMethod;
				}
				set	
				{
					serviceHttpMethod = value;
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

			public int? ServiceTimeout
			{
				get
				{
					return serviceTimeout;
				}
				set	
				{
					serviceTimeout = value;
				}
			}

			public string ContentTypeCatagory
			{
				get
				{
					return contentTypeCatagory;
				}
				set	
				{
					contentTypeCatagory = value;
				}
			}

			public string ContentTypeValue
			{
				get
				{
					return contentTypeValue;
				}
				set	
				{
					contentTypeValue = value;
				}
			}

			public string Mock
			{
				get
				{
					return mock;
				}
				set	
				{
					mock = value;
				}
			}

			public string MockResult
			{
				get
				{
					return mockResult;
				}
				set	
				{
					mockResult = value;
				}
			}

			public string ServiceVpcEnable
			{
				get
				{
					return serviceVpcEnable;
				}
				set	
				{
					serviceVpcEnable = value;
				}
			}

			public string AoneAppName
			{
				get
				{
					return aoneAppName;
				}
				set	
				{
					aoneAppName = value;
				}
			}

			public int? MockStatusCode
			{
				get
				{
					return mockStatusCode;
				}
				set	
				{
					mockStatusCode = value;
				}
			}

			public List<DescribeApi_MockHeader> MockHeaders
			{
				get
				{
					return mockHeaders;
				}
				set	
				{
					mockHeaders = value;
				}
			}

			public DescribeApi_VpcConfig VpcConfig
			{
				get
				{
					return vpcConfig;
				}
				set	
				{
					vpcConfig = value;
				}
			}

			public DescribeApi_FunctionComputeConfig FunctionComputeConfig
			{
				get
				{
					return functionComputeConfig;
				}
				set	
				{
					functionComputeConfig = value;
				}
			}

			public class DescribeApi_MockHeader
			{

				private string headerName;

				private string headerValue;

				public string HeaderName
				{
					get
					{
						return headerName;
					}
					set	
					{
						headerName = value;
					}
				}

				public string HeaderValue
				{
					get
					{
						return headerValue;
					}
					set	
					{
						headerValue = value;
					}
				}
			}

			public class DescribeApi_VpcConfig
			{

				private string name;

				private string vpcId;

				private string instanceId;

				private int? port;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string VpcId
				{
					get
					{
						return vpcId;
					}
					set	
					{
						vpcId = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public int? Port
				{
					get
					{
						return port;
					}
					set	
					{
						port = value;
					}
				}
			}

			public class DescribeApi_FunctionComputeConfig
			{

				private string regionId;

				private string serviceName;

				private string functionName;

				private string roleArn;

				public string RegionId
				{
					get
					{
						return regionId;
					}
					set	
					{
						regionId = value;
					}
				}

				public string ServiceName
				{
					get
					{
						return serviceName;
					}
					set	
					{
						serviceName = value;
					}
				}

				public string FunctionName
				{
					get
					{
						return functionName;
					}
					set	
					{
						functionName = value;
					}
				}

				public string RoleArn
				{
					get
					{
						return roleArn;
					}
					set	
					{
						roleArn = value;
					}
				}
			}
		}

		public class DescribeApi_OpenIdConnectConfig
		{

			private string openIdApiType;

			private string idTokenParamName;

			private string publicKeyId;

			private string publicKey;

			public string OpenIdApiType
			{
				get
				{
					return openIdApiType;
				}
				set	
				{
					openIdApiType = value;
				}
			}

			public string IdTokenParamName
			{
				get
				{
					return idTokenParamName;
				}
				set	
				{
					idTokenParamName = value;
				}
			}

			public string PublicKeyId
			{
				get
				{
					return publicKeyId;
				}
				set	
				{
					publicKeyId = value;
				}
			}

			public string PublicKey
			{
				get
				{
					return publicKey;
				}
				set	
				{
					publicKey = value;
				}
			}
		}
	}
}
