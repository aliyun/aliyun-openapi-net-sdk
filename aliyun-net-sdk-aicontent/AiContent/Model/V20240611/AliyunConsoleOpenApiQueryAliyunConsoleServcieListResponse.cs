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

namespace Aliyun.Acs.AiContent.Model.V20240611
{
	public class AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string errCode;

		private string errMessage;

		private int? httpStatusCode;

		private List<AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem> data;

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

		public string ErrCode
		{
			get
			{
				return errCode;
			}
			set	
			{
				errCode = value;
			}
		}

		public string ErrMessage
		{
			get
			{
				return errMessage;
			}
			set	
			{
				errMessage = value;
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

		public List<AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem> Data
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

		public class AliyunConsoleOpenApiQueryAliyunConsoleServcieList_DataItem
		{

			private string serviceCode;

			private string serviceName;

			private int? freeCount;

			private int? freeConcurrencyCount;

			public string ServiceCode
			{
				get
				{
					return serviceCode;
				}
				set	
				{
					serviceCode = value;
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

			public int? FreeCount
			{
				get
				{
					return freeCount;
				}
				set	
				{
					freeCount = value;
				}
			}

			public int? FreeConcurrencyCount
			{
				get
				{
					return freeConcurrencyCount;
				}
				set	
				{
					freeConcurrencyCount = value;
				}
			}
		}
	}
}
