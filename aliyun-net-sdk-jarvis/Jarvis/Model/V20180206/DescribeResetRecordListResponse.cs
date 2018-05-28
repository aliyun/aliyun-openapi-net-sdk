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

namespace Aliyun.Acs.jarvis.Model.V20180206
{
	public class DescribeResetRecordListResponse : AcsResponse
	{

		private string requestId;

		private string module;

		private List<DescribeResetRecordList_Data> dataList;

		private DescribeResetRecordList_PageInfo pageInfo;

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

		public string Module
		{
			get
			{
				return module;
			}
			set	
			{
				module = value;
			}
		}

		public List<DescribeResetRecordList_Data> DataList
		{
			get
			{
				return dataList;
			}
			set	
			{
				dataList = value;
			}
		}

		public DescribeResetRecordList_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeResetRecordList_Data
		{

			private string punishType;

			private string dstIP;

			private string punishResult;

			private int? dstPort;

			private string srcIP;

			private int? punishCount;

			public string PunishType
			{
				get
				{
					return punishType;
				}
				set	
				{
					punishType = value;
				}
			}

			public string DstIP
			{
				get
				{
					return dstIP;
				}
				set	
				{
					dstIP = value;
				}
			}

			public string PunishResult
			{
				get
				{
					return punishResult;
				}
				set	
				{
					punishResult = value;
				}
			}

			public int? DstPort
			{
				get
				{
					return dstPort;
				}
				set	
				{
					dstPort = value;
				}
			}

			public string SrcIP
			{
				get
				{
					return srcIP;
				}
				set	
				{
					srcIP = value;
				}
			}

			public int? PunishCount
			{
				get
				{
					return punishCount;
				}
				set	
				{
					punishCount = value;
				}
			}
		}

		public class DescribeResetRecordList_PageInfo
		{

			private int? total;

			private int? pageSize;

			private int? currentPage;

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

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}
		}
	}
}