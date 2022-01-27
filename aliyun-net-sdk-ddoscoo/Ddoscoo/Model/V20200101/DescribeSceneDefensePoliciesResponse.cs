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

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
	public class DescribeSceneDefensePoliciesResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private List<DescribeSceneDefensePolicies_Policy> policies;

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

		public List<DescribeSceneDefensePolicies_Policy> Policies
		{
			get
			{
				return policies;
			}
			set	
			{
				policies = value;
			}
		}

		public class DescribeSceneDefensePolicies_Policy
		{

			private string policyId;

			private string name;

			private string template;

			private long? startTime;

			private long? endTime;

			private int? status;

			private int? done;

			private int? objectCount;

			private List<DescribeSceneDefensePolicies_Policy1> runtimePolicies;

			public string PolicyId
			{
				get
				{
					return policyId;
				}
				set	
				{
					policyId = value;
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

			public string Template
			{
				get
				{
					return template;
				}
				set	
				{
					template = value;
				}
			}

			public long? StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public long? EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public int? Status
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

			public int? Done
			{
				get
				{
					return done;
				}
				set	
				{
					done = value;
				}
			}

			public int? ObjectCount
			{
				get
				{
					return objectCount;
				}
				set	
				{
					objectCount = value;
				}
			}

			public List<DescribeSceneDefensePolicies_Policy1> RuntimePolicies
			{
				get
				{
					return runtimePolicies;
				}
				set	
				{
					runtimePolicies = value;
				}
			}

			public class DescribeSceneDefensePolicies_Policy1
			{

				private int? policyType;

				private int? status;

				private string oldValue;

				private string newValue;

				public int? PolicyType
				{
					get
					{
						return policyType;
					}
					set	
					{
						policyType = value;
					}
				}

				public int? Status
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

				public string OldValue
				{
					get
					{
						return oldValue;
					}
					set	
					{
						oldValue = value;
					}
				}

				public string NewValue
				{
					get
					{
						return newValue;
					}
					set	
					{
						newValue = value;
					}
				}
			}
		}
	}
}
