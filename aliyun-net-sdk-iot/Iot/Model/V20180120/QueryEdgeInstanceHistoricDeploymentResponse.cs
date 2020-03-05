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
	public class QueryEdgeInstanceHistoricDeploymentResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private QueryEdgeInstanceHistoricDeployment_Data data;

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

		public QueryEdgeInstanceHistoricDeployment_Data Data
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

		public class QueryEdgeInstanceHistoricDeployment_Data
		{

			private int? total;

			private int? pageSize;

			private int? currentPage;

			private List<QueryEdgeInstanceHistoricDeployment_Deployment> deploymentList;

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

			public List<QueryEdgeInstanceHistoricDeployment_Deployment> DeploymentList
			{
				get
				{
					return deploymentList;
				}
				set	
				{
					deploymentList = value;
				}
			}

			public class QueryEdgeInstanceHistoricDeployment_Deployment
			{

				private string gmtCreate;

				private string gmtModified;

				private string gmtCompleted;

				private string deploymentId;

				private string description;

				private int? status;

				private string type;

				private long? gmtCreateTimestamp;

				private long? gmtModifiedTimestamp;

				private long? gmtCompletedTimestamp;

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

				public string GmtCompleted
				{
					get
					{
						return gmtCompleted;
					}
					set	
					{
						gmtCompleted = value;
					}
				}

				public string DeploymentId
				{
					get
					{
						return deploymentId;
					}
					set	
					{
						deploymentId = value;
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

				public string Type
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

				public long? GmtCompletedTimestamp
				{
					get
					{
						return gmtCompletedTimestamp;
					}
					set	
					{
						gmtCompletedTimestamp = value;
					}
				}
			}
		}
	}
}
