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

namespace Aliyun.Acs.waf_openapi.Model.V20190910
{
	public class DescribeInstanceSpecInfoResponse : AcsResponse
	{

		private string requestId;

		private string instanceId;

		private string version;

		private long? expireTime;

		private List<DescribeInstanceSpecInfo_InstanceSpecInfo> instanceSpecInfos;

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

		public string Version
		{
			get
			{
				return version;
			}
			set	
			{
				version = value;
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

		public List<DescribeInstanceSpecInfo_InstanceSpecInfo> InstanceSpecInfos
		{
			get
			{
				return instanceSpecInfos;
			}
			set	
			{
				instanceSpecInfos = value;
			}
		}

		public class DescribeInstanceSpecInfo_InstanceSpecInfo
		{

			private string _value;

			private string code;

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

			public string Code
			{
				get
				{
					return code;
				}
				set	
				{
					code = value;
				}
			}
		}
	}
}
