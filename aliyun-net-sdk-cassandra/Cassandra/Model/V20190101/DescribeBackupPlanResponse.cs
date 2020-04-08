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

namespace Aliyun.Acs.Cassandra.Model.V20190101
{
	public class DescribeBackupPlanResponse : AcsResponse
	{

		private string requestId;

		private DescribeBackupPlan_BackupPlan backupPlan;

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

		public DescribeBackupPlan_BackupPlan BackupPlan
		{
			get
			{
				return backupPlan;
			}
			set	
			{
				backupPlan = value;
			}
		}

		public class DescribeBackupPlan_BackupPlan
		{

			private string clusterId;

			private string dataCenterId;

			private string createdTime;

			private string backupTime;

			private string backupPeriod;

			private int? retentionPeriod;

			private bool? active;

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public string DataCenterId
			{
				get
				{
					return dataCenterId;
				}
				set	
				{
					dataCenterId = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public string BackupTime
			{
				get
				{
					return backupTime;
				}
				set	
				{
					backupTime = value;
				}
			}

			public string BackupPeriod
			{
				get
				{
					return backupPeriod;
				}
				set	
				{
					backupPeriod = value;
				}
			}

			public int? RetentionPeriod
			{
				get
				{
					return retentionPeriod;
				}
				set	
				{
					retentionPeriod = value;
				}
			}

			public bool? Active
			{
				get
				{
					return active;
				}
				set	
				{
					active = value;
				}
			}
		}
	}
}
