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

namespace Aliyun.Acs.Qualitycheck.Model.V20190115
{
	public class GetTaskRuleListResponse : AcsResponse
	{

		private int? currentPage;

		private int? dataSize;

		private string requestId;

		private bool? success;

		private int? reviewStatus;

		private int? compSubTaskCount;

		private string code;

		private int? totalSubTaskCount;

		private string message;

		private int? pageSize;

		private int? totalCount;

		private List<GetTaskRuleList_RuleCountInfo> data;

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

		public int? DataSize
		{
			get
			{
				return dataSize;
			}
			set	
			{
				dataSize = value;
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

		public int? ReviewStatus
		{
			get
			{
				return reviewStatus;
			}
			set	
			{
				reviewStatus = value;
			}
		}

		public int? CompSubTaskCount
		{
			get
			{
				return compSubTaskCount;
			}
			set	
			{
				compSubTaskCount = value;
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

		public int? TotalSubTaskCount
		{
			get
			{
				return totalSubTaskCount;
			}
			set	
			{
				totalSubTaskCount = value;
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

		public List<GetTaskRuleList_RuleCountInfo> Data
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

		public class GetTaskRuleList_RuleCountInfo
		{

			private int? type;

			private int? status;

			private int? preReviewNumber;

			private int? hitNumber;

			private bool? select;

			private long? createTime;

			private string createEmpid;

			private int? realViolationNumber;

			private string lastUpdateEmpid;

			private int? isDelete;

			private float? hitRate;

			private string rid;

			private int? checkNumber;

			private string typeName;

			private long? lastUpdateTime;

			private string name;

			private float? hitRealViolationRate;

			private int? reviewNumber;

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

			public int? PreReviewNumber
			{
				get
				{
					return preReviewNumber;
				}
				set	
				{
					preReviewNumber = value;
				}
			}

			public int? HitNumber
			{
				get
				{
					return hitNumber;
				}
				set	
				{
					hitNumber = value;
				}
			}

			public bool? Select
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

			public string CreateEmpid
			{
				get
				{
					return createEmpid;
				}
				set	
				{
					createEmpid = value;
				}
			}

			public int? RealViolationNumber
			{
				get
				{
					return realViolationNumber;
				}
				set	
				{
					realViolationNumber = value;
				}
			}

			public string LastUpdateEmpid
			{
				get
				{
					return lastUpdateEmpid;
				}
				set	
				{
					lastUpdateEmpid = value;
				}
			}

			public int? IsDelete
			{
				get
				{
					return isDelete;
				}
				set	
				{
					isDelete = value;
				}
			}

			public float? HitRate
			{
				get
				{
					return hitRate;
				}
				set	
				{
					hitRate = value;
				}
			}

			public string Rid
			{
				get
				{
					return rid;
				}
				set	
				{
					rid = value;
				}
			}

			public int? CheckNumber
			{
				get
				{
					return checkNumber;
				}
				set	
				{
					checkNumber = value;
				}
			}

			public string TypeName
			{
				get
				{
					return typeName;
				}
				set	
				{
					typeName = value;
				}
			}

			public long? LastUpdateTime
			{
				get
				{
					return lastUpdateTime;
				}
				set	
				{
					lastUpdateTime = value;
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

			public float? HitRealViolationRate
			{
				get
				{
					return hitRealViolationRate;
				}
				set	
				{
					hitRealViolationRate = value;
				}
			}

			public int? ReviewNumber
			{
				get
				{
					return reviewNumber;
				}
				set	
				{
					reviewNumber = value;
				}
			}
		}
	}
}
