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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeApiDocResponse : AcsResponse
	{

		private string regionId;

		private string groupId;

		private string groupName;

		private string stageName;

		private string apiId;

		private string apiName;

		private string description;

		private string visibility;

		private string authType;

		private string resultType;

		private string resultSample;

		private string failResultSample;

		private string deployedTime;

		private List<ErrorCodeSample> errorCodeSamples;

		private List<ResultDescription> resultDescriptions;

		private List<RequestParameter> requestParameters;

		private RequestConfig_ requestConfig;

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

		public string DeployedTime
		{
			get
			{
				return deployedTime;
			}
			set	
			{
				deployedTime = value;
			}
		}

		public List<ErrorCodeSample> ErrorCodeSamples
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

		public List<ResultDescription> ResultDescriptions
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

		public List<RequestParameter> RequestParameters
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

		public RequestConfig_ RequestConfig
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

		public class ErrorCodeSample{

			private string code;

			private string message;

			private string description;

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
		}

		public class ResultDescription{

			private string id;

			private string pid;

			private bool? hasChild;

			private string key;

			private string name;

			private bool? mandatory;

			private string type;

			private string description;

			private string example;

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

			public string Example
			{
				get
				{
					return example;
				}
				set	
				{
					example = value;
				}
			}
		}

		public class RequestParameter{

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
		}

		public class RequestConfig_{

			private string requestProtocol;

			private string requestHttpMethod;

			private string requestPath;

			private string bodyFormat;

			private string postBodyDescription;

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
		}
	}
}