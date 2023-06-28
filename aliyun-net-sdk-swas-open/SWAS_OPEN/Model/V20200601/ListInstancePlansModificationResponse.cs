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

namespace Aliyun.Acs.SWAS_OPEN.Model.V20200601
{
	public class ListInstancePlansModificationResponse : AcsResponse
	{

		private string requestId;

		private List<ListInstancePlansModification_Plan> plans;

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

		[JsonProperty(PropertyName = "Plans")]
		public List<ListInstancePlansModification_Plan> Plans
		{
			get
			{
				return plans;
			}
			set	
			{
				plans = value;
			}
		}

		public class ListInstancePlansModification_Plan
		{

			private int? core;

			private int? bandwidth;

			private int? diskSize;

			private int? flow;

			private int? memory;

			private string planId;

			private string diskType;

			private double? originPrice;

			private string currency;

			private string supportPlatform;

			[JsonProperty(PropertyName = "Core")]
			public int? Core
			{
				get
				{
					return core;
				}
				set	
				{
					core = value;
				}
			}

			[JsonProperty(PropertyName = "Bandwidth")]
			public int? Bandwidth
			{
				get
				{
					return bandwidth;
				}
				set	
				{
					bandwidth = value;
				}
			}

			[JsonProperty(PropertyName = "DiskSize")]
			public int? DiskSize
			{
				get
				{
					return diskSize;
				}
				set	
				{
					diskSize = value;
				}
			}

			[JsonProperty(PropertyName = "Flow")]
			public int? Flow
			{
				get
				{
					return flow;
				}
				set	
				{
					flow = value;
				}
			}

			[JsonProperty(PropertyName = "Memory")]
			public int? Memory
			{
				get
				{
					return memory;
				}
				set	
				{
					memory = value;
				}
			}

			[JsonProperty(PropertyName = "PlanId")]
			public string PlanId
			{
				get
				{
					return planId;
				}
				set	
				{
					planId = value;
				}
			}

			[JsonProperty(PropertyName = "DiskType")]
			public string DiskType
			{
				get
				{
					return diskType;
				}
				set	
				{
					diskType = value;
				}
			}

			[JsonProperty(PropertyName = "OriginPrice")]
			public double? OriginPrice
			{
				get
				{
					return originPrice;
				}
				set	
				{
					originPrice = value;
				}
			}

			[JsonProperty(PropertyName = "Currency")]
			public string Currency
			{
				get
				{
					return currency;
				}
				set	
				{
					currency = value;
				}
			}

			[JsonProperty(PropertyName = "SupportPlatform")]
			public string SupportPlatform
			{
				get
				{
					return supportPlatform;
				}
				set	
				{
					supportPlatform = value;
				}
			}
		}
	}
}
