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

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeCastersResponse : AcsResponse
	{

		private int? total;

		private string requestId;

		private List<DescribeCasters_Caster> casterList;

		[JsonProperty(PropertyName = "Total")]
		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
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

		[JsonProperty(PropertyName = "CasterList")]
		public List<DescribeCasters_Caster> CasterList
		{
			get
			{
				return casterList;
			}
			set	
			{
				casterList = value;
			}
		}

		public class DescribeCasters_Caster
		{

			private int? status;

			private string purchaseTime;

			private string expireTime;

			private string createTime;

			private string casterName;

			private string chargeType;

			private string casterTemplate;

			private int? roomId;

			private string casterId;

			private int? channelEnable;

			private string lastModified;

			private string startTime;

			private int? normType;

			private string duration;

			[JsonProperty(PropertyName = "Status")]
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

			[JsonProperty(PropertyName = "PurchaseTime")]
			public string PurchaseTime
			{
				get
				{
					return purchaseTime;
				}
				set	
				{
					purchaseTime = value;
				}
			}

			[JsonProperty(PropertyName = "ExpireTime")]
			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			[JsonProperty(PropertyName = "CreateTime")]
			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			[JsonProperty(PropertyName = "CasterName")]
			public string CasterName
			{
				get
				{
					return casterName;
				}
				set	
				{
					casterName = value;
				}
			}

			[JsonProperty(PropertyName = "ChargeType")]
			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			[JsonProperty(PropertyName = "CasterTemplate")]
			public string CasterTemplate
			{
				get
				{
					return casterTemplate;
				}
				set	
				{
					casterTemplate = value;
				}
			}

			[JsonProperty(PropertyName = "RoomId")]
			public int? RoomId
			{
				get
				{
					return roomId;
				}
				set	
				{
					roomId = value;
				}
			}

			[JsonProperty(PropertyName = "CasterId")]
			public string CasterId
			{
				get
				{
					return casterId;
				}
				set	
				{
					casterId = value;
				}
			}

			[JsonProperty(PropertyName = "ChannelEnable")]
			public int? ChannelEnable
			{
				get
				{
					return channelEnable;
				}
				set	
				{
					channelEnable = value;
				}
			}

			[JsonProperty(PropertyName = "LastModified")]
			public string LastModified
			{
				get
				{
					return lastModified;
				}
				set	
				{
					lastModified = value;
				}
			}

			[JsonProperty(PropertyName = "StartTime")]
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

			[JsonProperty(PropertyName = "NormType")]
			public int? NormType
			{
				get
				{
					return normType;
				}
				set	
				{
					normType = value;
				}
			}

			[JsonProperty(PropertyName = "Duration")]
			public string Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
				}
			}
		}
	}
}
