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

namespace Aliyun.Acs.antiddos_public.Model.V20170518
{
	public class DescribeBgpPackByIpResponse : AcsResponse
	{

		private string requestId;

		private int? code;

		private bool? success;

		private DescribeBgpPackByIp_DdosbgpInfo ddosbgpInfo;

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

		public int? Code
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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public DescribeBgpPackByIp_DdosbgpInfo DdosbgpInfo
		{
			get
			{
				return ddosbgpInfo;
			}
			set	
			{
				ddosbgpInfo = value;
			}
		}

		public class DescribeBgpPackByIp_DdosbgpInfo
		{

			private string ip;

			private long? expireTime;

			private int? elasticThreshold;

			private int? baseThreshold;

			private string ddosbgpInstanceId;

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

			public int? ElasticThreshold
			{
				get
				{
					return elasticThreshold;
				}
				set	
				{
					elasticThreshold = value;
				}
			}

			public int? BaseThreshold
			{
				get
				{
					return baseThreshold;
				}
				set	
				{
					baseThreshold = value;
				}
			}

			public string DdosbgpInstanceId
			{
				get
				{
					return ddosbgpInstanceId;
				}
				set	
				{
					ddosbgpInstanceId = value;
				}
			}
		}
	}
}
