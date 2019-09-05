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

namespace Aliyun.Acs.CloudAPI.Model.V20160714
{
	public class DescribeApiQpsDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeApiQpsData_MonitorItem> callSuccesses;

		private List<DescribeApiQpsData_MonitorItem> callFails;

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

		public List<DescribeApiQpsData_MonitorItem> CallSuccesses
		{
			get
			{
				return callSuccesses;
			}
			set	
			{
				callSuccesses = value;
			}
		}

		public List<DescribeApiQpsData_MonitorItem> CallFails
		{
			get
			{
				return callFails;
			}
			set	
			{
				callFails = value;
			}
		}

		public class DescribeApiQpsData_MonitorItem
		{

			private string itemTime;

			private string itemValue;

			public string ItemTime
			{
				get
				{
					return itemTime;
				}
				set	
				{
					itemTime = value;
				}
			}

			public string ItemValue
			{
				get
				{
					return itemValue;
				}
				set	
				{
					itemValue = value;
				}
			}
		}
	}
}
