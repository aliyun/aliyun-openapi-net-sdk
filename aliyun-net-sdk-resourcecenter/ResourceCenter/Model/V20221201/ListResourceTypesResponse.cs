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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.ResourceCenter.Model.V20221201
{
	public class ListResourceTypesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorCode;

		private string errorMessage;

		private string dynamicCode;

		private string dynamicMessage;

		private List<ListResourceTypes_ResourceType> resourceTypes;

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

		public string DynamicCode
		{
			get
			{
				return dynamicCode;
			}
			set	
			{
				dynamicCode = value;
			}
		}

		public string DynamicMessage
		{
			get
			{
				return dynamicMessage;
			}
			set	
			{
				dynamicMessage = value;
			}
		}

		public List<ListResourceTypes_ResourceType> ResourceTypes
		{
			get
			{
				return resourceTypes;
			}
			set	
			{
				resourceTypes = value;
			}
		}

		public class ListResourceTypes_ResourceType
		{

			private string resourceType;

			private string productName;

			private string resourceTypeName;

			private List<string> filterKeys;

			private ListResourceTypes_CodeMapping codeMapping;

			private ListResourceTypes_Urls urls;

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			public string ProductName
			{
				get
				{
					return productName;
				}
				set	
				{
					productName = value;
				}
			}

			public string ResourceTypeName
			{
				get
				{
					return resourceTypeName;
				}
				set	
				{
					resourceTypeName = value;
				}
			}

			public List<string> FilterKeys
			{
				get
				{
					return filterKeys;
				}
				set	
				{
					filterKeys = value;
				}
			}

			public ListResourceTypes_CodeMapping CodeMapping
			{
				get
				{
					return codeMapping;
				}
				set	
				{
					codeMapping = value;
				}
			}

			public ListResourceTypes_Urls Urls
			{
				get
				{
					return urls;
				}
				set	
				{
					urls = value;
				}
			}

			public class ListResourceTypes_CodeMapping
			{

				private string resourceGroup;

				private string tag;

				public string ResourceGroup
				{
					get
					{
						return resourceGroup;
					}
					set	
					{
						resourceGroup = value;
					}
				}

				public string Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
					}
				}
			}

			public class ListResourceTypes_Urls
			{

				private string productConsoleUrl;

				private string resourceConsoleUrl;

				public string ProductConsoleUrl
				{
					get
					{
						return productConsoleUrl;
					}
					set	
					{
						productConsoleUrl = value;
					}
				}

				public string ResourceConsoleUrl
				{
					get
					{
						return resourceConsoleUrl;
					}
					set	
					{
						resourceConsoleUrl = value;
					}
				}
			}
		}
	}
}
