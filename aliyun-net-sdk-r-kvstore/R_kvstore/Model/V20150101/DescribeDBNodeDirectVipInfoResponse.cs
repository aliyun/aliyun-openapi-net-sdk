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

namespace Aliyun.Acs.R_kvstore.Model.V20150101
{
	public class DescribeDBNodeDirectVipInfoResponse : AcsResponse
	{

		private string requestId;

		private string instanceId;

		private List<DescribeDBNodeDirectVipInfo_VipInfo> directVipInfo;

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

		public List<DescribeDBNodeDirectVipInfo_VipInfo> DirectVipInfo
		{
			get
			{
				return directVipInfo;
			}
			set	
			{
				directVipInfo = value;
			}
		}

		public class DescribeDBNodeDirectVipInfo_VipInfo
		{

			private string nodeId;

			private string vip;

			private string port;

			private string netType;

			public string NodeId
			{
				get
				{
					return nodeId;
				}
				set	
				{
					nodeId = value;
				}
			}

			public string Vip
			{
				get
				{
					return vip;
				}
				set	
				{
					vip = value;
				}
			}

			public string Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string NetType
			{
				get
				{
					return netType;
				}
				set	
				{
					netType = value;
				}
			}
		}
	}
}
