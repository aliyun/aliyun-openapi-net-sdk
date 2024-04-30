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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeHistoryEventsResponse : AcsResponse
	{

		private int? pageNumber;

		private string requestId;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeHistoryEvents_ItemsItem> items;

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "TotalCount")]
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

		[JsonProperty(PropertyName = "Items")]
		public List<DescribeHistoryEvents_ItemsItem> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class DescribeHistoryEvents_ItemsItem
		{

			private string id;

			private string region;

			private string source;

			private string specversion;

			private string subject;

			private string time;

			private string type;

			private DescribeHistoryEvents_Data data;

			[JsonProperty(PropertyName = "Id")]
			public string Id
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

			[JsonProperty(PropertyName = "Region")]
			public string Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			[JsonProperty(PropertyName = "Source")]
			public string Source
			{
				get
				{
					return source;
				}
				set	
				{
					source = value;
				}
			}

			[JsonProperty(PropertyName = "Specversion")]
			public string Specversion
			{
				get
				{
					return specversion;
				}
				set	
				{
					specversion = value;
				}
			}

			[JsonProperty(PropertyName = "Subject")]
			public string Subject
			{
				get
				{
					return subject;
				}
				set	
				{
					subject = value;
				}
			}

			[JsonProperty(PropertyName = "Time")]
			public string Time
			{
				get
				{
					return time;
				}
				set	
				{
					time = value;
				}
			}

			[JsonProperty(PropertyName = "Type")]
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

			[JsonProperty(PropertyName = "Data")]
			public DescribeHistoryEvents_Data Data
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

			public class DescribeHistoryEvents_Data
			{

				private string eventType;

				private string eventId;

				private string cmsProduct;

				private string dbType;

				private string detailImpact;

				private string detailReason;

				private string endTime;

				private string eventCategory;

				private string eventCode;

				private string eventDetail;

				private string eventImpact;

				private string eventLevel;

				private string eventReason;

				private string eventStatus;

				private string gmtCreated;

				private string gmtModified;

				private string handleStatus;

				private int? hasLifeCycle;

				private string instanceId;

				private string instanceName;

				private int? isClosed;

				private string product;

				private string regionId;

				private string resourceType;

				private string sourceType;

				private string startTime;

				private string uid;

				[JsonProperty(PropertyName = "EventType")]
				public string EventType
				{
					get
					{
						return eventType;
					}
					set	
					{
						eventType = value;
					}
				}

				[JsonProperty(PropertyName = "EventId")]
				public string EventId
				{
					get
					{
						return eventId;
					}
					set	
					{
						eventId = value;
					}
				}

				[JsonProperty(PropertyName = "CmsProduct")]
				public string CmsProduct
				{
					get
					{
						return cmsProduct;
					}
					set	
					{
						cmsProduct = value;
					}
				}

				[JsonProperty(PropertyName = "DbType")]
				public string DbType
				{
					get
					{
						return dbType;
					}
					set	
					{
						dbType = value;
					}
				}

				[JsonProperty(PropertyName = "DetailImpact")]
				public string DetailImpact
				{
					get
					{
						return detailImpact;
					}
					set	
					{
						detailImpact = value;
					}
				}

				[JsonProperty(PropertyName = "DetailReason")]
				public string DetailReason
				{
					get
					{
						return detailReason;
					}
					set	
					{
						detailReason = value;
					}
				}

				[JsonProperty(PropertyName = "EndTime")]
				public string EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}

				[JsonProperty(PropertyName = "EventCategory")]
				public string EventCategory
				{
					get
					{
						return eventCategory;
					}
					set	
					{
						eventCategory = value;
					}
				}

				[JsonProperty(PropertyName = "EventCode")]
				public string EventCode
				{
					get
					{
						return eventCode;
					}
					set	
					{
						eventCode = value;
					}
				}

				[JsonProperty(PropertyName = "EventDetail")]
				public string EventDetail
				{
					get
					{
						return eventDetail;
					}
					set	
					{
						eventDetail = value;
					}
				}

				[JsonProperty(PropertyName = "EventImpact")]
				public string EventImpact
				{
					get
					{
						return eventImpact;
					}
					set	
					{
						eventImpact = value;
					}
				}

				[JsonProperty(PropertyName = "EventLevel")]
				public string EventLevel
				{
					get
					{
						return eventLevel;
					}
					set	
					{
						eventLevel = value;
					}
				}

				[JsonProperty(PropertyName = "EventReason")]
				public string EventReason
				{
					get
					{
						return eventReason;
					}
					set	
					{
						eventReason = value;
					}
				}

				[JsonProperty(PropertyName = "EventStatus")]
				public string EventStatus
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

				[JsonProperty(PropertyName = "GmtCreated")]
				public string GmtCreated
				{
					get
					{
						return gmtCreated;
					}
					set	
					{
						gmtCreated = value;
					}
				}

				[JsonProperty(PropertyName = "GmtModified")]
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

				[JsonProperty(PropertyName = "HandleStatus")]
				public string HandleStatus
				{
					get
					{
						return handleStatus;
					}
					set	
					{
						handleStatus = value;
					}
				}

				[JsonProperty(PropertyName = "HasLifeCycle")]
				public int? HasLifeCycle
				{
					get
					{
						return hasLifeCycle;
					}
					set	
					{
						hasLifeCycle = value;
					}
				}

				[JsonProperty(PropertyName = "InstanceId")]
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

				[JsonProperty(PropertyName = "InstanceName")]
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

				[JsonProperty(PropertyName = "IsClosed")]
				public int? IsClosed
				{
					get
					{
						return isClosed;
					}
					set	
					{
						isClosed = value;
					}
				}

				[JsonProperty(PropertyName = "Product")]
				public string Product
				{
					get
					{
						return product;
					}
					set	
					{
						product = value;
					}
				}

				[JsonProperty(PropertyName = "RegionId")]
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

				[JsonProperty(PropertyName = "ResourceType")]
				public string ResourceType
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

				[JsonProperty(PropertyName = "SourceType")]
				public string SourceType
				{
					get
					{
						return sourceType;
					}
					set	
					{
						sourceType = value;
					}
				}

				[JsonProperty(PropertyName = "StartTime")]
				public string StartTime
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

				[JsonProperty(PropertyName = "Uid")]
				public string Uid
				{
					get
					{
						return uid;
					}
					set	
					{
						uid = value;
					}
				}
			}
		}
	}
}
