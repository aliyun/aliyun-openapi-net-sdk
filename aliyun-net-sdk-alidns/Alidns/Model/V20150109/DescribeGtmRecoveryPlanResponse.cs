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

namespace Aliyun.Acs.Alidns.Model.V20150109
{
	public class DescribeGtmRecoveryPlanResponse : AcsResponse
	{

		private string requestId;

		private long? recoveryPlanId;

		private string name;

		private string remark;

		private int? faultAddrPoolNum;

		private string status;

		private string lastExecuteTime;

		private long? lastExecuteTimestamp;

		private string lastRollbackTime;

		private long? lastRollbackTimestamp;

		private string createTime;

		private long? createTimestamp;

		private string updateTime;

		private long? updateTimestamp;

		private List<DescribeGtmRecoveryPlan_FaultAddrPool> faultAddrPools;

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

		public long? RecoveryPlanId
		{
			get
			{
				return recoveryPlanId;
			}
			set	
			{
				recoveryPlanId = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
			}
		}

		public int? FaultAddrPoolNum
		{
			get
			{
				return faultAddrPoolNum;
			}
			set	
			{
				faultAddrPoolNum = value;
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string LastExecuteTime
		{
			get
			{
				return lastExecuteTime;
			}
			set	
			{
				lastExecuteTime = value;
			}
		}

		public long? LastExecuteTimestamp
		{
			get
			{
				return lastExecuteTimestamp;
			}
			set	
			{
				lastExecuteTimestamp = value;
			}
		}

		public string LastRollbackTime
		{
			get
			{
				return lastRollbackTime;
			}
			set	
			{
				lastRollbackTime = value;
			}
		}

		public long? LastRollbackTimestamp
		{
			get
			{
				return lastRollbackTimestamp;
			}
			set	
			{
				lastRollbackTimestamp = value;
			}
		}

		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public long? CreateTimestamp
		{
			get
			{
				return createTimestamp;
			}
			set	
			{
				createTimestamp = value;
			}
		}

		public string UpdateTime
		{
			get
			{
				return updateTime;
			}
			set	
			{
				updateTime = value;
			}
		}

		public long? UpdateTimestamp
		{
			get
			{
				return updateTimestamp;
			}
			set	
			{
				updateTimestamp = value;
			}
		}

		public List<DescribeGtmRecoveryPlan_FaultAddrPool> FaultAddrPools
		{
			get
			{
				return faultAddrPools;
			}
			set	
			{
				faultAddrPools = value;
			}
		}

		public class DescribeGtmRecoveryPlan_FaultAddrPool
		{

			private string addrPoolId;

			private string addrPoolName;

			private string instanceId;

			private List<DescribeGtmRecoveryPlan_Addr> addrs;

			public string AddrPoolId
			{
				get
				{
					return addrPoolId;
				}
				set	
				{
					addrPoolId = value;
				}
			}

			public string AddrPoolName
			{
				get
				{
					return addrPoolName;
				}
				set	
				{
					addrPoolName = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public List<DescribeGtmRecoveryPlan_Addr> Addrs
			{
				get
				{
					return addrs;
				}
				set	
				{
					addrs = value;
				}
			}

			public class DescribeGtmRecoveryPlan_Addr
			{

				private long? id;

				private string mode;

				private string _value;

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}

				public string Mode
				{
					get
					{
						return mode;
					}
					set	
					{
						mode = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}
		}
	}
}
