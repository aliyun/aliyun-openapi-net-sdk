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
