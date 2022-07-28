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

namespace Aliyun.Acs.Dbs.Model.V20190306
{
	public class DescribePreCheckProgressListResponse : AcsResponse
	{

		private string status;

		private int? httpStatusCode;

		private string requestId;

		private int? progress;

		private string errCode;

		private bool? success;

		private string errMessage;

		private List<DescribePreCheckProgressList_PreCheckProgressDetail> items;

		public string Status
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

		public List<DescribePreCheckProgressList_PreCheckProgressDetail> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribePreCheckProgressList_PreCheckProgressDetail
		{

			private long? finishTime;

			private string state;

			private long? bootTime;

			private string jobId;

			private string item;

			private string errMsg;

			private string orderNum;

			private string names;

			public long? FinishTime
			{
				get
				{
					return finishTime;
				}
				set	
				{
					finishTime = value;
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

			public long? BootTime
			{
				get
				{
					return bootTime;
				}
				set	
				{
					bootTime = value;
				}
			}

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public string Item
			{
				get
				{
					return item;
				}
				set	
				{
					item = value;
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

			public string OrderNum
			{
				get
				{
					return orderNum;
				}
				set	
				{
					orderNum = value;
				}
			}

			public string Names
			{
				get
				{
					return names;
				}
				set	
				{
					names = value;
				}
			}
		}
	}
}
