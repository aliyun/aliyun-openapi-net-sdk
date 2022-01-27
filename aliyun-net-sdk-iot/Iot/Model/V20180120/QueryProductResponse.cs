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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QueryProductResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryProduct_Data data;

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

		public QueryProduct_Data Data
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

		public class QueryProduct_Data
		{

			private long? gmtCreate;

			private int? dataFormat;

			private string description;

			private int? deviceCount;

			private int? nodeType;

			private string productKey;

			private string productName;

			private string productSecret;

			private string categoryName;

			private string categoryKey;

			private string aliyunCommodityCode;

			private bool? id2;

			private string protocolType;

			private string productStatus;

			private bool? owner;

			private int? netType;

			private string authType;

			private int? validateType;

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

			public int? DataFormat
			{
				get
				{
					return dataFormat;
				}
				set	
				{
					dataFormat = value;
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

			public int? DeviceCount
			{
				get
				{
					return deviceCount;
				}
				set	
				{
					deviceCount = value;
				}
			}

			public int? NodeType
			{
				get
				{
					return nodeType;
				}
				set	
				{
					nodeType = value;
				}
			}

			public string ProductKey
			{
				get
				{
					return productKey;
				}
				set	
				{
					productKey = value;
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

			public string ProductSecret
			{
				get
				{
					return productSecret;
				}
				set	
				{
					productSecret = value;
				}
			}

			public string CategoryName
			{
				get
				{
					return categoryName;
				}
				set	
				{
					categoryName = value;
				}
			}

			public string CategoryKey
			{
				get
				{
					return categoryKey;
				}
				set	
				{
					categoryKey = value;
				}
			}

			public string AliyunCommodityCode
			{
				get
				{
					return aliyunCommodityCode;
				}
				set	
				{
					aliyunCommodityCode = value;
				}
			}

			public bool? Id2
			{
				get
				{
					return id2;
				}
				set	
				{
					id2 = value;
				}
			}

			public string ProtocolType
			{
				get
				{
					return protocolType;
				}
				set	
				{
					protocolType = value;
				}
			}

			public string ProductStatus
			{
				get
				{
					return productStatus;
				}
				set	
				{
					productStatus = value;
				}
			}

			public bool? Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public int? NetType
			{
				get
				{
					return netType;
				}
				set	
				{
					netType = value;
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

			public int? ValidateType
			{
				get
				{
					return validateType;
				}
				set	
				{
					validateType = value;
				}
			}
		}
	}
}
