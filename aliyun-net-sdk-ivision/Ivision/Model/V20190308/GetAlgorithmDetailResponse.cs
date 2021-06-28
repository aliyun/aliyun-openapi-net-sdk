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

namespace Aliyun.Acs.ivision.Model.V20190308
{
	public class GetAlgorithmDetailResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private string code;

		private bool? success;

		private GetAlgorithmDetail_Data data;

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

		public GetAlgorithmDetail_Data Data
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

		public class GetAlgorithmDetail_Data
		{

			private string algorithmName;

			private string deployRegion;

			private int? currentMonthCount;

			private string algorithmCode;

			private string apiDocUrl;

			private int? currentMonthSuccessCount;

			public string AlgorithmName
			{
				get
				{
					return algorithmName;
				}
				set	
				{
					algorithmName = value;
				}
			}

			public string DeployRegion
			{
				get
				{
					return deployRegion;
				}
				set	
				{
					deployRegion = value;
				}
			}

			public int? CurrentMonthCount
			{
				get
				{
					return currentMonthCount;
				}
				set	
				{
					currentMonthCount = value;
				}
			}

			public string AlgorithmCode
			{
				get
				{
					return algorithmCode;
				}
				set	
				{
					algorithmCode = value;
				}
			}

			public string ApiDocUrl
			{
				get
				{
					return apiDocUrl;
				}
				set	
				{
					apiDocUrl = value;
				}
			}

			public int? CurrentMonthSuccessCount
			{
				get
				{
					return currentMonthSuccessCount;
				}
				set	
				{
					currentMonthSuccessCount = value;
				}
			}
		}
	}
}
