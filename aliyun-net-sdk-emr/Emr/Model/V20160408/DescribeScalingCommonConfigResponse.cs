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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class DescribeScalingCommonConfigResponse : AcsResponse
	{

		private string requestId;

		private int? autoScalingHookHeartbeatDefaultTime;

		private int? autoScalingCoolDownTime;

		private long? autoScalingMNSScalingThreadSleepTime;

		private int? autoScalingGroupMinSizeLimit;

		private int? autoScalingGroupMaxSizeLimit;

		private int? autoScalingRuleMinDelayLimit;

		private int? autoScalingRuleAlarmDelayLimit;

		private int? autoScalingRuleAlarmSilentTime;

		private int? autoScalingConfigSystemDiskSize;

		private long? autoScalingConfigDecommissionQueryInterval;

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

		public int? AutoScalingHookHeartbeatDefaultTime
		{
			get
			{
				return autoScalingHookHeartbeatDefaultTime;
			}
			set	
			{
				autoScalingHookHeartbeatDefaultTime = value;
			}
		}

		public int? AutoScalingCoolDownTime
		{
			get
			{
				return autoScalingCoolDownTime;
			}
			set	
			{
				autoScalingCoolDownTime = value;
			}
		}

		public long? AutoScalingMNSScalingThreadSleepTime
		{
			get
			{
				return autoScalingMNSScalingThreadSleepTime;
			}
			set	
			{
				autoScalingMNSScalingThreadSleepTime = value;
			}
		}

		public int? AutoScalingGroupMinSizeLimit
		{
			get
			{
				return autoScalingGroupMinSizeLimit;
			}
			set	
			{
				autoScalingGroupMinSizeLimit = value;
			}
		}

		public int? AutoScalingGroupMaxSizeLimit
		{
			get
			{
				return autoScalingGroupMaxSizeLimit;
			}
			set	
			{
				autoScalingGroupMaxSizeLimit = value;
			}
		}

		public int? AutoScalingRuleMinDelayLimit
		{
			get
			{
				return autoScalingRuleMinDelayLimit;
			}
			set	
			{
				autoScalingRuleMinDelayLimit = value;
			}
		}

		public int? AutoScalingRuleAlarmDelayLimit
		{
			get
			{
				return autoScalingRuleAlarmDelayLimit;
			}
			set	
			{
				autoScalingRuleAlarmDelayLimit = value;
			}
		}

		public int? AutoScalingRuleAlarmSilentTime
		{
			get
			{
				return autoScalingRuleAlarmSilentTime;
			}
			set	
			{
				autoScalingRuleAlarmSilentTime = value;
			}
		}

		public int? AutoScalingConfigSystemDiskSize
		{
			get
			{
				return autoScalingConfigSystemDiskSize;
			}
			set	
			{
				autoScalingConfigSystemDiskSize = value;
			}
		}

		public long? AutoScalingConfigDecommissionQueryInterval
		{
			get
			{
				return autoScalingConfigDecommissionQueryInterval;
			}
			set	
			{
				autoScalingConfigDecommissionQueryInterval = value;
			}
		}
	}
}
