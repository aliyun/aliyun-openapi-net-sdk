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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeLoginBaseConfigsResponse : AcsResponse
	{

		private int? currentPage;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeLoginBaseConfigs_BaseConfig> baseConfigs;

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

		public List<DescribeLoginBaseConfigs_BaseConfig> BaseConfigs
		{
			get
			{
				return baseConfigs;
			}
			set	
			{
				baseConfigs = value;
			}
		}

		public class DescribeLoginBaseConfigs_BaseConfig
		{

			private string endTime;

			private string account;

			private string startTime;

			private string ip;

			private int? totalCount;

			private int? uuidCount;

			private string location;

			private List<DescribeLoginBaseConfigs_Target> targetList;

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string Account
			{
				get
				{
					return account;
				}
				set	
				{
					account = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
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

			public int? UuidCount
			{
				get
				{
					return uuidCount;
				}
				set	
				{
					uuidCount = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public List<DescribeLoginBaseConfigs_Target> TargetList
			{
				get
				{
					return targetList;
				}
				set	
				{
					targetList = value;
				}
			}

			public class DescribeLoginBaseConfigs_Target
			{

				private string target;

				private string targetType;

				public string Target
				{
					get
					{
						return target;
					}
					set	
					{
						target = value;
					}
				}

				public string TargetType
				{
					get
					{
						return targetType;
					}
					set	
					{
						targetType = value;
					}
				}
			}
		}
	}
}
