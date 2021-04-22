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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.dms_enterprise.Transform;
using Aliyun.Acs.dms_enterprise.Transform.V20181101;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
    public class CreateDataCronClearOrderRequest : RpcAcsRequest<CreateDataCronClearOrderResponse>
    {
        public CreateDataCronClearOrderRequest()
            : base("dms-enterprise", "2018-11-01", "CreateDataCronClearOrder", "dms-enterprise", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? tid;

		private string attachmentKey;

		private Param param_;

		private string comment;

		private List<long?> relatedUserList = new List<long?>(){ };

		[JsonProperty(PropertyName = "Tid")]
		public long? Tid
		{
			get
			{
				return tid;
			}
			set	
			{
				tid = value;
				DictionaryUtil.Add(QueryParameters, "Tid", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AttachmentKey")]
		public string AttachmentKey
		{
			get
			{
				return attachmentKey;
			}
			set	
			{
				attachmentKey = value;
				DictionaryUtil.Add(QueryParameters, "AttachmentKey", value);
			}
		}

		[JsonProperty(PropertyName = "Param")]
		public Param Param_
		{
			get
			{
				return param_;
			}

			set
			{
				param_ = value;
				DictionaryUtil.Add(QueryParameters, "Param", JsonConvert.SerializeObject(value));

			}
		}

		[JsonProperty(PropertyName = "Comment")]
		public string Comment
		{
			get
			{
				return comment;
			}
			set	
			{
				comment = value;
				DictionaryUtil.Add(QueryParameters, "Comment", value);
			}
		}

		[JsonProperty(PropertyName = "RelatedUserList")]
		public List<long?> RelatedUserList
		{
			get
			{
				return relatedUserList;
			}

			set
			{
				relatedUserList = value;
				if(relatedUserList != null)
				{
					for (int depth1 = 0; depth1 < relatedUserList.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"RelatedUserList." + (depth1 + 1), relatedUserList[depth1]);
					}
				}
			}
		}

		public class Param
		{

			private string classify;

			private List<DbItemListItem> dbItemList = new List<DbItemListItem>(){ };

			private List<CronClearItemListItem> cronClearItemList = new List<CronClearItemListItem>(){ };

			private long? durationHour;

			private string cronFormat;

			private bool? specifyDuration;

			[JsonProperty(PropertyName = "Classify")]
			public string Classify
			{
				get
				{
					return classify;
				}
				set	
				{
					classify = value;
				}
			}

			[JsonProperty(PropertyName = "DbItemList")]
			public List<DbItemListItem> DbItemList
			{
				get
				{
					return dbItemList;
				}
				set	
				{
					dbItemList = value;
				}
			}

			[JsonProperty(PropertyName = "CronClearItemList")]
			public List<CronClearItemListItem> CronClearItemList
			{
				get
				{
					return cronClearItemList;
				}
				set	
				{
					cronClearItemList = value;
				}
			}

			[JsonProperty(PropertyName = "DurationHour")]
			public long? DurationHour
			{
				get
				{
					return durationHour;
				}
				set	
				{
					durationHour = value;
				}
			}

			[JsonProperty(PropertyName = "CronFormat")]
			public string CronFormat
			{
				get
				{
					return cronFormat;
				}
				set	
				{
					cronFormat = value;
				}
			}

			[JsonProperty(PropertyName = "specifyDuration")]
			public bool? SpecifyDuration
			{
				get
				{
					return specifyDuration;
				}
				set	
				{
					specifyDuration = value;
				}
			}

			public class DbItemListItem
			{

				private long? dbId;

				private bool? logic;

				[JsonProperty(PropertyName = "DbId")]
				public long? DbId
				{
					get
					{
						return dbId;
					}
					set	
					{
						dbId = value;
					}
				}

				[JsonProperty(PropertyName = "Logic")]
				public bool? Logic
				{
					get
					{
						return logic;
					}
					set	
					{
						logic = value;
					}
				}
			}

			public class CronClearItemListItem
			{

				private string filterSQL;

				private long? remainDays;

				private string tableName;

				private string columnName;

				private string timeUnit;

				[JsonProperty(PropertyName = "FilterSQL")]
				public string FilterSQL
				{
					get
					{
						return filterSQL;
					}
					set	
					{
						filterSQL = value;
					}
				}

				[JsonProperty(PropertyName = "RemainDays")]
				public long? RemainDays
				{
					get
					{
						return remainDays;
					}
					set	
					{
						remainDays = value;
					}
				}

				[JsonProperty(PropertyName = "TableName")]
				public string TableName
				{
					get
					{
						return tableName;
					}
					set	
					{
						tableName = value;
					}
				}

				[JsonProperty(PropertyName = "ColumnName")]
				public string ColumnName
				{
					get
					{
						return columnName;
					}
					set	
					{
						columnName = value;
					}
				}

				[JsonProperty(PropertyName = "TimeUnit")]
				public string TimeUnit
				{
					get
					{
						return timeUnit;
					}
					set	
					{
						timeUnit = value;
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDataCronClearOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDataCronClearOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
