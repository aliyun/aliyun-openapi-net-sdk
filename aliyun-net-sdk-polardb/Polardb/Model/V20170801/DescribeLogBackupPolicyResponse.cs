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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeLogBackupPolicyResponse : AcsResponse
	{

		private int? logBackupRetentionPeriod;

		private string requestId;

		private string logBackupAnotherRegionRetentionPeriod;

		private string logBackupAnotherRegionRegion;

		private int? enableBackupLog;

		public int? LogBackupRetentionPeriod
		{
			get
			{
				return logBackupRetentionPeriod;
			}
			set	
			{
				logBackupRetentionPeriod = value;
			}
		}

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

		public string LogBackupAnotherRegionRetentionPeriod
		{
			get
			{
				return logBackupAnotherRegionRetentionPeriod;
			}
			set	
			{
				logBackupAnotherRegionRetentionPeriod = value;
			}
		}

		public string LogBackupAnotherRegionRegion
		{
			get
			{
				return logBackupAnotherRegionRegion;
			}
			set	
			{
				logBackupAnotherRegionRegion = value;
			}
		}

		public int? EnableBackupLog
		{
			get
			{
				return enableBackupLog;
			}
			set	
			{
				enableBackupLog = value;
			}
		}
	}
}
