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

namespace Aliyun.Acs.Baas.Model.V20180731
{
	public class CreateEcosphereResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private string errorMessage;

		private CreateEcosphere_Result result;

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

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
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

		public CreateEcosphere_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class CreateEcosphere_Result
		{

			private string consortiumId;

			private string name;

			private string regionId;

			private string zoneId;

			private string code;

			private string domain;

			private string description;

			private string ownerBid;

			private long? ownerUid;

			private string ordererType;

			private string channelPolicy;

			private int? ordererCount;

			private int? memberCount;

			private int? channelCount;

			private string specName;

			private string clusterState;

			private string serviceState;

			private string createTime;

			private List<CreateEcosphere_Organization> organizations;

			private CreateEcosphere_Specification specification;

			public string ConsortiumId
			{
				get
				{
					return consortiumId;
				}
				set	
				{
					consortiumId = value;
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

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}

			public string Code
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

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
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

			public string OwnerBid
			{
				get
				{
					return ownerBid;
				}
				set	
				{
					ownerBid = value;
				}
			}

			public long? OwnerUid
			{
				get
				{
					return ownerUid;
				}
				set	
				{
					ownerUid = value;
				}
			}

			public string OrdererType
			{
				get
				{
					return ordererType;
				}
				set	
				{
					ordererType = value;
				}
			}

			public string ChannelPolicy
			{
				get
				{
					return channelPolicy;
				}
				set	
				{
					channelPolicy = value;
				}
			}

			public int? OrdererCount
			{
				get
				{
					return ordererCount;
				}
				set	
				{
					ordererCount = value;
				}
			}

			public int? MemberCount
			{
				get
				{
					return memberCount;
				}
				set	
				{
					memberCount = value;
				}
			}

			public int? ChannelCount
			{
				get
				{
					return channelCount;
				}
				set	
				{
					channelCount = value;
				}
			}

			public string SpecName
			{
				get
				{
					return specName;
				}
				set	
				{
					specName = value;
				}
			}

			public string ClusterState
			{
				get
				{
					return clusterState;
				}
				set	
				{
					clusterState = value;
				}
			}

			public string ServiceState
			{
				get
				{
					return serviceState;
				}
				set	
				{
					serviceState = value;
				}
			}

			public string CreateTime
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

			public List<CreateEcosphere_Organization> Organizations
			{
				get
				{
					return organizations;
				}
				set	
				{
					organizations = value;
				}
			}

			public CreateEcosphere_Specification Specification
			{
				get
				{
					return specification;
				}
				set	
				{
					specification = value;
				}
			}

			public class CreateEcosphere_Organization
			{

				private string name;

				private string code;

				private string domain;

				private string description;

				private string clusterState;

				private string serviceState;

				private string createTime;

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

				public string Code
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

				public string Domain
				{
					get
					{
						return domain;
					}
					set	
					{
						domain = value;
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

				public string ClusterState
				{
					get
					{
						return clusterState;
					}
					set	
					{
						clusterState = value;
					}
				}

				public string ServiceState
				{
					get
					{
						return serviceState;
					}
					set	
					{
						serviceState = value;
					}
				}

				public string CreateTime
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
			}

			public class CreateEcosphere_Specification
			{

				private string name;

				private string title;

				private int? numOfNodes;

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

				public string Title
				{
					get
					{
						return title;
					}
					set	
					{
						title = value;
					}
				}

				public int? NumOfNodes
				{
					get
					{
						return numOfNodes;
					}
					set	
					{
						numOfNodes = value;
					}
				}
			}
		}
	}
}