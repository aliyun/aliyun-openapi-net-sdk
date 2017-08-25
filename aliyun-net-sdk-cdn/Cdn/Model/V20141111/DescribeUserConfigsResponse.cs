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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
	public class DescribeUserConfigsResponse : AcsResponse
	{

		private string requestId;

		private DescribeUserConfigs_Configs configs;

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

		public DescribeUserConfigs_Configs Configs
		{
			get
			{
				return configs;
			}
			set	
			{
				configs = value;
			}
		}

		public class DescribeUserConfigs_Configs
		{

			private DescribeUserConfigs_OssLogConfig ossLogConfig;

			public DescribeUserConfigs_OssLogConfig OssLogConfig
			{
				get
				{
					return ossLogConfig;
				}
				set	
				{
					ossLogConfig = value;
				}
			}

			public class DescribeUserConfigs_OssLogConfig
			{

				private string enable;

				private string bucket;

				private string prefix;

				public string Enable
				{
					get
					{
						return enable;
					}
					set	
					{
						enable = value;
					}
				}

				public string Bucket
				{
					get
					{
						return bucket;
					}
					set	
					{
						bucket = value;
					}
				}

				public string Prefix
				{
					get
					{
						return prefix;
					}
					set	
					{
						prefix = value;
					}
				}
			}
		}
	}
}