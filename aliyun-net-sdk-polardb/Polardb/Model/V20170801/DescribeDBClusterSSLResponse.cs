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

namespace Aliyun.Acs.polardb.Model.V20170801
{
	public class DescribeDBClusterSSLResponse : AcsResponse
	{

		private string requestId;

		private string sSLAutoRotate;

		private List<DescribeDBClusterSSL_Item> items;

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

		public string SSLAutoRotate
		{
			get
			{
				return sSLAutoRotate;
			}
			set	
			{
				sSLAutoRotate = value;
			}
		}

		public List<DescribeDBClusterSSL_Item> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeDBClusterSSL_Item
		{

			private string sSLExpireTime;

			private string sSLEnabled;

			private string sSLConnectionString;

			private string dBEndpointId;

			public string SSLExpireTime
			{
				get
				{
					return sSLExpireTime;
				}
				set	
				{
					sSLExpireTime = value;
				}
			}

			public string SSLEnabled
			{
				get
				{
					return sSLEnabled;
				}
				set	
				{
					sSLEnabled = value;
				}
			}

			public string SSLConnectionString
			{
				get
				{
					return sSLConnectionString;
				}
				set	
				{
					sSLConnectionString = value;
				}
			}

			public string DBEndpointId
			{
				get
				{
					return dBEndpointId;
				}
				set	
				{
					dBEndpointId = value;
				}
			}
		}
	}
}
