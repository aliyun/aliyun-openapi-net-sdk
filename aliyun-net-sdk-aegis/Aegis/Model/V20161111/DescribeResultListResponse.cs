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

namespace Aliyun.Acs.aegis.Model.V20161111
{
	public class DescribeResultListResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeResultList_ResultListItem> resultList;

		private DescribeResultList_PageInfo pageInfo;

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

		public List<DescribeResultList_ResultListItem> ResultList
		{
			get
			{
				return resultList;
			}
			set	
			{
				resultList = value;
			}
		}

		public DescribeResultList_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeResultList_ResultListItem
		{

			private long? lastTimestamp;

			private long? modifiedTimestamp;

			private string warnLevel;

			private string uniqueKey;

			private long? lastOperate;

			private long? createTimestamp;

			private string ruleDescription;

			private string ruleType;

			private string ruleName;

			private string details;

			private int? id;

			private long? aliUid;

			private int? ruleId;

			private int? status;

			private string fieldKey;

			private string internetIp;

			private string intranetIp;

			private string instanceId;

			private string instanceName;

			private string fieldKey1;

			public long? LastTimestamp
			{
				get
				{
					return lastTimestamp;
				}
				set	
				{
					lastTimestamp = value;
				}
			}

			public long? ModifiedTimestamp
			{
				get
				{
					return modifiedTimestamp;
				}
				set	
				{
					modifiedTimestamp = value;
				}
			}

			public string WarnLevel
			{
				get
				{
					return warnLevel;
				}
				set	
				{
					warnLevel = value;
				}
			}

			public string UniqueKey
			{
				get
				{
					return uniqueKey;
				}
				set	
				{
					uniqueKey = value;
				}
			}

			public long? LastOperate
			{
				get
				{
					return lastOperate;
				}
				set	
				{
					lastOperate = value;
				}
			}

			public long? CreateTimestamp
			{
				get
				{
					return createTimestamp;
				}
				set	
				{
					createTimestamp = value;
				}
			}

			public string RuleDescription
			{
				get
				{
					return ruleDescription;
				}
				set	
				{
					ruleDescription = value;
				}
			}

			public string RuleType
			{
				get
				{
					return ruleType;
				}
				set	
				{
					ruleType = value;
				}
			}

			public string RuleName
			{
				get
				{
					return ruleName;
				}
				set	
				{
					ruleName = value;
				}
			}

			public string Details
			{
				get
				{
					return details;
				}
				set	
				{
					details = value;
				}
			}

			public int? Id
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

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public int? RuleId
			{
				get
				{
					return ruleId;
				}
				set	
				{
					ruleId = value;
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

			public string FieldKey
			{
				get
				{
					return fieldKey;
				}
				set	
				{
					fieldKey = value;
				}
			}

			public string InternetIp
			{
				get
				{
					return internetIp;
				}
				set	
				{
					internetIp = value;
				}
			}

			public string IntranetIp
			{
				get
				{
					return intranetIp;
				}
				set	
				{
					intranetIp = value;
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

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string FieldKey1
			{
				get
				{
					return fieldKey1;
				}
				set	
				{
					fieldKey1 = value;
				}
			}
		}

		public class DescribeResultList_PageInfo
		{

			private int? count;

			private int? pageSize;

			private int? currentPage;

			private int? totalCount;

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
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
		}
	}
}
