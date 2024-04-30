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
	public class DescribeCurrentModifyOrderResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeCurrentModifyOrder_ModifyOrderItem> modifyOrder;

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

		[JsonProperty(PropertyName = "ModifyOrder")]
		public List<DescribeCurrentModifyOrder_ModifyOrderItem> ModifyOrder
		{
			get
			{
				return modifyOrder;
			}
			set	
			{
				modifyOrder = value;
			}
		}

		public class DescribeCurrentModifyOrder_ModifyOrderItem
		{

			private string dbInstanceId;

			private string targetDBInstanceClass;

			private string storage;

			private string memoryClass;

			private string cpu;

			private string classGroup;

			private string effectiveTime;

			private string status;

			private string mark;

			[JsonProperty(PropertyName = "DbInstanceId")]
			public string DbInstanceId
			{
				get
				{
					return dbInstanceId;
				}
				set	
				{
					dbInstanceId = value;
				}
			}

			[JsonProperty(PropertyName = "TargetDBInstanceClass")]
			public string TargetDBInstanceClass
			{
				get
				{
					return targetDBInstanceClass;
				}
				set	
				{
					targetDBInstanceClass = value;
				}
			}

			[JsonProperty(PropertyName = "Storage")]
			public string Storage
			{
				get
				{
					return storage;
				}
				set	
				{
					storage = value;
				}
			}

			[JsonProperty(PropertyName = "MemoryClass")]
			public string MemoryClass
			{
				get
				{
					return memoryClass;
				}
				set	
				{
					memoryClass = value;
				}
			}

			[JsonProperty(PropertyName = "Cpu")]
			public string Cpu
			{
				get
				{
					return cpu;
				}
				set	
				{
					cpu = value;
				}
			}

			[JsonProperty(PropertyName = "ClassGroup")]
			public string ClassGroup
			{
				get
				{
					return classGroup;
				}
				set	
				{
					classGroup = value;
				}
			}

			[JsonProperty(PropertyName = "EffectiveTime")]
			public string EffectiveTime
			{
				get
				{
					return effectiveTime;
				}
				set	
				{
					effectiveTime = value;
				}
			}

			[JsonProperty(PropertyName = "Status")]
			public string Status
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

			[JsonProperty(PropertyName = "Mark")]
			public string Mark
			{
				get
				{
					return mark;
				}
				set	
				{
					mark = value;
				}
			}
		}
	}
}
