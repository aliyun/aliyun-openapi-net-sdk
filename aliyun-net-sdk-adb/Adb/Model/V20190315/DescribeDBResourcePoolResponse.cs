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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeDBResourcePoolResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDBResourcePool_PoolInfo> poolsInfo;

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

		public List<DescribeDBResourcePool_PoolInfo> PoolsInfo
		{
			get
			{
				return poolsInfo;
			}
			set	
			{
				poolsInfo = value;
			}
		}

		public class DescribeDBResourcePool_PoolInfo
		{

			private string poolName;

			private string queryType;

			private int? nodeNum;

			private string poolUsers;

			private string createTime;

			private string updateTime;

			public string PoolName
			{
				get
				{
					return poolName;
				}
				set	
				{
					poolName = value;
				}
			}

			public string QueryType
			{
				get
				{
					return queryType;
				}
				set	
				{
					queryType = value;
				}
			}

			public int? NodeNum
			{
				get
				{
					return nodeNum;
				}
				set	
				{
					nodeNum = value;
				}
			}

			public string PoolUsers
			{
				get
				{
					return poolUsers;
				}
				set	
				{
					poolUsers = value;
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

			public string UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}
		}
	}
}
