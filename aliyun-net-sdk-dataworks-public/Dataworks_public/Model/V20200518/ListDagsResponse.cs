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

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
	public class ListDagsResponse : AcsResponse
	{

		private int? httpStatusCode;

		private string requestId;

		private string errorMessage;

		private string errorCode;

		private bool? success;

		private ListDags_Data data;

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
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

		public string ErrorCode
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

		public ListDags_Data Data
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

		public class ListDags_Data
		{

			private List<ListDags_Dag> dags;

			public List<ListDags_Dag> Dags
			{
				get
				{
					return dags;
				}
				set	
				{
					dags = value;
				}
			}

			public class ListDags_Dag
			{

				private string type;

				private string status;

				private long? finishTime;

				private long? createTime;

				private long? projectId;

				private long? dagId;

				private long? gmtdate;

				private long? startTime;

				private string createUser;

				private long? bizdate;

				private string name;

				private long? modifyTime;

				private long? opSeq;

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

				public long? FinishTime
				{
					get
					{
						return finishTime;
					}
					set	
					{
						finishTime = value;
					}
				}

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

				public long? ProjectId
				{
					get
					{
						return projectId;
					}
					set	
					{
						projectId = value;
					}
				}

				public long? DagId
				{
					get
					{
						return dagId;
					}
					set	
					{
						dagId = value;
					}
				}

				public long? Gmtdate
				{
					get
					{
						return gmtdate;
					}
					set	
					{
						gmtdate = value;
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

				public string CreateUser
				{
					get
					{
						return createUser;
					}
					set	
					{
						createUser = value;
					}
				}

				public long? Bizdate
				{
					get
					{
						return bizdate;
					}
					set	
					{
						bizdate = value;
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

				public long? ModifyTime
				{
					get
					{
						return modifyTime;
					}
					set	
					{
						modifyTime = value;
					}
				}

				public long? OpSeq
				{
					get
					{
						return opSeq;
					}
					set	
					{
						opSeq = value;
					}
				}
			}
		}
	}
}
