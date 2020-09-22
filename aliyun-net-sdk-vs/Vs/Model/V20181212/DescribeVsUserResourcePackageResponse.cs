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

namespace Aliyun.Acs.vs.Model.V20181212
{
	public class DescribeVsUserResourcePackageResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeVsUserResourcePackage_ResourcePackageInfo> resourcePackageInfos;

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

		public List<DescribeVsUserResourcePackage_ResourcePackageInfo> ResourcePackageInfos
		{
			get
			{
				return resourcePackageInfos;
			}
			set	
			{
				resourcePackageInfos = value;
			}
		}

		public class DescribeVsUserResourcePackage_ResourcePackageInfo
		{

			private string currCapacity;

			private string initCapacity;

			private string commodityCode;

			private string displayName;

			private string instanceId;

			private string status;

			public string CurrCapacity
			{
				get
				{
					return currCapacity;
				}
				set	
				{
					currCapacity = value;
				}
			}

			public string InitCapacity
			{
				get
				{
					return initCapacity;
				}
				set	
				{
					initCapacity = value;
				}
			}

			public string CommodityCode
			{
				get
				{
					return commodityCode;
				}
				set	
				{
					commodityCode = value;
				}
			}

			public string DisplayName
			{
				get
				{
					return displayName;
				}
				set	
				{
					displayName = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string Status
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
		}
	}
}
