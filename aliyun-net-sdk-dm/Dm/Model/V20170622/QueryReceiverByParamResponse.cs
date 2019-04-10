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

namespace Aliyun.Acs.Dm.Model.V20170622
{
	public class QueryReceiverByParamResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private string nextStart;

		private int? pageSize;

		private List<QueryReceiverByParam_Receiver> data;

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

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public string NextStart
		{
			get
			{
				return nextStart;
			}
			set	
			{
				nextStart = value;
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

		public List<QueryReceiverByParam_Receiver> Data
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

		public class QueryReceiverByParam_Receiver
		{

			private string receiverId;

			private string receiversName;

			private string count;

			private string receiversAlias;

			private string desc;

			private string receiversStatus;

			private string createTime;

			private long? utcCreateTime;

			public string ReceiverId
			{
				get
				{
					return receiverId;
				}
				set	
				{
					receiverId = value;
				}
			}

			public string ReceiversName
			{
				get
				{
					return receiversName;
				}
				set	
				{
					receiversName = value;
				}
			}

			public string Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
				}
			}

			public string ReceiversAlias
			{
				get
				{
					return receiversAlias;
				}
				set	
				{
					receiversAlias = value;
				}
			}

			public string Desc
			{
				get
				{
					return desc;
				}
				set	
				{
					desc = value;
				}
			}

			public string ReceiversStatus
			{
				get
				{
					return receiversStatus;
				}
				set	
				{
					receiversStatus = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? UtcCreateTime
			{
				get
				{
					return utcCreateTime;
				}
				set	
				{
					utcCreateTime = value;
				}
			}
		}
	}
}
