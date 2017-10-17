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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeMonthlyServiceStatusResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private List<DescribeMonthlyServiceStatus_InstanceSLAInfo> instanceSLAInfos;

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

		public List<DescribeMonthlyServiceStatus_InstanceSLAInfo> InstanceSLAInfos
		{
			get
			{
				return instanceSLAInfos;
			}
			set	
			{
				instanceSLAInfos = value;
			}
		}

		public class DescribeMonthlyServiceStatus_InstanceSLAInfo
		{

			private string instanceId;

			private float? uptimePct;

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

			public float? UptimePct
			{
				get
				{
					return uptimePct;
				}
				set	
				{
					uptimePct = value;
				}
			}
		}
	}
}