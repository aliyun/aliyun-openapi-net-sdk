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
	public class BatchDescribeDomainBpsDataResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<BatchDescribeDomainBpsData_DataModule> bpsDatas;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<BatchDescribeDomainBpsData_DataModule> BpsDatas
		{
			get
			{
				return bpsDatas;
			}
			set	
			{
				bpsDatas = value;
			}
		}

		public class BatchDescribeDomainBpsData_DataModule
		{

			private string timestamp;

			private float? l1Bps;

			private float? l1InnerBps;

			private float? l1OutBps;

			private string domainName;

			public string Timestamp
			{
				get
				{
					return timestamp;
				}
				set	
				{
					timestamp = value;
				}
			}

			public float? L1Bps
			{
				get
				{
					return l1Bps;
				}
				set	
				{
					l1Bps = value;
				}
			}

			public float? L1InnerBps
			{
				get
				{
					return l1InnerBps;
				}
				set	
				{
					l1InnerBps = value;
				}
			}

			public float? L1OutBps
			{
				get
				{
					return l1OutBps;
				}
				set	
				{
					l1OutBps = value;
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
		}
	}
}