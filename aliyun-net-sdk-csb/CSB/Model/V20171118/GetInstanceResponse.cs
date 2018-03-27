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

namespace Aliyun.Acs.CSB.Model.V20171118
{
	public class GetInstanceResponse : AcsResponse
	{

		private int? code;

		private string message;

		private string requestId;

		private GetInstance_Data data;

		public int? Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

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

		public GetInstance_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetInstance_Data
		{

			private GetInstance_Instance instance;

			public GetInstance_Instance Instance
			{
				get
				{
					return instance;
				}
				set	
				{
					instance = value;
				}
			}

			public class GetInstance_Instance
			{

				private int? apprLevel;

				private string apprUser1;

				private string apprUser2;

				private string brokerVpcId;

				private string brokerVpcName;

				private string clientVpcId;

				private string clientVpcName;

				private int? clusterMembers;

				private long? credentialGroup;

				private string csbAccountId;

				private long? csbId;

				private int? dbStatus;

				private string description;

				private string frontStatus;

				private long? gmtCreate;

				private long? gmtModified;

				private long? id;

				private int? instanceCategory;

				private int? instanceType;

				private string ipList;

				private bool? isImported;

				private bool? isPublic;

				private string name;

				private string ownerId;

				private string sentinelCtlStr;

				private long? sentinelCtrl;

				private int? sentinelGridInterval;

				private long? sentinelQps;

				private string status;

				private int? statusCode;

				private string tenantId;

				private bool? testable;

				private string userId;

				private bool? visible;

				private string vpcName;

				public int? ApprLevel
				{
					get
					{
						return apprLevel;
					}
					set	
					{
						apprLevel = value;
					}
				}

				public string ApprUser1
				{
					get
					{
						return apprUser1;
					}
					set	
					{
						apprUser1 = value;
					}
				}

				public string ApprUser2
				{
					get
					{
						return apprUser2;
					}
					set	
					{
						apprUser2 = value;
					}
				}

				public string BrokerVpcId
				{
					get
					{
						return brokerVpcId;
					}
					set	
					{
						brokerVpcId = value;
					}
				}

				public string BrokerVpcName
				{
					get
					{
						return brokerVpcName;
					}
					set	
					{
						brokerVpcName = value;
					}
				}

				public string ClientVpcId
				{
					get
					{
						return clientVpcId;
					}
					set	
					{
						clientVpcId = value;
					}
				}

				public string ClientVpcName
				{
					get
					{
						return clientVpcName;
					}
					set	
					{
						clientVpcName = value;
					}
				}

				public int? ClusterMembers
				{
					get
					{
						return clusterMembers;
					}
					set	
					{
						clusterMembers = value;
					}
				}

				public long? CredentialGroup
				{
					get
					{
						return credentialGroup;
					}
					set	
					{
						credentialGroup = value;
					}
				}

				public string CsbAccountId
				{
					get
					{
						return csbAccountId;
					}
					set	
					{
						csbAccountId = value;
					}
				}

				public long? CsbId
				{
					get
					{
						return csbId;
					}
					set	
					{
						csbId = value;
					}
				}

				public int? DbStatus
				{
					get
					{
						return dbStatus;
					}
					set	
					{
						dbStatus = value;
					}
				}

				public string Description
				{
					get
					{
						return description;
					}
					set	
					{
						description = value;
					}
				}

				public string FrontStatus
				{
					get
					{
						return frontStatus;
					}
					set	
					{
						frontStatus = value;
					}
				}

				public long? GmtCreate
				{
					get
					{
						return gmtCreate;
					}
					set	
					{
						gmtCreate = value;
					}
				}

				public long? GmtModified
				{
					get
					{
						return gmtModified;
					}
					set	
					{
						gmtModified = value;
					}
				}

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

				public int? InstanceCategory
				{
					get
					{
						return instanceCategory;
					}
					set	
					{
						instanceCategory = value;
					}
				}

				public int? InstanceType
				{
					get
					{
						return instanceType;
					}
					set	
					{
						instanceType = value;
					}
				}

				public string IpList
				{
					get
					{
						return ipList;
					}
					set	
					{
						ipList = value;
					}
				}

				public bool? IsImported
				{
					get
					{
						return isImported;
					}
					set	
					{
						isImported = value;
					}
				}

				public bool? IsPublic
				{
					get
					{
						return isPublic;
					}
					set	
					{
						isPublic = value;
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

				public string OwnerId
				{
					get
					{
						return ownerId;
					}
					set	
					{
						ownerId = value;
					}
				}

				public string SentinelCtlStr
				{
					get
					{
						return sentinelCtlStr;
					}
					set	
					{
						sentinelCtlStr = value;
					}
				}

				public long? SentinelCtrl
				{
					get
					{
						return sentinelCtrl;
					}
					set	
					{
						sentinelCtrl = value;
					}
				}

				public int? SentinelGridInterval
				{
					get
					{
						return sentinelGridInterval;
					}
					set	
					{
						sentinelGridInterval = value;
					}
				}

				public long? SentinelQps
				{
					get
					{
						return sentinelQps;
					}
					set	
					{
						sentinelQps = value;
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

				public int? StatusCode
				{
					get
					{
						return statusCode;
					}
					set	
					{
						statusCode = value;
					}
				}

				public string TenantId
				{
					get
					{
						return tenantId;
					}
					set	
					{
						tenantId = value;
					}
				}

				public bool? Testable
				{
					get
					{
						return testable;
					}
					set	
					{
						testable = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public bool? Visible
				{
					get
					{
						return visible;
					}
					set	
					{
						visible = value;
					}
				}

				public string VpcName
				{
					get
					{
						return vpcName;
					}
					set	
					{
						vpcName = value;
					}
				}
			}
		}
	}
}