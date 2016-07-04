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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeDomainBpsDataResponse : AcsResponse
	{

		private string domainName;

		private string dataInterval;

		private string startTime;

		private string endTime;

		private string locationNameEn;

		private string ispNameEn;

		private string locationName;

		private string ispName;

		private List<DataModule> bpsDataPerInterval;

		private List<DataModule> supplyBpsDatas;

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
			}
		}

		public string DataInterval
		{
			get
			{
				return dataInterval;
			}
			set	
			{
				dataInterval = value;
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

		public string LocationNameEn
		{
			get
			{
				return locationNameEn;
			}
			set	
			{
				locationNameEn = value;
			}
		}

		public string IspNameEn
		{
			get
			{
				return ispNameEn;
			}
			set	
			{
				ispNameEn = value;
			}
		}

		public string LocationName
		{
			get
			{
				return locationName;
			}
			set	
			{
				locationName = value;
			}
		}

		public string IspName
		{
			get
			{
				return ispName;
			}
			set	
			{
				ispName = value;
			}
		}

		public List<DataModule> BpsDataPerInterval
		{
			get
			{
				return bpsDataPerInterval;
			}
			set	
			{
				bpsDataPerInterval = value;
			}
		}

		public List<DataModule> SupplyBpsDatas
		{
			get
			{
				return supplyBpsDatas;
			}
			set	
			{
				supplyBpsDatas = value;
			}
		}

		public class DataModule{

			private string timeStamp;

			private string value_;

			private string domesticValue;

			private string overseasValue;

			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string DomesticValue
			{
				get
				{
					return domesticValue;
				}
				set	
				{
					domesticValue = value;
				}
			}

			public string OverseasValue
			{
				get
				{
					return overseasValue;
				}
				set	
				{
					overseasValue = value;
				}
			}
		}

		public class DataModule{

			private string timeStamp;

			private string value_;

			public string TimeStamp
			{
				get
				{
					return timeStamp;
				}
				set	
				{
					timeStamp = value;
				}
			}

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}
		}
	}
}