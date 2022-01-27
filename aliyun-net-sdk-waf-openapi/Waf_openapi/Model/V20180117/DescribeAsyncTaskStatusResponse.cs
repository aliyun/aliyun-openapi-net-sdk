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

namespace Aliyun.Acs.waf_openapi.Model.V20180117
{
	public class DescribeAsyncTaskStatusResponse : AcsResponse
	{

		private string requestId;

		private DescribeAsyncTaskStatus_Result result;

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

		public DescribeAsyncTaskStatus_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class DescribeAsyncTaskStatus_Result
		{

			private string asyncTaskStatus;

			private int? progress;

			private string errCode;

			private string errMsg;

			private string data;

			public string AsyncTaskStatus
			{
				get
				{
					return asyncTaskStatus;
				}
				set	
				{
					asyncTaskStatus = value;
				}
			}

			public int? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
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

			public string ErrMsg
			{
				get
				{
					return errMsg;
				}
				set	
				{
					errMsg = value;
				}
			}

			public string Data
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
		}
	}
}
