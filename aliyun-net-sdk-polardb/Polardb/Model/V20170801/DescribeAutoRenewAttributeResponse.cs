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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeAutoRenewAttributeResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? totalRecordCount;

		private int? pageRecordCount;

		private List<DescribeAutoRenewAttribute_AutoRenewAttribute> items;

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

		public int? TotalRecordCount
		{
			get
			{
				return totalRecordCount;
			}
			set	
			{
				totalRecordCount = value;
			}
		}

		public int? PageRecordCount
		{
			get
			{
				return pageRecordCount;
			}
			set	
			{
				pageRecordCount = value;
			}
		}

		public List<DescribeAutoRenewAttribute_AutoRenewAttribute> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeAutoRenewAttribute_AutoRenewAttribute
		{

			private string dBClusterId;

			private string regionId;

			private bool? autoRenewEnabled;

			private int? duration;

			private string periodUnit;

			private string renewalStatus;

			public string DBClusterId
			{
				get
				{
					return dBClusterId;
				}
				set	
				{
					dBClusterId = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public bool? AutoRenewEnabled
			{
				get
				{
					return autoRenewEnabled;
				}
				set	
				{
					autoRenewEnabled = value;
				}
			}

			public int? Duration
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

			public string PeriodUnit
			{
				get
				{
					return periodUnit;
				}
				set	
				{
					periodUnit = value;
				}
			}

			public string RenewalStatus
			{
				get
				{
					return renewalStatus;
				}
				set	
				{
					renewalStatus = value;
				}
			}
		}
	}
}
