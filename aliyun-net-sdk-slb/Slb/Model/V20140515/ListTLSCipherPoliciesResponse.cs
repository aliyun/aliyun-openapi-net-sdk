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

namespace Aliyun.Acs.Slb.Model.V20140515
{
	public class ListTLSCipherPoliciesResponse : AcsResponse
	{

		private string requestId;

		private string nextToken;

		private bool? isTruncated;

		private int? totalCount;

		private List<ListTLSCipherPolicies_TLSCipherPolicy> tLSCipherPolicies;

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

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public bool? IsTruncated
		{
			get
			{
				return isTruncated;
			}
			set	
			{
				isTruncated = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<ListTLSCipherPolicies_TLSCipherPolicy> TLSCipherPolicies
		{
			get
			{
				return tLSCipherPolicies;
			}
			set	
			{
				tLSCipherPolicies = value;
			}
		}

		public class ListTLSCipherPolicies_TLSCipherPolicy
		{

			private long? createTime;

			private string instanceId;

			private string name;

			private string status;

			private List<ListTLSCipherPolicies_RelateListener> relateListeners;

			private List<string> tLSVersions;

			private List<string> ciphers;

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
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

			public List<ListTLSCipherPolicies_RelateListener> RelateListeners
			{
				get
				{
					return relateListeners;
				}
				set	
				{
					relateListeners = value;
				}
			}

			public List<string> TLSVersions
			{
				get
				{
					return tLSVersions;
				}
				set	
				{
					tLSVersions = value;
				}
			}

			public List<string> Ciphers
			{
				get
				{
					return ciphers;
				}
				set	
				{
					ciphers = value;
				}
			}

			public class ListTLSCipherPolicies_RelateListener
			{

				private string loadBalancerId;

				private int? port;

				private string protocol;

				public string LoadBalancerId
				{
					get
					{
						return loadBalancerId;
					}
					set	
					{
						loadBalancerId = value;
					}
				}

				public int? Port
				{
					get
					{
						return port;
					}
					set	
					{
						port = value;
					}
				}

				public string Protocol
				{
					get
					{
						return protocol;
					}
					set	
					{
						protocol = value;
					}
				}
			}
		}
	}
}
