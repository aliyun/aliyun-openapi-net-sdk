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

namespace Aliyun.Acs.Smartag.Model.V20180313
{
	public class DescribeGrantSagVbrRulesResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeGrantSagVbrRules_GrantRule> grantRules;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
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

		public List<DescribeGrantSagVbrRules_GrantRule> GrantRules
		{
			get
			{
				return grantRules;
			}
			set	
			{
				grantRules = value;
			}
		}

		public class DescribeGrantSagVbrRules_GrantRule
		{

			private long? createTime;

			private string instanceId;

			private long? vbrUid;

			private string vbrInstanceId;

			private string vbrRegionId;

			private long? smartAGUid;

			private string smartAGId;

			private bool? bound;

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

			public long? VbrUid
			{
				get
				{
					return vbrUid;
				}
				set	
				{
					vbrUid = value;
				}
			}

			public string VbrInstanceId
			{
				get
				{
					return vbrInstanceId;
				}
				set	
				{
					vbrInstanceId = value;
				}
			}

			public string VbrRegionId
			{
				get
				{
					return vbrRegionId;
				}
				set	
				{
					vbrRegionId = value;
				}
			}

			public long? SmartAGUid
			{
				get
				{
					return smartAGUid;
				}
				set	
				{
					smartAGUid = value;
				}
			}

			public string SmartAGId
			{
				get
				{
					return smartAGId;
				}
				set	
				{
					smartAGId = value;
				}
			}

			public bool? Bound
			{
				get
				{
					return bound;
				}
				set	
				{
					bound = value;
				}
			}
		}
	}
}
