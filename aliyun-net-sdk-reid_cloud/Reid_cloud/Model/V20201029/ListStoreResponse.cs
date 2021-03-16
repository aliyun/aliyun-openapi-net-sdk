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

namespace Aliyun.Acs.reid_cloud.Model.V20201029
{
	public class ListStoreResponse : AcsResponse
	{

		private string errorCode;

		private string errorMessage;

		private string message;

		private string code;

		private string dynamicCode;

		private string requestId;

		private bool? success;

		private string dynamicMessage;

		private List<ListStore_OpenStore> stores;

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

		public List<ListStore_OpenStore> Stores
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

		public class ListStore_OpenStore
		{

			private long? storeId;

			private long? gmtCreate;

			private float? sqm;

			private int? status;

			private string name;

			private string openingEndTime;

			private string openingStartTime;

			private string storeType;

			private long? gmtModified;

			private string address;

			public long? StoreId
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

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public float? Sqm
			{
				get
				{
					return sqm;
				}
				set	
				{
					sqm = value;
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

			public string OpeningEndTime
			{
				get
				{
					return openingEndTime;
				}
				set	
				{
					openingEndTime = value;
				}
			}

			public string OpeningStartTime
			{
				get
				{
					return openingStartTime;
				}
				set	
				{
					openingStartTime = value;
				}
			}

			public string StoreType
			{
				get
				{
					return storeType;
				}
				set	
				{
					storeType = value;
				}
			}

			public long? GmtModified
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

			public string Address
			{
				get
				{
					return address;
				}
				set	
				{
					address = value;
				}
			}
		}
	}
}
