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

namespace Aliyun.Acs.Iot.Model.V20170420
{
	public class CreateProductResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errorMessage;

		private CreateProduct_ProductInfo productInfo;

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

		public CreateProduct_ProductInfo ProductInfo
		{
			get
			{
				return productInfo;
			}
			set	
			{
				productInfo = value;
			}
		}

		public class CreateProduct_ProductInfo
		{

			private string productKey;

			private string productName;

			private long? catId;

			private long? createUserId;

			private string productDesc;

			private string fromSource;

			private string extProps;

			private string gmtCreate;

			private string gmtModified;

			private string productSecret;

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

			public long? CatId
			{
				get
				{
					return catId;
				}
				set	
				{
					catId = value;
				}
			}

			public long? CreateUserId
			{
				get
				{
					return createUserId;
				}
				set	
				{
					createUserId = value;
				}
			}

			public string ProductDesc
			{
				get
				{
					return productDesc;
				}
				set	
				{
					productDesc = value;
				}
			}

			public string FromSource
			{
				get
				{
					return fromSource;
				}
				set	
				{
					fromSource = value;
				}
			}

			public string ExtProps
			{
				get
				{
					return extProps;
				}
				set	
				{
					extProps = value;
				}
			}

			public string GmtCreate
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