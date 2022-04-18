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

namespace Aliyun.Acs.Sddp.Model.V20190103
{
	public class DescribeDataLimitSetResponse : AcsResponse
	{

		private string requestId;

		private DescribeDataLimitSet_DataLimitSet dataLimitSet;

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

		public DescribeDataLimitSet_DataLimitSet DataLimitSet
		{
			get
			{
				return dataLimitSet;
			}
			set	
			{
				dataLimitSet = value;
			}
		}

		public class DescribeDataLimitSet_DataLimitSet
		{

			private string resourceTypeCode;

			private long? resourceType;

			private int? totalCount;

			private List<DescribeDataLimitSet_DataLimit> dataLimitList;

			private List<DescribeDataLimitSet_OssBucket> ossBucketList;

			private List<DescribeDataLimitSet_Region> regionList;

			public string ResourceTypeCode
			{
				get
				{
					return resourceTypeCode;
				}
				set	
				{
					resourceTypeCode = value;
				}
			}

			public long? ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
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

			public List<DescribeDataLimitSet_DataLimit> DataLimitList
			{
				get
				{
					return dataLimitList;
				}
				set	
				{
					dataLimitList = value;
				}
			}

			public List<DescribeDataLimitSet_OssBucket> OssBucketList
			{
				get
				{
					return ossBucketList;
				}
				set	
				{
					ossBucketList = value;
				}
			}

			public List<DescribeDataLimitSet_Region> RegionList
			{
				get
				{
					return regionList;
				}
				set	
				{
					regionList = value;
				}
			}

			public class DescribeDataLimitSet_DataLimit
			{

				private bool? supportEvent;

				private string localName;

				private int? checkStatus;

				private string connector;

				private int? port;

				private string checkStatusName;

				private string regionId;

				private string parentId;

				private long? resourceType;

				private int? logStoreDay;

				private int? eventStatus;

				private long? gmtCreate;

				private string resourceTypeCode;

				private string userName;

				private long? id;

				private int? auditStatus;

				public bool? SupportEvent
				{
					get
					{
						return supportEvent;
					}
					set	
					{
						supportEvent = value;
					}
				}

				public string LocalName
				{
					get
					{
						return localName;
					}
					set	
					{
						localName = value;
					}
				}

				public int? CheckStatus
				{
					get
					{
						return checkStatus;
					}
					set	
					{
						checkStatus = value;
					}
				}

				public string Connector
				{
					get
					{
						return connector;
					}
					set	
					{
						connector = value;
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

				public string CheckStatusName
				{
					get
					{
						return checkStatusName;
					}
					set	
					{
						checkStatusName = value;
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

				public string ParentId
				{
					get
					{
						return parentId;
					}
					set	
					{
						parentId = value;
					}
				}

				public long? ResourceType
				{
					get
					{
						return resourceType;
					}
					set	
					{
						resourceType = value;
					}
				}

				public int? LogStoreDay
				{
					get
					{
						return logStoreDay;
					}
					set	
					{
						logStoreDay = value;
					}
				}

				public int? EventStatus
				{
					get
					{
						return eventStatus;
					}
					set	
					{
						eventStatus = value;
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

				public string ResourceTypeCode
				{
					get
					{
						return resourceTypeCode;
					}
					set	
					{
						resourceTypeCode = value;
					}
				}

				public string UserName
				{
					get
					{
						return userName;
					}
					set	
					{
						userName = value;
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

				public int? AuditStatus
				{
					get
					{
						return auditStatus;
					}
					set	
					{
						auditStatus = value;
					}
				}
			}

			public class DescribeDataLimitSet_OssBucket
			{

				private string regionId;

				private string bucketName;

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

				public string BucketName
				{
					get
					{
						return bucketName;
					}
					set	
					{
						bucketName = value;
					}
				}
			}

			public class DescribeDataLimitSet_Region
			{

				private string regionId;

				private string localName;

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

				public string LocalName
				{
					get
					{
						return localName;
					}
					set	
					{
						localName = value;
					}
				}
			}
		}
	}
}
