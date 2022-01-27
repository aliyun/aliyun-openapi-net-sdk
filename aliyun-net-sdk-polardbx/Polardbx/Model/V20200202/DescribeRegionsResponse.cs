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

namespace Aliyun.Acs.polardbx.Model.V20200202
{
	public class DescribeRegionsResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private int? errorCode;

		private bool? success;

		private string message;

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

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

			private bool? supportPolarx20;

			private List<DescribeRegions_Zone> zones;

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

			public bool? SupportPolarx20
			{
				get
				{
					return supportPolarx20;
				}
				set	
				{
					supportPolarx20 = value;
				}
			}

			public List<DescribeRegions_Zone> Zones
			{
				get
				{
					return zones;
				}
				set	
				{
					zones = value;
				}
			}

			public class DescribeRegions_Zone
			{

				private string zoneId;

				private bool? vpcEnabled;

				public string ZoneId
				{
					get
					{
						return zoneId;
					}
					set	
					{
						zoneId = value;
					}
				}

				public bool? VpcEnabled
				{
					get
					{
						return vpcEnabled;
					}
					set	
					{
						vpcEnabled = value;
					}
				}
			}
		}
	}
}
