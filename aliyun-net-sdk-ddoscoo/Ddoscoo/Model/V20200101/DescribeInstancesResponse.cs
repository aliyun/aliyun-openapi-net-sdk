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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeInstancesResponse : AcsResponse
	{

		private long? totalCount;

		private string requestId;

		private List<DescribeInstances_Instance> instances;

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
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

		public List<DescribeInstances_Instance> Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
			}
		}

		public class DescribeInstances_Instance
		{

			private int? status;

			private string ipMode;

			private int? debtStatus;

			private int? edition;

			private string ipVersion;

			private long? expireTime;

			private string remark;

			private long? createTime;

			private int? enabled;

			private string instanceId;

			private string connInstanceId;

			public int? Status
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

			public string IpMode
			{
				get
				{
					return ipMode;
				}
				set	
				{
					ipMode = value;
				}
			}

			public int? DebtStatus
			{
				get
				{
					return debtStatus;
				}
				set	
				{
					debtStatus = value;
				}
			}

			public int? Edition
			{
				get
				{
					return edition;
				}
				set	
				{
					edition = value;
				}
			}

			public string IpVersion
			{
				get
				{
					return ipVersion;
				}
				set	
				{
					ipVersion = value;
				}
			}

			public long? ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
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

			public long? CreateTime
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

			public int? Enabled
			{
				get
				{
					return enabled;
				}
				set	
				{
					enabled = value;
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

			public string ConnInstanceId
			{
				get
				{
					return connInstanceId;
				}
				set	
				{
					connInstanceId = value;
				}
			}
		}
	}
}
