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

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
	public class BatchAddFeishuUsersResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private BatchAddFeishuUsers_Result result;

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

		public BatchAddFeishuUsers_Result Result
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

		public class BatchAddFeishuUsers_Result
		{

			private int? failCount;

			private int? okCount;

			private List<BatchAddFeishuUsers_FailResultsItem> failResults;

			public int? FailCount
			{
				get
				{
					return failCount;
				}
				set	
				{
					failCount = value;
				}
			}

			public int? OkCount
			{
				get
				{
					return okCount;
				}
				set	
				{
					okCount = value;
				}
			}

			public List<BatchAddFeishuUsers_FailResultsItem> FailResults
			{
				get
				{
					return failResults;
				}
				set	
				{
					failResults = value;
				}
			}

			public class BatchAddFeishuUsers_FailResultsItem
			{

				private List<BatchAddFeishuUsers_FailInfosItem> failInfos;

				public List<BatchAddFeishuUsers_FailInfosItem> FailInfos
				{
					get
					{
						return failInfos;
					}
					set	
					{
						failInfos = value;
					}
				}

				public class BatchAddFeishuUsers_FailInfosItem
				{

					private string code;

					private string codeDesc;

					private string input;

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

					public string CodeDesc
					{
						get
						{
							return codeDesc;
						}
						set	
						{
							codeDesc = value;
						}
					}

					public string Input
					{
						get
						{
							return input;
						}
						set	
						{
							input = value;
						}
					}
				}
			}
		}
	}
}
