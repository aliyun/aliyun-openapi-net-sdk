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

namespace Aliyun.Acs.waf_openapi.Model.V20180117
{
	public class DescribeProtectionModuleRulesResponse : AcsResponse
	{

		private string requestId;

		private int? taskStatus;

		private int? total;

		private List<DescribeProtectionModuleRules_ModuleRulesItem> moduleRules;

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

		public int? TaskStatus
		{
			get
			{
				return taskStatus;
			}
			set	
			{
				taskStatus = value;
			}
		}

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<DescribeProtectionModuleRules_ModuleRulesItem> ModuleRules
		{
			get
			{
				return moduleRules;
			}
			set	
			{
				moduleRules = value;
			}
		}

		public class DescribeProtectionModuleRules_ModuleRulesItem
		{

			private long? id;

			private long? version;

			private string content;

			private long? time;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public long? Version
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

			public string Content
			{
				get
				{
					return content;
				}
				set	
				{
					content = value;
				}
			}

			public long? Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}
		}
	}
}
