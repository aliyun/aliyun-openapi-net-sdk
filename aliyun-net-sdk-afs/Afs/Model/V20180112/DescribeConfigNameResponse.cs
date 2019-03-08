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

namespace Aliyun.Acs.afs.Model.V20180112
{
	public class DescribeConfigNameResponse : AcsResponse
	{

		private string requestId;

		private bool? hasConfig;

		private string bizCode;

		private List<DescribeConfigName_ConfigName> configNames;

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

		public bool? HasConfig
		{
			get
			{
				return hasConfig;
			}
			set	
			{
				hasConfig = value;
			}
		}

		public string BizCode
		{
			get
			{
				return bizCode;
			}
			set	
			{
				bizCode = value;
			}
		}

		public List<DescribeConfigName_ConfigName> ConfigNames
		{
			get
			{
				return configNames;
			}
			set	
			{
				configNames = value;
			}
		}

		public class DescribeConfigName_ConfigName
		{

			private string aliUid;

			private string configName;

			private string refExtId;

			public string AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public string ConfigName
			{
				get
				{
					return configName;
				}
				set	
				{
					configName = value;
				}
			}

			public string RefExtId
			{
				get
				{
					return refExtId;
				}
				set	
				{
					refExtId = value;
				}
			}
		}
	}
}