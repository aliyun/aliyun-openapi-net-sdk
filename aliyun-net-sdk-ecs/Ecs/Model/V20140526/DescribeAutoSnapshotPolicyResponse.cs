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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeAutoSnapshotPolicyResponse : AcsResponse
	{

		private int? autoSnapshotOccupation;

		private AutoSnapshotPolicy_ autoSnapshotPolicy;

		private AutoSnapshotExcutionStatus_ autoSnapshotExcutionStatus;

		public int? AutoSnapshotOccupation
		{
			get
			{
				return autoSnapshotOccupation;
			}
			set	
			{
				autoSnapshotOccupation = value;
			}
		}

		public AutoSnapshotPolicy_ AutoSnapshotPolicy
		{
			get
			{
				return autoSnapshotPolicy;
			}
			set	
			{
				autoSnapshotPolicy = value;
			}
		}

		public AutoSnapshotExcutionStatus_ AutoSnapshotExcutionStatus
		{
			get
			{
				return autoSnapshotExcutionStatus;
			}
			set	
			{
				autoSnapshotExcutionStatus = value;
			}
		}

		public class AutoSnapshotPolicy_{

			private string systemDiskPolicyEnabled;

			private string systemDiskPolicyTimePeriod;

			private string systemDiskPolicyRetentionDays;

			private string systemDiskPolicyRetentionLastWeek;

			private string dataDiskPolicyEnabled;

			private string dataDiskPolicyTimePeriod;

			private string dataDiskPolicyRetentionDays;

			private string dataDiskPolicyRetentionLastWeek;

			public string SystemDiskPolicyEnabled
			{
				get
				{
					return systemDiskPolicyEnabled;
				}
				set	
				{
					systemDiskPolicyEnabled = value;
				}
			}

			public string SystemDiskPolicyTimePeriod
			{
				get
				{
					return systemDiskPolicyTimePeriod;
				}
				set	
				{
					systemDiskPolicyTimePeriod = value;
				}
			}

			public string SystemDiskPolicyRetentionDays
			{
				get
				{
					return systemDiskPolicyRetentionDays;
				}
				set	
				{
					systemDiskPolicyRetentionDays = value;
				}
			}

			public string SystemDiskPolicyRetentionLastWeek
			{
				get
				{
					return systemDiskPolicyRetentionLastWeek;
				}
				set	
				{
					systemDiskPolicyRetentionLastWeek = value;
				}
			}

			public string DataDiskPolicyEnabled
			{
				get
				{
					return dataDiskPolicyEnabled;
				}
				set	
				{
					dataDiskPolicyEnabled = value;
				}
			}

			public string DataDiskPolicyTimePeriod
			{
				get
				{
					return dataDiskPolicyTimePeriod;
				}
				set	
				{
					dataDiskPolicyTimePeriod = value;
				}
			}

			public string DataDiskPolicyRetentionDays
			{
				get
				{
					return dataDiskPolicyRetentionDays;
				}
				set	
				{
					dataDiskPolicyRetentionDays = value;
				}
			}

			public string DataDiskPolicyRetentionLastWeek
			{
				get
				{
					return dataDiskPolicyRetentionLastWeek;
				}
				set	
				{
					dataDiskPolicyRetentionLastWeek = value;
				}
			}
		}

		public class AutoSnapshotExcutionStatus_{

			private SystemDiskExcutionStatus_ systemDiskExcutionStatus;

			private DataDiskExcutionStatus_ dataDiskExcutionStatus;

			public SystemDiskExcutionStatus_ SystemDiskExcutionStatus
			{
				get
				{
					return systemDiskExcutionStatus;
				}
				set	
				{
					systemDiskExcutionStatus = value;
				}
			}

			public DataDiskExcutionStatus_ DataDiskExcutionStatus
			{
				get
				{
					return dataDiskExcutionStatus;
				}
				set	
				{
					dataDiskExcutionStatus = value;
				}
			}

			public enum SystemDiskExcutionStatus_ {
			
					Standby,
					Failed,
					Executed,
			}

			public enum DataDiskExcutionStatus_ {
			
					Standby,
					Failed,
					Executed,
			}
		}
	}
}