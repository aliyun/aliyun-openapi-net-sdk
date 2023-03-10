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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeEcGrantRelationResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? count;

		private int? page;

		private int? pageSize;

		private List<DescribeEcGrantRelation_EcGrantRelationModel> ecGrantRelations;

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

		public int? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
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

		public List<DescribeEcGrantRelation_EcGrantRelationModel> EcGrantRelations
		{
			get
			{
				return ecGrantRelations;
			}
			set	
			{
				ecGrantRelations = value;
			}
		}

		public class DescribeEcGrantRelation_EcGrantRelationModel
		{

			private long? vbrOwnerUid;

			private string vbrInstanceId;

			private string instanceId;

			private long? aliUid;

			private string regionNo;

			private string status;

			private string instanceName;

			private string instanceRouterId;

			private string vbrRegionNo;

			private string gmtCreate;

			private string grantType;

			public long? VbrOwnerUid
			{
				get
				{
					return vbrOwnerUid;
				}
				set	
				{
					vbrOwnerUid = value;
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

			public string RegionNo
			{
				get
				{
					return regionNo;
				}
				set	
				{
					regionNo = value;
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

			public string InstanceRouterId
			{
				get
				{
					return instanceRouterId;
				}
				set	
				{
					instanceRouterId = value;
				}
			}

			public string VbrRegionNo
			{
				get
				{
					return vbrRegionNo;
				}
				set	
				{
					vbrRegionNo = value;
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

			public string GrantType
			{
				get
				{
					return grantType;
				}
				set	
				{
					grantType = value;
				}
			}
		}
	}
}
