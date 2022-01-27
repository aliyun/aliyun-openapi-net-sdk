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
    public class CreateDataCorrectOrderRequest : RpcAcsRequest<CreateDataCorrectOrderResponse>
    {
        public CreateDataCorrectOrderRequest()
            : base("dms-enterprise", "2018-11-01", "CreateDataCorrectOrder", "dms-enterprise", "openAPI")
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

			private string sqlType;

			private string classify;

			private string rollbackSQL;

			private string rollbackSqlType;

			private List<DbItemListItem> dbItemList = new List<DbItemListItem>(){ };

			private string execSQL;

			private long? estimateAffectRows;

			private string rollbackAttachmentName;

			private string attachmentName;

			[JsonProperty(PropertyName = "SqlType")]
			public string SqlType
			{
				get
				{
					return sqlType;
				}
				set	
				{
					sqlType = value;
				}
			}

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

			[JsonProperty(PropertyName = "RollbackSQL")]
			public string RollbackSQL
			{
				get
				{
					return rollbackSQL;
				}
				set	
				{
					rollbackSQL = value;
				}
			}

			[JsonProperty(PropertyName = "RollbackSqlType")]
			public string RollbackSqlType
			{
				get
				{
					return rollbackSqlType;
				}
				set	
				{
					rollbackSqlType = value;
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

			[JsonProperty(PropertyName = "ExecSQL")]
			public string ExecSQL
			{
				get
				{
					return execSQL;
				}
				set	
				{
					execSQL = value;
				}
			}

			[JsonProperty(PropertyName = "EstimateAffectRows")]
			public long? EstimateAffectRows
			{
				get
				{
					return estimateAffectRows;
				}
				set	
				{
					estimateAffectRows = value;
				}
			}

			[JsonProperty(PropertyName = "RollbackAttachmentName")]
			public string RollbackAttachmentName
			{
				get
				{
					return rollbackAttachmentName;
				}
				set	
				{
					rollbackAttachmentName = value;
				}
			}

			[JsonProperty(PropertyName = "AttachmentName")]
			public string AttachmentName
			{
				get
				{
					return attachmentName;
				}
				set	
				{
					attachmentName = value;
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
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDataCorrectOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDataCorrectOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
