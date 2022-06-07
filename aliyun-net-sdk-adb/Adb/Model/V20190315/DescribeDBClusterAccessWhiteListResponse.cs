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

namespace Aliyun.Acs.adb.Model.V20190315
{
	public class DescribeDBClusterAccessWhiteListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeDBClusterAccessWhiteList_IPArray> items;

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

		public List<DescribeDBClusterAccessWhiteList_IPArray> Items
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

		public class DescribeDBClusterAccessWhiteList_IPArray
		{

			private string dBClusterIPArrayAttribute;

			private string securityIPList;

			private string dBClusterIPArrayName;

			public string DBClusterIPArrayAttribute
			{
				get
				{
					return dBClusterIPArrayAttribute;
				}
				set	
				{
					dBClusterIPArrayAttribute = value;
				}
			}

			public string SecurityIPList
			{
				get
				{
					return securityIPList;
				}
				set	
				{
					securityIPList = value;
				}
			}

			public string DBClusterIPArrayName
			{
				get
				{
					return dBClusterIPArrayName;
				}
				set	
				{
					dBClusterIPArrayName = value;
				}
			}
		}
	}
}
