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

namespace Aliyun.Acs.Ess.Model.V20140828
{
	public class DescribeRegionsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRegions_Region> regions;

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

		public List<DescribeRegions_Region> Regions
		{
			get
			{
				return regions;
			}
			set	
			{
				regions = value;
			}
		}

		public class DescribeRegions_Region
		{

			private string regionId;

			private bool? classicUnavailable;

			private bool? vpcUnavailable;

			private string regionEndpoint;

			private string localName;

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

			public bool? ClassicUnavailable
			{
				get
				{
					return classicUnavailable;
				}
				set	
				{
					classicUnavailable = value;
				}
			}

			public bool? VpcUnavailable
			{
				get
				{
					return vpcUnavailable;
				}
				set	
				{
					vpcUnavailable = value;
				}
			}

			public string RegionEndpoint
			{
				get
				{
					return regionEndpoint;
				}
				set	
				{
					regionEndpoint = value;
				}
			}

			public string LocalName
			{
				get
				{
					return localName;
				}
				set	
				{
					localName = value;
				}
			}
		}
	}
}
