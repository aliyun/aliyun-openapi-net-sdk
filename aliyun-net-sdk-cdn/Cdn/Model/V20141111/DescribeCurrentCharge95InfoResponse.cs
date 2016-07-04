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
	public class DescribeCurrentCharge95InfoResponse : AcsResponse
	{

		private CurrentCharge95Info_ currentCharge95Info;

		public CurrentCharge95Info_ CurrentCharge95Info
		{
			get
			{
				return currentCharge95Info;
			}
			set	
			{
				currentCharge95Info = value;
			}
		}

		public class CurrentCharge95Info_{

			private long? max95Bps;

			private long? domesticMax95Bps;

			private long? overseasMax95Bps;

			private float? effectiveFactor;

			private float? cost;

			private string userName;

			public long? Max95Bps
			{
				get
				{
					return max95Bps;
				}
				set	
				{
					max95Bps = value;
				}
			}

			public long? DomesticMax95Bps
			{
				get
				{
					return domesticMax95Bps;
				}
				set	
				{
					domesticMax95Bps = value;
				}
			}

			public long? OverseasMax95Bps
			{
				get
				{
					return overseasMax95Bps;
				}
				set	
				{
					overseasMax95Bps = value;
				}
			}

			public float? EffectiveFactor
			{
				get
				{
					return effectiveFactor;
				}
				set	
				{
					effectiveFactor = value;
				}
			}

			public float? Cost
			{
				get
				{
					return cost;
				}
				set	
				{
					cost = value;
				}
			}

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}
		}
	}
}