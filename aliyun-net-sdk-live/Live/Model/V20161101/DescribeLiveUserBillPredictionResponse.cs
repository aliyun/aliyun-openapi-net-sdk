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
	public class DescribeLiveUserBillPredictionResponse : AcsResponse
	{

		private string endTime;

		private string startTime;

		private string requestId;

		private string billType;

		private List<DescribeLiveUserBillPrediction_BillPredictionDataItem> billPredictionData;

		[JsonProperty(PropertyName = "EndTime")]
		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
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

		[JsonProperty(PropertyName = "BillType")]
		public string BillType
		{
			get
			{
				return billType;
			}
			set	
			{
				billType = value;
			}
		}

		[JsonProperty(PropertyName = "BillPredictionData")]
		public List<DescribeLiveUserBillPrediction_BillPredictionDataItem> BillPredictionData
		{
			get
			{
				return billPredictionData;
			}
			set	
			{
				billPredictionData = value;
			}
		}

		public class DescribeLiveUserBillPrediction_BillPredictionDataItem
		{

			private float? _value;

			private string timeStp;

			private string area;

			[JsonProperty(PropertyName = "_Value")]
			public float? _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}

			[JsonProperty(PropertyName = "TimeStp")]
			public string TimeStp
			{
				get
				{
					return timeStp;
				}
				set	
				{
					timeStp = value;
				}
			}

			[JsonProperty(PropertyName = "Area")]
			public string Area
			{
				get
				{
					return area;
				}
				set	
				{
					area = value;
				}
			}
		}
	}
}
