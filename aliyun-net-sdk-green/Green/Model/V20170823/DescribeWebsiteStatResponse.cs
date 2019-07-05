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

namespace Aliyun.Acs.Green.Model.V20170823
{
	public class DescribeWebsiteStatResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private List<DescribeWebsiteStat_WebsiteStat> websiteStatList;

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

		public List<DescribeWebsiteStat_WebsiteStat> WebsiteStatList
		{
			get
			{
				return websiteStatList;
			}
			set	
			{
				websiteStatList = value;
			}
		}

		public class DescribeWebsiteStat_WebsiteStat
		{

			private string subServiceModule;

			private int? instanceCount;

			private int? scanCount;

			private int? riskCount;

			public string SubServiceModule
			{
				get
				{
					return subServiceModule;
				}
				set	
				{
					subServiceModule = value;
				}
			}

			public int? InstanceCount
			{
				get
				{
					return instanceCount;
				}
				set	
				{
					instanceCount = value;
				}
			}

			public int? ScanCount
			{
				get
				{
					return scanCount;
				}
				set	
				{
					scanCount = value;
				}
			}

			public int? RiskCount
			{
				get
				{
					return riskCount;
				}
				set	
				{
					riskCount = value;
				}
			}
		}
	}
}
