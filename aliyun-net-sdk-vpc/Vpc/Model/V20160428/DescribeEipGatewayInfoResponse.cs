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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeEipGatewayInfoResponse : AcsResponse
	{

		private string code;

		private string message;

		private string requestId;

		private List<DescribeEipGatewayInfo_EipInfo> eipInfos;

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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public List<DescribeEipGatewayInfo_EipInfo> EipInfos
		{
			get
			{
				return eipInfos;
			}
			set	
			{
				eipInfos = value;
			}
		}

		public class DescribeEipGatewayInfo_EipInfo
		{

			private string ip;

			private string ipGw;

			private string ipMask;

			public string Ip
			{
				get
				{
					return ip;
				}
				set	
				{
					ip = value;
				}
			}

			public string IpGw
			{
				get
				{
					return ipGw;
				}
				set	
				{
					ipGw = value;
				}
			}

			public string IpMask
			{
				get
				{
					return ipMask;
				}
				set	
				{
					ipMask = value;
				}
			}
		}
	}
}
