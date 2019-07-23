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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBClusterMigrationResponse : AcsResponse
	{

		private string requestId;

		private string dBClusterId;

		private string sourceRDSDBInstanceId;

		private string migrationStatus;

		private string topologies;

		private int? delayedSeconds;

		private string expiredTime;

		private string rdsReadWriteMode;

		private string dBClusterReadWriteMode;

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

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
			}
		}

		public string SourceRDSDBInstanceId
		{
			get
			{
				return sourceRDSDBInstanceId;
			}
			set	
			{
				sourceRDSDBInstanceId = value;
			}
		}

		public string MigrationStatus
		{
			get
			{
				return migrationStatus;
			}
			set	
			{
				migrationStatus = value;
			}
		}

		public string Topologies
		{
			get
			{
				return topologies;
			}
			set	
			{
				topologies = value;
			}
		}

		public int? DelayedSeconds
		{
			get
			{
				return delayedSeconds;
			}
			set	
			{
				delayedSeconds = value;
			}
		}

		public string ExpiredTime
		{
			get
			{
				return expiredTime;
			}
			set	
			{
				expiredTime = value;
			}
		}

		public string RdsReadWriteMode
		{
			get
			{
				return rdsReadWriteMode;
			}
			set	
			{
				rdsReadWriteMode = value;
			}
		}

		public string DBClusterReadWriteMode
		{
			get
			{
				return dBClusterReadWriteMode;
			}
			set	
			{
				dBClusterReadWriteMode = value;
			}
		}
	}
}
