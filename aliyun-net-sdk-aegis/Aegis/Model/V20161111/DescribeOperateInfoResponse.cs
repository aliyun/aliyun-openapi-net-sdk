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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeOperateInfoResponse : AcsResponse
	{

		private string requestId;

		private int? healthCheckDealedCount;

		private int? securityEventDealedCount;

		private int? vulnerabilityDealedCount;

		private bool? success;

		private List<string> suspEventValueArray;

		private List<string> suspEventAaggregatValueArray;

		private List<string> vulValueArray;

		private List<string> vulAaggregatValueArray;

		private List<string> dateArray;

		private List<string> healthCheckValueArray;

		private List<string> healthCheckAaggregatValueArray;

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

		public int? HealthCheckDealedCount
		{
			get
			{
				return healthCheckDealedCount;
			}
			set	
			{
				healthCheckDealedCount = value;
			}
		}

		public int? SecurityEventDealedCount
		{
			get
			{
				return securityEventDealedCount;
			}
			set	
			{
				securityEventDealedCount = value;
			}
		}

		public int? VulnerabilityDealedCount
		{
			get
			{
				return vulnerabilityDealedCount;
			}
			set	
			{
				vulnerabilityDealedCount = value;
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

		public List<string> SuspEventValueArray
		{
			get
			{
				return suspEventValueArray;
			}
			set	
			{
				suspEventValueArray = value;
			}
		}

		public List<string> SuspEventAaggregatValueArray
		{
			get
			{
				return suspEventAaggregatValueArray;
			}
			set	
			{
				suspEventAaggregatValueArray = value;
			}
		}

		public List<string> VulValueArray
		{
			get
			{
				return vulValueArray;
			}
			set	
			{
				vulValueArray = value;
			}
		}

		public List<string> VulAaggregatValueArray
		{
			get
			{
				return vulAaggregatValueArray;
			}
			set	
			{
				vulAaggregatValueArray = value;
			}
		}

		public List<string> DateArray
		{
			get
			{
				return dateArray;
			}
			set	
			{
				dateArray = value;
			}
		}

		public List<string> HealthCheckValueArray
		{
			get
			{
				return healthCheckValueArray;
			}
			set	
			{
				healthCheckValueArray = value;
			}
		}

		public List<string> HealthCheckAaggregatValueArray
		{
			get
			{
				return healthCheckAaggregatValueArray;
			}
			set	
			{
				healthCheckAaggregatValueArray = value;
			}
		}
	}
}
