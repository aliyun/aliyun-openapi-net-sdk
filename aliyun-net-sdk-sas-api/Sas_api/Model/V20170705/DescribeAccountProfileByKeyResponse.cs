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

namespace Aliyun.Acs.Sas_api.Model.V20170705
{
	public class DescribeAccountProfileByKeyResponse : AcsResponse
	{

		private string requestId;

		private string ip;

		private string ipInfo;

		private string phone;

		private string phoneInfo;

		private int? keywordCount;

		private int? keywordLimit;

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

		public string IpInfo
		{
			get
			{
				return ipInfo;
			}
			set	
			{
				ipInfo = value;
			}
		}

		public string Phone
		{
			get
			{
				return phone;
			}
			set	
			{
				phone = value;
			}
		}

		public string PhoneInfo
		{
			get
			{
				return phoneInfo;
			}
			set	
			{
				phoneInfo = value;
			}
		}

		public int? KeywordCount
		{
			get
			{
				return keywordCount;
			}
			set	
			{
				keywordCount = value;
			}
		}

		public int? KeywordLimit
		{
			get
			{
				return keywordLimit;
			}
			set	
			{
				keywordLimit = value;
			}
		}
	}
}
