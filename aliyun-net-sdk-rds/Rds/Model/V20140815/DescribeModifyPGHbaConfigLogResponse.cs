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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeModifyPGHbaConfigLogResponse : AcsResponse
	{

		private string dBInstanceId;

		private string requestId;

		private int? logItemCount;

		private List<DescribeModifyPGHbaConfigLog_HbaLogItem> hbaLogItems;

		[JsonProperty(PropertyName = "DBInstanceId")]
		public string DBInstanceId
		{
			get
			{
				return dBInstanceId;
			}
			set	
			{
				dBInstanceId = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "LogItemCount")]
		public int? LogItemCount
		{
			get
			{
				return logItemCount;
			}
			set	
			{
				logItemCount = value;
			}
		}

		[JsonProperty(PropertyName = "HbaLogItems")]
		public List<DescribeModifyPGHbaConfigLog_HbaLogItem> HbaLogItems
		{
			get
			{
				return hbaLogItems;
			}
			set	
			{
				hbaLogItems = value;
			}
		}

		public class DescribeModifyPGHbaConfigLog_HbaLogItem
		{

			private string modifyStatus;

			private string statusReason;

			private string modifyTime;

			private List<DescribeModifyPGHbaConfigLog_HbaItem> beforeHbaItems;

			private List<DescribeModifyPGHbaConfigLog_HbaItem> afterHbaItems;

			[JsonProperty(PropertyName = "ModifyStatus")]
			public string ModifyStatus
			{
				get
				{
					return modifyStatus;
				}
				set	
				{
					modifyStatus = value;
				}
			}

			[JsonProperty(PropertyName = "StatusReason")]
			public string StatusReason
			{
				get
				{
					return statusReason;
				}
				set	
				{
					statusReason = value;
				}
			}

			[JsonProperty(PropertyName = "ModifyTime")]
			public string ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			[JsonProperty(PropertyName = "BeforeHbaItems")]
			public List<DescribeModifyPGHbaConfigLog_HbaItem> BeforeHbaItems
			{
				get
				{
					return beforeHbaItems;
				}
				set	
				{
					beforeHbaItems = value;
				}
			}

			[JsonProperty(PropertyName = "AfterHbaItems")]
			public List<DescribeModifyPGHbaConfigLog_HbaItem> AfterHbaItems
			{
				get
				{
					return afterHbaItems;
				}
				set	
				{
					afterHbaItems = value;
				}
			}

			public class DescribeModifyPGHbaConfigLog_HbaItem
			{

				private string type;

				private string mask;

				private string database;

				private int? priorityId;

				private string address;

				private string option;

				private string method;

				private string user;

				[JsonProperty(PropertyName = "Type")]
				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				[JsonProperty(PropertyName = "Mask")]
				public string Mask
				{
					get
					{
						return mask;
					}
					set	
					{
						mask = value;
					}
				}

				[JsonProperty(PropertyName = "Database")]
				public string Database
				{
					get
					{
						return database;
					}
					set	
					{
						database = value;
					}
				}

				[JsonProperty(PropertyName = "PriorityId")]
				public int? PriorityId
				{
					get
					{
						return priorityId;
					}
					set	
					{
						priorityId = value;
					}
				}

				[JsonProperty(PropertyName = "Address")]
				public string Address
				{
					get
					{
						return address;
					}
					set	
					{
						address = value;
					}
				}

				[JsonProperty(PropertyName = "Option")]
				public string Option
				{
					get
					{
						return option;
					}
					set	
					{
						option = value;
					}
				}

				[JsonProperty(PropertyName = "Method")]
				public string Method
				{
					get
					{
						return method;
					}
					set	
					{
						method = value;
					}
				}

				[JsonProperty(PropertyName = "User")]
				public string User
				{
					get
					{
						return user;
					}
					set	
					{
						user = value;
					}
				}
			}
		}
	}
}
