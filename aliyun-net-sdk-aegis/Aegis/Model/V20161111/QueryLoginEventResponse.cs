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
	public class QueryLoginEventResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private bool? success;

		private string message;

		private QueryLoginEvent_Data data;

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

		public QueryLoginEvent_Data Data
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

		public class QueryLoginEvent_Data
		{

			private List<QueryLoginEvent_Entity> list;

			private QueryLoginEvent_PageInfo pageInfo;

			public List<QueryLoginEvent_Entity> List
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

			public QueryLoginEvent_PageInfo PageInfo
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

			public class QueryLoginEvent_Entity
			{

				private string uuid;

				private string loginTime;

				private int? loginType;

				private string loginTypeName;

				private string buyVersion;

				private string loginSourceIp;

				private int? groupId;

				private string instanceName;

				private string instanceId;

				private string ip;

				private string region;

				private int? status;

				private string statusName;

				private string location;

				private string userName;

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

				public string LoginTime
				{
					get
					{
						return loginTime;
					}
					set	
					{
						loginTime = value;
					}
				}

				public int? LoginType
				{
					get
					{
						return loginType;
					}
					set	
					{
						loginType = value;
					}
				}

				public string LoginTypeName
				{
					get
					{
						return loginTypeName;
					}
					set	
					{
						loginTypeName = value;
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

				public string LoginSourceIp
				{
					get
					{
						return loginSourceIp;
					}
					set	
					{
						loginSourceIp = value;
					}
				}

				public int? GroupId
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

				public int? Status
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

				public string StatusName
				{
					get
					{
						return statusName;
					}
					set	
					{
						statusName = value;
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

				public string UserName
				{
					get
					{
						return userName;
					}
					set	
					{
						userName = value;
					}
				}
			}

			public class QueryLoginEvent_PageInfo
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
