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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeDBInstanceExtendAttributeResponse : AcsResponse
	{

		private string requestId;

		private bool? canTempUpgrade;

		private string tempUpgradeTimeStart;

		private string tempUpgradeTimeEnd;

		private string tempUpgradeRecoveryTime;

		private string tempUpgradeRecoveryClass;

		private int? tempUpgradeRecoveryCpu;

		private int? tempUpgradeRecoveryMemory;

		private string tempUpgradeRecoveryMaxIOPS;

		private string tempUpgradeRecoveryMaxConnections;

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

		public bool? CanTempUpgrade
		{
			get
			{
				return canTempUpgrade;
			}
			set	
			{
				canTempUpgrade = value;
			}
		}

		public string TempUpgradeTimeStart
		{
			get
			{
				return tempUpgradeTimeStart;
			}
			set	
			{
				tempUpgradeTimeStart = value;
			}
		}

		public string TempUpgradeTimeEnd
		{
			get
			{
				return tempUpgradeTimeEnd;
			}
			set	
			{
				tempUpgradeTimeEnd = value;
			}
		}

		public string TempUpgradeRecoveryTime
		{
			get
			{
				return tempUpgradeRecoveryTime;
			}
			set	
			{
				tempUpgradeRecoveryTime = value;
			}
		}

		public string TempUpgradeRecoveryClass
		{
			get
			{
				return tempUpgradeRecoveryClass;
			}
			set	
			{
				tempUpgradeRecoveryClass = value;
			}
		}

		public int? TempUpgradeRecoveryCpu
		{
			get
			{
				return tempUpgradeRecoveryCpu;
			}
			set	
			{
				tempUpgradeRecoveryCpu = value;
			}
		}

		public int? TempUpgradeRecoveryMemory
		{
			get
			{
				return tempUpgradeRecoveryMemory;
			}
			set	
			{
				tempUpgradeRecoveryMemory = value;
			}
		}

		public string TempUpgradeRecoveryMaxIOPS
		{
			get
			{
				return tempUpgradeRecoveryMaxIOPS;
			}
			set	
			{
				tempUpgradeRecoveryMaxIOPS = value;
			}
		}

		public string TempUpgradeRecoveryMaxConnections
		{
			get
			{
				return tempUpgradeRecoveryMaxConnections;
			}
			set	
			{
				tempUpgradeRecoveryMaxConnections = value;
			}
		}
	}
}