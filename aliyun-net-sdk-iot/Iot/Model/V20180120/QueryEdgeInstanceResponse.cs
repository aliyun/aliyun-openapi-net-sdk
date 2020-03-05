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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class QueryEdgeInstanceResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryEdgeInstance_Data data;

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

		public QueryEdgeInstance_Data Data
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

		public class QueryEdgeInstance_Data
		{

			private int? total;

			private int? pageSize;

			private int? currentPage;

			private List<QueryEdgeInstance_Instance> instanceList;

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

			public int? PageSize
			{
				get
				{
					return pageSize;
				}
				set	
				{
					pageSize = value;
				}
			}

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}

			public List<QueryEdgeInstance_Instance> InstanceList
			{
				get
				{
					return instanceList;
				}
				set	
				{
					instanceList = value;
				}
			}

			public class QueryEdgeInstance_Instance
			{

				private string instanceId;

				private string name;

				private string tags;

				private int? type;

				private string gmtCreate;

				private string gmtModified;

				private string roleArn;

				private string roleName;

				private string roleAttachTime;

				private int? spec;

				private bool? bizEnable;

				private int? latestDeploymentStatus;

				private string latestDeploymentType;

				private long? gmtCreateTimestamp;

				private long? gmtModifiedTimestamp;

				private long? roleAttachTimestamp;

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

				public string Tags
				{
					get
					{
						return tags;
					}
					set	
					{
						tags = value;
					}
				}

				public int? Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string GmtCreate
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

				public string GmtModified
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

				public string RoleArn
				{
					get
					{
						return roleArn;
					}
					set	
					{
						roleArn = value;
					}
				}

				public string RoleName
				{
					get
					{
						return roleName;
					}
					set	
					{
						roleName = value;
					}
				}

				public string RoleAttachTime
				{
					get
					{
						return roleAttachTime;
					}
					set	
					{
						roleAttachTime = value;
					}
				}

				public int? Spec
				{
					get
					{
						return spec;
					}
					set	
					{
						spec = value;
					}
				}

				public bool? BizEnable
				{
					get
					{
						return bizEnable;
					}
					set	
					{
						bizEnable = value;
					}
				}

				public int? LatestDeploymentStatus
				{
					get
					{
						return latestDeploymentStatus;
					}
					set	
					{
						latestDeploymentStatus = value;
					}
				}

				public string LatestDeploymentType
				{
					get
					{
						return latestDeploymentType;
					}
					set	
					{
						latestDeploymentType = value;
					}
				}

				public long? GmtCreateTimestamp
				{
					get
					{
						return gmtCreateTimestamp;
					}
					set	
					{
						gmtCreateTimestamp = value;
					}
				}

				public long? GmtModifiedTimestamp
				{
					get
					{
						return gmtModifiedTimestamp;
					}
					set	
					{
						gmtModifiedTimestamp = value;
					}
				}

				public long? RoleAttachTimestamp
				{
					get
					{
						return roleAttachTimestamp;
					}
					set	
					{
						roleAttachTimestamp = value;
					}
				}
			}
		}
	}
}
