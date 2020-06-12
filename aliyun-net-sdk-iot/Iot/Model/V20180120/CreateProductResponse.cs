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
	public class CreateProductResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private string productKey;

		private CreateProduct_Data data;

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

		public CreateProduct_Data Data
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

		public class CreateProduct_Data
		{

			private int? dataFormat;

			private string description;

			private int? nodeType;

			private string productKey;

			private string productName;

			private string aliyunCommodityCode;

			private bool? id2;

			private string protocolType;

			private string authType;

			private string productSecret;

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
		}
	}
}
