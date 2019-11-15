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

namespace Aliyun.Acs.dcdn.Model.V20180115
{
	public class DescribeDcdnDomainQpsDataResponse : AcsResponse
	{

		private string requestId;

		private string domainName;

		private string startTime;

		private string endTime;

		private string dataInterval;

		private List<DescribeDcdnDomainQpsData_DataModule> qpsDataPerInterval;

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

		public List<DescribeDcdnDomainQpsData_DataModule> QpsDataPerInterval
		{
			get
			{
				return qpsDataPerInterval;
			}
			set	
			{
				qpsDataPerInterval = value;
			}
		}

		public class DescribeDcdnDomainQpsData_DataModule
		{

			private string timeStamp;

			private float? qps;

			private float? dynamicHttpQps;

			private float? dynamicHttpsQps;

			private float? staticHttpQps;

			private float? staticHttpsQps;

			private float? acc;

			private float? dynamicHttpAcc;

			private float? dynamicHttpsAcc;

			private float? staticHttpAcc;

			private float? staticHttpsAcc;

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

			public float? Qps
			{
				get
				{
					return qps;
				}
				set	
				{
					qps = value;
				}
			}

			public float? DynamicHttpQps
			{
				get
				{
					return dynamicHttpQps;
				}
				set	
				{
					dynamicHttpQps = value;
				}
			}

			public float? DynamicHttpsQps
			{
				get
				{
					return dynamicHttpsQps;
				}
				set	
				{
					dynamicHttpsQps = value;
				}
			}

			public float? StaticHttpQps
			{
				get
				{
					return staticHttpQps;
				}
				set	
				{
					staticHttpQps = value;
				}
			}

			public float? StaticHttpsQps
			{
				get
				{
					return staticHttpsQps;
				}
				set	
				{
					staticHttpsQps = value;
				}
			}

			public float? Acc
			{
				get
				{
					return acc;
				}
				set	
				{
					acc = value;
				}
			}

			public float? DynamicHttpAcc
			{
				get
				{
					return dynamicHttpAcc;
				}
				set	
				{
					dynamicHttpAcc = value;
				}
			}

			public float? DynamicHttpsAcc
			{
				get
				{
					return dynamicHttpsAcc;
				}
				set	
				{
					dynamicHttpsAcc = value;
				}
			}

			public float? StaticHttpAcc
			{
				get
				{
					return staticHttpAcc;
				}
				set	
				{
					staticHttpAcc = value;
				}
			}

			public float? StaticHttpsAcc
			{
				get
				{
					return staticHttpsAcc;
				}
				set	
				{
					staticHttpsAcc = value;
				}
			}
		}
	}
}
