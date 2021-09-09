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

namespace Aliyun.Acs.companyreg.Model.V20200306
{
	public class ListUserProduceOperateLogsResponse : AcsResponse
	{

		private int? pageNum;

		private int? pageSize;

		private string requestId;

		private bool? success;

		private int? totalItemNum;

		private int? totalPageNum;

		private List<ListUserProduceOperateLogs_OpateLogs> data;

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
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

		public int? TotalItemNum
		{
			get
			{
				return totalItemNum;
			}
			set	
			{
				totalItemNum = value;
			}
		}

		public int? TotalPageNum
		{
			get
			{
				return totalPageNum;
			}
			set	
			{
				totalPageNum = value;
			}
		}

		public List<ListUserProduceOperateLogs_OpateLogs> Data
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

		public class ListUserProduceOperateLogs_OpateLogs
		{

			private string bizId;

			private string bizType;

			private string operateName;

			private long? operateTime;

			private string operateUserType;

			private int? bizStatus;

			private int? toBizStatus;

			public string BizId
			{
				get
				{
					return bizId;
				}
				set	
				{
					bizId = value;
				}
			}

			public string BizType
			{
				get
				{
					return bizType;
				}
				set	
				{
					bizType = value;
				}
			}

			public string OperateName
			{
				get
				{
					return operateName;
				}
				set	
				{
					operateName = value;
				}
			}

			public long? OperateTime
			{
				get
				{
					return operateTime;
				}
				set	
				{
					operateTime = value;
				}
			}

			public string OperateUserType
			{
				get
				{
					return operateUserType;
				}
				set	
				{
					operateUserType = value;
				}
			}

			public int? BizStatus
			{
				get
				{
					return bizStatus;
				}
				set	
				{
					bizStatus = value;
				}
			}

			public int? ToBizStatus
			{
				get
				{
					return toBizStatus;
				}
				set	
				{
					toBizStatus = value;
				}
			}
		}
	}
}
