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
	public class DescribeBandwidthLimitationResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeBandwidthLimitation_Bandwidth> bandwidths;

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

		public List<DescribeBandwidthLimitation_Bandwidth> Bandwidths
		{
			get
			{
				return bandwidths;
			}
			set	
			{
				bandwidths = value;
			}
		}

		public class DescribeBandwidthLimitation_Bandwidth
		{

			private string internetChargeType;

			private int? min;

			private int? max;

			private string unit;

			public string InternetChargeType
			{
				get
				{
					return internetChargeType;
				}
				set	
				{
					internetChargeType = value;
				}
			}

			public int? Min
			{
				get
				{
					return min;
				}
				set	
				{
					min = value;
				}
			}

			public int? Max
			{
				get
				{
					return max;
				}
				set	
				{
					max = value;
				}
			}

			public string Unit
			{
				get
				{
					return unit;
				}
				set	
				{
					unit = value;
				}
			}
		}
	}
}
