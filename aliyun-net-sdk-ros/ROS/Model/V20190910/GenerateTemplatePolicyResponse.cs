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

namespace Aliyun.Acs.ROS.Model.V20190910
{
	public class GenerateTemplatePolicyResponse : AcsResponse
	{

		private string requestId;

		private GenerateTemplatePolicy_Policy policy;

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

		public GenerateTemplatePolicy_Policy Policy
		{
			get
			{
				return policy;
			}
			set	
			{
				policy = value;
			}
		}

		public class GenerateTemplatePolicy_Policy
		{

			private string version;

			private List<GenerateTemplatePolicy_StatementItem> statement;

			public string Version
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

			public List<GenerateTemplatePolicy_StatementItem> Statement
			{
				get
				{
					return statement;
				}
				set	
				{
					statement = value;
				}
			}

			public class GenerateTemplatePolicy_StatementItem
			{

				private string resource;

				private string effect;

				private List<string> action;

				public string Resource
				{
					get
					{
						return resource;
					}
					set	
					{
						resource = value;
					}
				}

				public string Effect
				{
					get
					{
						return effect;
					}
					set	
					{
						effect = value;
					}
				}

				public List<string> Action
				{
					get
					{
						return action;
					}
					set	
					{
						action = value;
					}
				}
			}
		}
	}
}
