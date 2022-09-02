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
	public class DescribePGHbaConfigResponse : AcsResponse
	{

		private string hbaModifyTime;

		private string modifyStatusReason;

		private string requestId;

		private string lastModifyStatus;

		private string dBInstanceId;

		private List<DescribePGHbaConfig_HbaItem> defaultHbaItems;

		private List<DescribePGHbaConfig_HbaItem> runningHbaItems;

		[JsonProperty(PropertyName = "HbaModifyTime")]
		public string HbaModifyTime
		{
			get
			{
				return hbaModifyTime;
			}
			set	
			{
				hbaModifyTime = value;
			}
		}

		[JsonProperty(PropertyName = "ModifyStatusReason")]
		public string ModifyStatusReason
		{
			get
			{
				return modifyStatusReason;
			}
			set	
			{
				modifyStatusReason = value;
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

		[JsonProperty(PropertyName = "LastModifyStatus")]
		public string LastModifyStatus
		{
			get
			{
				return lastModifyStatus;
			}
			set	
			{
				lastModifyStatus = value;
			}
		}

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

		[JsonProperty(PropertyName = "DefaultHbaItems")]
		public List<DescribePGHbaConfig_HbaItem> DefaultHbaItems
		{
			get
			{
				return defaultHbaItems;
			}
			set	
			{
				defaultHbaItems = value;
			}
		}

		[JsonProperty(PropertyName = "RunningHbaItems")]
		public List<DescribePGHbaConfig_HbaItem> RunningHbaItems
		{
			get
			{
				return runningHbaItems;
			}
			set	
			{
				runningHbaItems = value;
			}
		}

		public class DescribePGHbaConfig_HbaItem
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
