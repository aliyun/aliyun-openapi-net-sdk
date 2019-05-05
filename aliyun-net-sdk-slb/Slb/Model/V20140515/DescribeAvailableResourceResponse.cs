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

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class DescribeAvailableResourceResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeAvailableResource_AvailableResource> availableResources;

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

		public List<DescribeAvailableResource_AvailableResource> AvailableResources
		{
			get
			{
				return availableResources;
			}
			set	
			{
				availableResources = value;
			}
		}

		public class DescribeAvailableResource_AvailableResource
		{

			private string masterZoneId;

			private string slaveZoneId;

			private List<DescribeAvailableResource_SupportResource> supportResources;

			public string MasterZoneId
			{
				get
				{
					return masterZoneId;
				}
				set	
				{
					masterZoneId = value;
				}
			}

			public string SlaveZoneId
			{
				get
				{
					return slaveZoneId;
				}
				set	
				{
					slaveZoneId = value;
				}
			}

			public List<DescribeAvailableResource_SupportResource> SupportResources
			{
				get
				{
					return supportResources;
				}
				set	
				{
					supportResources = value;
				}
			}

			public class DescribeAvailableResource_SupportResource
			{

				private string addressType;

				private string addressIPVersion;

				public string AddressType
				{
					get
					{
						return addressType;
					}
					set	
					{
						addressType = value;
					}
				}

				public string AddressIPVersion
				{
					get
					{
						return addressIPVersion;
					}
					set	
					{
						addressIPVersion = value;
					}
				}
			}
		}
	}
}
