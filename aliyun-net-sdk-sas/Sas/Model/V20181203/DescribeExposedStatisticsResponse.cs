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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeExposedStatisticsResponse : AcsResponse
	{

		private string requestId;

		private int? exposedInstanceCount;

		private int? gatewayAssetCount;

		private int? exposedIpCount;

		private int? exposedPortCount;

		private int? exposedComponentCount;

		private int? exposedAsapVulCount;

		private int? exposedLaterVulCount;

		private int? exposedNntfVulCount;

		private int? exposedWeekPasswordMachineCount;

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

		public int? ExposedInstanceCount
		{
			get
			{
				return exposedInstanceCount;
			}
			set	
			{
				exposedInstanceCount = value;
			}
		}

		public int? GatewayAssetCount
		{
			get
			{
				return gatewayAssetCount;
			}
			set	
			{
				gatewayAssetCount = value;
			}
		}

		public int? ExposedIpCount
		{
			get
			{
				return exposedIpCount;
			}
			set	
			{
				exposedIpCount = value;
			}
		}

		public int? ExposedPortCount
		{
			get
			{
				return exposedPortCount;
			}
			set	
			{
				exposedPortCount = value;
			}
		}

		public int? ExposedComponentCount
		{
			get
			{
				return exposedComponentCount;
			}
			set	
			{
				exposedComponentCount = value;
			}
		}

		public int? ExposedAsapVulCount
		{
			get
			{
				return exposedAsapVulCount;
			}
			set	
			{
				exposedAsapVulCount = value;
			}
		}

		public int? ExposedLaterVulCount
		{
			get
			{
				return exposedLaterVulCount;
			}
			set	
			{
				exposedLaterVulCount = value;
			}
		}

		public int? ExposedNntfVulCount
		{
			get
			{
				return exposedNntfVulCount;
			}
			set	
			{
				exposedNntfVulCount = value;
			}
		}

		public int? ExposedWeekPasswordMachineCount
		{
			get
			{
				return exposedWeekPasswordMachineCount;
			}
			set	
			{
				exposedWeekPasswordMachineCount = value;
			}
		}
	}
}
