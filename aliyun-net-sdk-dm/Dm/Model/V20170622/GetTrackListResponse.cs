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
	public class GetTrackListResponse : AcsResponse
	{

		private string requestId;

		private int? total;

		private int? pageNo;

		private int? pageSize;

		private string offsetCreateTime;

		private string offsetCreateTimeDesc;

		private List<GetTrackList_Stat> data;

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

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
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

		public string OffsetCreateTime
		{
			get
			{
				return offsetCreateTime;
			}
			set	
			{
				offsetCreateTime = value;
			}
		}

		public string OffsetCreateTimeDesc
		{
			get
			{
				return offsetCreateTimeDesc;
			}
			set	
			{
				offsetCreateTimeDesc = value;
			}
		}

		public List<GetTrackList_Stat> Data
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

		public class GetTrackList_Stat
		{

			private string createTime;

			private string rcptClickCount;

			private string rcptClickRate;

			private string rcptOpenCount;

			private string rcptOpenRate;

			private string rcptUniqueClickCount;

			private string rcptUniqueClickRate;

			private string rcptUniqueOpenCount;

			private string rcptUniqueOpenRate;

			private string totalNumber;

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

			public string RcptClickCount
			{
				get
				{
					return rcptClickCount;
				}
				set	
				{
					rcptClickCount = value;
				}
			}

			public string RcptClickRate
			{
				get
				{
					return rcptClickRate;
				}
				set	
				{
					rcptClickRate = value;
				}
			}

			public string RcptOpenCount
			{
				get
				{
					return rcptOpenCount;
				}
				set	
				{
					rcptOpenCount = value;
				}
			}

			public string RcptOpenRate
			{
				get
				{
					return rcptOpenRate;
				}
				set	
				{
					rcptOpenRate = value;
				}
			}

			public string RcptUniqueClickCount
			{
				get
				{
					return rcptUniqueClickCount;
				}
				set	
				{
					rcptUniqueClickCount = value;
				}
			}

			public string RcptUniqueClickRate
			{
				get
				{
					return rcptUniqueClickRate;
				}
				set	
				{
					rcptUniqueClickRate = value;
				}
			}

			public string RcptUniqueOpenCount
			{
				get
				{
					return rcptUniqueOpenCount;
				}
				set	
				{
					rcptUniqueOpenCount = value;
				}
			}

			public string RcptUniqueOpenRate
			{
				get
				{
					return rcptUniqueOpenRate;
				}
				set	
				{
					rcptUniqueOpenRate = value;
				}
			}

			public string TotalNumber
			{
				get
				{
					return totalNumber;
				}
				set	
				{
					totalNumber = value;
				}
			}
		}
	}
}
