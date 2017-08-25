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

		private string requestId;

		private string domainName;

		private string dataInterval;

		private string startTime;

		private string endTime;

		private string locationNameEn;

		private string ispNameEn;

		private string locationName;

		private string ispName;

		private List<DescribeDomainBpsData_DataModule> bpsDataPerInterval;

		private List<DescribeDomainBpsData_DataModule1> supplyBpsDatas;

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

		public List<DescribeDomainBpsData_DataModule> BpsDataPerInterval
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

		public List<DescribeDomainBpsData_DataModule1> SupplyBpsDatas
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

		public class DescribeDomainBpsData_DataModule
		{

			private string timeStamp;

			private string _value;

			private string domesticValue;

			private string overseasValue;

			private string dynamicValue;

			private string dynamicDomesticValue;

			private string dynamicOverseasValue;

			private string staticValue;

			private string staticDomesticValue;

			private string staticOverseasValue;

			private string l2Value;

			private string domesticL2Value;

			private string overseasL2Value;

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

			public string _Value
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

			public string DynamicValue
			{
				get
				{
					return dynamicValue;
				}
				set	
				{
					dynamicValue = value;
				}
			}

			public string DynamicDomesticValue
			{
				get
				{
					return dynamicDomesticValue;
				}
				set	
				{
					dynamicDomesticValue = value;
				}
			}

			public string DynamicOverseasValue
			{
				get
				{
					return dynamicOverseasValue;
				}
				set	
				{
					dynamicOverseasValue = value;
				}
			}

			public string StaticValue
			{
				get
				{
					return staticValue;
				}
				set	
				{
					staticValue = value;
				}
			}

			public string StaticDomesticValue
			{
				get
				{
					return staticDomesticValue;
				}
				set	
				{
					staticDomesticValue = value;
				}
			}

			public string StaticOverseasValue
			{
				get
				{
					return staticOverseasValue;
				}
				set	
				{
					staticOverseasValue = value;
				}
			}

			public string L2Value
			{
				get
				{
					return l2Value;
				}
				set	
				{
					l2Value = value;
				}
			}

			public string DomesticL2Value
			{
				get
				{
					return domesticL2Value;
				}
				set	
				{
					domesticL2Value = value;
				}
			}

			public string OverseasL2Value
			{
				get
				{
					return overseasL2Value;
				}
				set	
				{
					overseasL2Value = value;
				}
			}
		}

		public class DescribeDomainBpsData_DataModule1
		{

			private string timeStamp;

			private string _value;

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

			public string _Value
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
		}
	}
}