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

namespace Aliyun.Acs.Dds.Model.V20151201
{
	public class DescribeDBInstanceSSLResponse : AcsResponse
	{

		private string sSLExpiredTime;

		private string sSLStatus;

		private string requestId;

		private string certCommonName;

		public string SSLExpiredTime
		{
			get
			{
				return sSLExpiredTime;
			}
			set	
			{
				sSLExpiredTime = value;
			}
		}

		public string SSLStatus
		{
			get
			{
				return sSLStatus;
			}
			set	
			{
				sSLStatus = value;
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

		public string CertCommonName
		{
			get
			{
				return certCommonName;
			}
			set	
			{
				certCommonName = value;
			}
		}
	}
}
