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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class GetEntityListResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private bool? success;

		private string message;

		private GetEntityList_Data data;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public GetEntityList_Data Data
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

		public class GetEntityList_Data
		{

			private List<GetEntityList_Entity> list;

			private GetEntityList_PageInfo pageInfo;

			public List<GetEntityList_Entity> List
			{
				get
				{
					return list;
				}
				set	
				{
					list = value;
				}
			}

			public GetEntityList_PageInfo PageInfo
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

			public class GetEntityList_Entity
			{

				private string uuid;

				private long? groupId;

				private string ip;

				private string instanceName;

				private string instanceId;

				private string region;

				private string os;

				private string flag;

				private string buyVersion;

				private bool? aegisOnline;

				private string aegisVersion;

				public string Uuid
				{
					get
					{
						return uuid;
					}
					set	
					{
						uuid = value;
					}
				}

				public long? GroupId
				{
					get
					{
						return groupId;
					}
					set	
					{
						groupId = value;
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

				public string InstanceName
				{
					get
					{
						return instanceName;
					}
					set	
					{
						instanceName = value;
					}
				}

				public string InstanceId
				{
					get
					{
						return instanceId;
					}
					set	
					{
						instanceId = value;
					}
				}

				public string Region
				{
					get
					{
						return region;
					}
					set	
					{
						region = value;
					}
				}

				public string Os
				{
					get
					{
						return os;
					}
					set	
					{
						os = value;
					}
				}

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

				public string BuyVersion
				{
					get
					{
						return buyVersion;
					}
					set	
					{
						buyVersion = value;
					}
				}

				public bool? AegisOnline
				{
					get
					{
						return aegisOnline;
					}
					set	
					{
						aegisOnline = value;
					}
				}

				public string AegisVersion
				{
					get
					{
						return aegisVersion;
					}
					set	
					{
						aegisVersion = value;
					}
				}
			}

			public class GetEntityList_PageInfo
			{

				private int? currentPage;

				private int? pageSize;

				private int? totalCount;

				private int? count;

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
			}
		}
	}
}