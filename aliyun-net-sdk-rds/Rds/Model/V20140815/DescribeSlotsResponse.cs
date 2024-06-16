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
	public class DescribeSlotsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeSlots_Slot> slots;

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

		[JsonProperty(PropertyName = "Slots")]
		public List<DescribeSlots_Slot> Slots
		{
			get
			{
				return slots;
			}
			set	
			{
				slots = value;
			}
		}

		public class DescribeSlots_Slot
		{

			private string slotName;

			private string plugin;

			private string slotType;

			private string database;

			private string temporary;

			private string slotStatus;

			private string walDelay;

			private string subReplayLag;

			[JsonProperty(PropertyName = "SlotName")]
			public string SlotName
			{
				get
				{
					return slotName;
				}
				set	
				{
					slotName = value;
				}
			}

			[JsonProperty(PropertyName = "Plugin")]
			public string Plugin
			{
				get
				{
					return plugin;
				}
				set	
				{
					plugin = value;
				}
			}

			[JsonProperty(PropertyName = "SlotType")]
			public string SlotType
			{
				get
				{
					return slotType;
				}
				set	
				{
					slotType = value;
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

			[JsonProperty(PropertyName = "Temporary")]
			public string Temporary
			{
				get
				{
					return temporary;
				}
				set	
				{
					temporary = value;
				}
			}

			[JsonProperty(PropertyName = "SlotStatus")]
			public string SlotStatus
			{
				get
				{
					return slotStatus;
				}
				set	
				{
					slotStatus = value;
				}
			}

			[JsonProperty(PropertyName = "WalDelay")]
			public string WalDelay
			{
				get
				{
					return walDelay;
				}
				set	
				{
					walDelay = value;
				}
			}

			[JsonProperty(PropertyName = "SubReplayLag")]
			public string SubReplayLag
			{
				get
				{
					return subReplayLag;
				}
				set	
				{
					subReplayLag = value;
				}
			}
		}
	}
}
