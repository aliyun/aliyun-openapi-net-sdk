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

namespace Aliyun.Acs.ddosbgp.Model.V20180720
{
	public class DescribeInstanceListResponse : AcsResponse
	{

		private long? total;

		private string requestId;

		private List<DescribeInstanceList_Instance> instanceList;

		public long? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
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

		public List<DescribeInstanceList_Instance> InstanceList
		{
			get
			{
				return instanceList;
			}
			set	
			{
				instanceList = value;
			}
		}

		public class DescribeInstanceList_Instance
		{

			private string status;

			private string ipType;

			private bool? autoRenewal;

			private string remark;

			private long? expireTime;

			private string product;

			private long? gmtCreate;

			private string instanceId;

			private string instanceType;

			private string blackholdingCount;

			private int? coverageType;

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

			public string IpType
			{
				get
				{
					return ipType;
				}
				set	
				{
					ipType = value;
				}
			}

			public bool? AutoRenewal
			{
				get
				{
					return autoRenewal;
				}
				set	
				{
					autoRenewal = value;
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

			public string Product
			{
				get
				{
					return product;
				}
				set	
				{
					product = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
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

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public string BlackholdingCount
			{
				get
				{
					return blackholdingCount;
				}
				set	
				{
					blackholdingCount = value;
				}
			}

			public int? CoverageType
			{
				get
				{
					return coverageType;
				}
				set	
				{
					coverageType = value;
				}
			}
		}
	}
}
