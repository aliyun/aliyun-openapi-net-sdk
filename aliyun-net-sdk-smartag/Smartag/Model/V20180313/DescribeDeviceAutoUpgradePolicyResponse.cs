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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeDeviceAutoUpgradePolicyResponse : AcsResponse
	{

		private string requestId;

		private string smartAGId;

		private string serialNumber;

		private string upgradeType;

		private string cronExpression;

		private string duration;

		private string timeZone;

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

		public string SmartAGId
		{
			get
			{
				return smartAGId;
			}
			set	
			{
				smartAGId = value;
			}
		}

		public string SerialNumber
		{
			get
			{
				return serialNumber;
			}
			set	
			{
				serialNumber = value;
			}
		}

		public string UpgradeType
		{
			get
			{
				return upgradeType;
			}
			set	
			{
				upgradeType = value;
			}
		}

		public string CronExpression
		{
			get
			{
				return cronExpression;
			}
			set	
			{
				cronExpression = value;
			}
		}

		public string Duration
		{
			get
			{
				return duration;
			}
			set	
			{
				duration = value;
			}
		}

		public string TimeZone
		{
			get
			{
				return timeZone;
			}
			set	
			{
				timeZone = value;
			}
		}
	}
}
