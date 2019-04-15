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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeMacConfigResponse : AcsResponse
	{

		private string requestId;

		private int? count;

		private int? pageSize;

		private int? currentPage;

		private int? totalCount;

		private List<DescribeMacConfig_Config> configs;

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

		public int? Count
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

		public List<DescribeMacConfig_Config> Configs
		{
			get
			{
				return configs;
			}
			set	
			{
				configs = value;
			}
		}

		public class DescribeMacConfig_Config
		{

			private string startTime;

			private string endTime;

			private string ip;

			private long? strategyId;

			private string account;

			private string location;

			private string switcher;

			private string vulType;

			private int? uuidCount;

			private int? totalCount;

			private List<DescribeMacConfig_Target> targetList;

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

			public long? StrategyId
			{
				get
				{
					return strategyId;
				}
				set	
				{
					strategyId = value;
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

			public string Switcher
			{
				get
				{
					return switcher;
				}
				set	
				{
					switcher = value;
				}
			}

			public string VulType
			{
				get
				{
					return vulType;
				}
				set	
				{
					vulType = value;
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

			public List<DescribeMacConfig_Target> TargetList
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

			public class DescribeMacConfig_Target
			{

				private string flag;

				private string targetType;

				private string target;

				public string Flag
				{
					get
					{
						return flag;
					}
					set	
					{
						flag = value;
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
			}
		}
	}
}
