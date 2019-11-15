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

namespace Aliyun.Acs.Cdn.Model.V20180510
{
	public class DescribeCdnUserBillPredictionResponse : AcsResponse
	{

		private string requestId;

		private string startTime;

		private string endTime;

		private string billType;

		private List<DescribeCdnUserBillPrediction_BillPredictionDataItem> billPredictionData;

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

		public List<DescribeCdnUserBillPrediction_BillPredictionDataItem> BillPredictionData
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

		public class DescribeCdnUserBillPrediction_BillPredictionDataItem
		{

			private float? _value;

			private string area;

			private string timeStp;

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
		}
	}
}
