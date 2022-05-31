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

namespace Aliyun.Acs.cloudesl.Model.V20200201
{
	public class DescribeStoreByTemplateVersionResponse : AcsResponse
	{

		private string requestId;

		private string errorMessage;

		private bool? success;

		private string errorCode;

		private string code;

		private string message;

		private string dynamicMessage;

		private string dynamicCode;

		private List<DescribeStoreByTemplateVersion_SelectItemInfo> stores;

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

		public List<DescribeStoreByTemplateVersion_SelectItemInfo> Stores
		{
			get
			{
				return stores;
			}
			set	
			{
				stores = value;
			}
		}

		public class DescribeStoreByTemplateVersion_SelectItemInfo
		{

			private string storeName;

			private string storeId;

			private string parentId;

			private string userStoreCode;

			private string gmtModified;

			private string phone;

			private string level;

			private string templateVersion;

			private string timeZone;

			public string StoreName
			{
				get
				{
					return storeName;
				}
				set	
				{
					storeName = value;
				}
			}

			public string StoreId
			{
				get
				{
					return storeId;
				}
				set	
				{
					storeId = value;
				}
			}

			public string ParentId
			{
				get
				{
					return parentId;
				}
				set	
				{
					parentId = value;
				}
			}

			public string UserStoreCode
			{
				get
				{
					return userStoreCode;
				}
				set	
				{
					userStoreCode = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public string Phone
			{
				get
				{
					return phone;
				}
				set	
				{
					phone = value;
				}
			}

			public string Level
			{
				get
				{
					return level;
				}
				set	
				{
					level = value;
				}
			}

			public string TemplateVersion
			{
				get
				{
					return templateVersion;
				}
				set	
				{
					templateVersion = value;
				}
			}

			public string TimeZone
			{
				get
				{
					return timeZone;
				}
				set	
				{
					timeZone = value;
				}
			}
		}
	}
}
