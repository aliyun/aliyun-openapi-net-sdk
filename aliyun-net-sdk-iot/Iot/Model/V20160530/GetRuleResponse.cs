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

namespace Aliyun.Acs.Iot.Model.V20160530
{
	public class GetRuleResponse : AcsResponse
	{

		private bool? success;

		private string errorMessage;

		private RuleInfo_ ruleInfo;

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public RuleInfo_ RuleInfo
		{
			get
			{
				return ruleInfo;
			}
			set	
			{
				ruleInfo = value;
			}
		}

		public class RuleInfo_{

			private long? id;

			private string select;

			private string topic;

			private string shortTopic;

			private string where;

			private string status;

			private long? createUserId;

			private long? productKey;

			private string name;

			private string ruleDesc;

			private string created;

			private string modified;

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

			public string Select
			{
				get
				{
					return select;
				}
				set	
				{
					select = value;
				}
			}

			public string Topic
			{
				get
				{
					return topic;
				}
				set	
				{
					topic = value;
				}
			}

			public string ShortTopic
			{
				get
				{
					return shortTopic;
				}
				set	
				{
					shortTopic = value;
				}
			}

			public string Where
			{
				get
				{
					return where;
				}
				set	
				{
					where = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public long? CreateUserId
			{
				get
				{
					return createUserId;
				}
				set	
				{
					createUserId = value;
				}
			}

			public long? ProductKey
			{
				get
				{
					return productKey;
				}
				set	
				{
					productKey = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string RuleDesc
			{
				get
				{
					return ruleDesc;
				}
				set	
				{
					ruleDesc = value;
				}
			}

			public string Created
			{
				get
				{
					return created;
				}
				set	
				{
					created = value;
				}
			}

			public string Modified
			{
				get
				{
					return modified;
				}
				set	
				{
					modified = value;
				}
			}
		}
	}
}