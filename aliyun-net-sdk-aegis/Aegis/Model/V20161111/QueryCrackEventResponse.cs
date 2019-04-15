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
	public class QueryCrackEventResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private bool? success;

		private string message;

		private QueryCrackEvent_Data data;

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

		public QueryCrackEvent_Data Data
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

		public class QueryCrackEvent_Data
		{

			private List<QueryCrackEvent_Entity> list;

			private QueryCrackEvent_PageInfo pageInfo;

			public List<QueryCrackEvent_Entity> List
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

			public QueryCrackEvent_PageInfo PageInfo
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

			public class QueryCrackEvent_Entity
			{

				private string uuid;

				private string attackTime;

				private int? attackType;

				private string attackTypeName;

				private string buyVersion;

				private string crackSourceIp;

				private int? crackTimes;

				private int? groupId;

				private string instanceName;

				private string instanceId;

				private string ip;

				private string region;

				private int? status;

				private string statusName;

				private string location;

				private int? inWhite;

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

				public string AttackTime
				{
					get
					{
						return attackTime;
					}
					set	
					{
						attackTime = value;
					}
				}

				public int? AttackType
				{
					get
					{
						return attackType;
					}
					set	
					{
						attackType = value;
					}
				}

				public string AttackTypeName
				{
					get
					{
						return attackTypeName;
					}
					set	
					{
						attackTypeName = value;
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

				public string CrackSourceIp
				{
					get
					{
						return crackSourceIp;
					}
					set	
					{
						crackSourceIp = value;
					}
				}

				public int? CrackTimes
				{
					get
					{
						return crackTimes;
					}
					set	
					{
						crackTimes = value;
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

				public int? InWhite
				{
					get
					{
						return inWhite;
					}
					set	
					{
						inWhite = value;
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

			public class QueryCrackEvent_PageInfo
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
