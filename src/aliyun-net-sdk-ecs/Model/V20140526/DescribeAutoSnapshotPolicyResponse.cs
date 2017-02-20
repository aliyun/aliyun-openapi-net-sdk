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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeAutoSnapshotPolicyResponse : AcsResponse
	{
	    public int? AutoSnapshotOccupation { get; set; }

	    public AutoSnapshotPolicy_ AutoSnapshotPolicy { get; set; }

	    public AutoSnapshotExcutionStatus_ AutoSnapshotExcutionStatus { get; set; }

	    public class AutoSnapshotPolicy_{
	        public string SystemDiskPolicyEnabled { get; set; }

	        public string SystemDiskPolicyTimePeriod { get; set; }

	        public string SystemDiskPolicyRetentionDays { get; set; }

	        public string SystemDiskPolicyRetentionLastWeek { get; set; }

	        public string DataDiskPolicyEnabled { get; set; }

	        public string DataDiskPolicyTimePeriod { get; set; }

	        public string DataDiskPolicyRetentionDays { get; set; }

	        public string DataDiskPolicyRetentionLastWeek { get; set; }
	    }

		public class AutoSnapshotExcutionStatus_{
		    public SystemDiskExcutionStatusEnum? SystemDiskExcutionStatus { get; set; }

		    public DataDiskExcutionStatusEnum? DataDiskExcutionStatus { get; set; }

		    public enum SystemDiskExcutionStatusEnum {
			
					Standby,
					Failed,
					Executed,
			}

			public enum DataDiskExcutionStatusEnum {
			
					Standby,
					Failed,
					Executed,
			}
		}
	}
}