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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeSpotAdviceResponse : AcsResponse
	{

		private string requestId;

		private string regionId;

		private List<DescribeSpotAdvice_AvailableSpotZone> availableSpotZones;

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

		public List<DescribeSpotAdvice_AvailableSpotZone> AvailableSpotZones
		{
			get
			{
				return availableSpotZones;
			}
			set	
			{
				availableSpotZones = value;
			}
		}

		public class DescribeSpotAdvice_AvailableSpotZone
		{

			private string zoneId;

			private List<DescribeSpotAdvice_AvailableSpotResource> availableSpotResources;

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

			public List<DescribeSpotAdvice_AvailableSpotResource> AvailableSpotResources
			{
				get
				{
					return availableSpotResources;
				}
				set	
				{
					availableSpotResources = value;
				}
			}

			public class DescribeSpotAdvice_AvailableSpotResource
			{

				private string instanceType;

				private float? interruptionRate;

				private string interruptRateDesc;

				private int? averageSpotDiscount;

				public string InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}

				public float? InterruptionRate
				{
					get
					{
						return interruptionRate;
					}
					set	
					{
						interruptionRate = value;
					}
				}

				public string InterruptRateDesc
				{
					get
					{
						return interruptRateDesc;
					}
					set	
					{
						interruptRateDesc = value;
					}
				}

				public int? AverageSpotDiscount
				{
					get
					{
						return averageSpotDiscount;
					}
					set	
					{
						averageSpotDiscount = value;
					}
				}
			}
		}
	}
}
