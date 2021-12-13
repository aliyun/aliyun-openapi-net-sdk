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

namespace Aliyun.Acs.gpdb.Model.V20160503
{
	public class DescribeModifyParameterLogResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeModifyParameterLog_ChangelogsItem> changelogs;

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

		public List<DescribeModifyParameterLog_ChangelogsItem> Changelogs
		{
			get
			{
				return changelogs;
			}
			set	
			{
				changelogs = value;
			}
		}

		public class DescribeModifyParameterLog_ChangelogsItem
		{

			private string parameterValueAfter;

			private string parameterName;

			private string effectTime;

			private string parameterValueBefore;

			private string parameterValid;

			public string ParameterValueAfter
			{
				get
				{
					return parameterValueAfter;
				}
				set	
				{
					parameterValueAfter = value;
				}
			}

			public string ParameterName
			{
				get
				{
					return parameterName;
				}
				set	
				{
					parameterName = value;
				}
			}

			public string EffectTime
			{
				get
				{
					return effectTime;
				}
				set	
				{
					effectTime = value;
				}
			}

			public string ParameterValueBefore
			{
				get
				{
					return parameterValueBefore;
				}
				set	
				{
					parameterValueBefore = value;
				}
			}

			public string ParameterValid
			{
				get
				{
					return parameterValid;
				}
				set	
				{
					parameterValid = value;
				}
			}
		}
	}
}
