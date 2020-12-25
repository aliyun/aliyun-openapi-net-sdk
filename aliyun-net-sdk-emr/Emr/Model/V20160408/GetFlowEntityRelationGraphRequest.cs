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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class GetFlowEntityRelationGraphRequest : RpcAcsRequest<GetFlowEntityRelationGraphResponse>
    {
        public GetFlowEntityRelationGraphRequest()
            : base("Emr", "2016-04-08", "GetFlowEntityRelationGraph", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? pageCount;

		private string orderMode;

		private string entityId;

		private int? pageNumber;

		private int? limit;

		private int? pageSize;

		private string relationship;

		private int? currentSize;

		private string orderField;

		private string direction;

		private string entityGroupId;

		private string entityType;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public int? PageCount
		{
			get
			{
				return pageCount;
			}
			set	
			{
				pageCount = value;
				DictionaryUtil.Add(QueryParameters, "PageCount", value.ToString());
			}
		}

		public string OrderMode
		{
			get
			{
				return orderMode;
			}
			set	
			{
				orderMode = value;
				DictionaryUtil.Add(QueryParameters, "OrderMode", value);
			}
		}

		public string EntityId
		{
			get
			{
				return entityId;
			}
			set	
			{
				entityId = value;
				DictionaryUtil.Add(QueryParameters, "EntityId", value);
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
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public int? Limit
		{
			get
			{
				return limit;
			}
			set	
			{
				limit = value;
				DictionaryUtil.Add(QueryParameters, "Limit", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string Relationship
		{
			get
			{
				return relationship;
			}
			set	
			{
				relationship = value;
				DictionaryUtil.Add(QueryParameters, "Relationship", value);
			}
		}

		public int? CurrentSize
		{
			get
			{
				return currentSize;
			}
			set	
			{
				currentSize = value;
				DictionaryUtil.Add(QueryParameters, "CurrentSize", value.ToString());
			}
		}

		public string OrderField
		{
			get
			{
				return orderField;
			}
			set	
			{
				orderField = value;
				DictionaryUtil.Add(QueryParameters, "OrderField", value);
			}
		}

		public string Direction
		{
			get
			{
				return direction;
			}
			set	
			{
				direction = value;
				DictionaryUtil.Add(QueryParameters, "Direction", value);
			}
		}

		public string EntityGroupId
		{
			get
			{
				return entityGroupId;
			}
			set	
			{
				entityGroupId = value;
				DictionaryUtil.Add(QueryParameters, "EntityGroupId", value);
			}
		}

		public string EntityType
		{
			get
			{
				return entityType;
			}
			set	
			{
				entityType = value;
				DictionaryUtil.Add(QueryParameters, "EntityType", value);
			}
		}

        public override GetFlowEntityRelationGraphResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetFlowEntityRelationGraphResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
