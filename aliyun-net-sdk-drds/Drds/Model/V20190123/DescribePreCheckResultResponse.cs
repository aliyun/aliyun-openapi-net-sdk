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

namespace Aliyun.Acs.Drds.Model.V20190123
{
	public class DescribePreCheckResultResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private DescribePreCheckResult_PreCheckResult preCheckResult;

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

		public DescribePreCheckResult_PreCheckResult PreCheckResult
		{
			get
			{
				return preCheckResult;
			}
			set	
			{
				preCheckResult = value;
			}
		}

		public class DescribePreCheckResult_PreCheckResult
		{

			private string preCheckName;

			private string state;

			private List<DescribePreCheckResult_SubCheckItemsItem> subCheckItems;

			public string PreCheckName
			{
				get
				{
					return preCheckName;
				}
				set	
				{
					preCheckName = value;
				}
			}

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
				}
			}

			public List<DescribePreCheckResult_SubCheckItemsItem> SubCheckItems
			{
				get
				{
					return subCheckItems;
				}
				set	
				{
					subCheckItems = value;
				}
			}

			public class DescribePreCheckResult_SubCheckItemsItem
			{

				private string preCheckItemName;

				private string state;

				private string errorMsgCode;

				private List<string> errorMsgParams;

				public string PreCheckItemName
				{
					get
					{
						return preCheckItemName;
					}
					set	
					{
						preCheckItemName = value;
					}
				}

				public string State
				{
					get
					{
						return state;
					}
					set	
					{
						state = value;
					}
				}

				public string ErrorMsgCode
				{
					get
					{
						return errorMsgCode;
					}
					set	
					{
						errorMsgCode = value;
					}
				}

				public List<string> ErrorMsgParams
				{
					get
					{
						return errorMsgParams;
					}
					set	
					{
						errorMsgParams = value;
					}
				}
			}
		}
	}
}
