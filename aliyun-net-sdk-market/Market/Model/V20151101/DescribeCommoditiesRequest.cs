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
using Aliyun.Acs.Market.Transform;
using Aliyun.Acs.Market.Transform.V20151101;

namespace Aliyun.Acs.Market.Model.V20151101
{
    public class DescribeCommoditiesRequest : RpcAcsRequest<DescribeCommoditiesResponse>
    {
        public DescribeCommoditiesRequest()
            : base("Market", "2015-11-01", "DescribeCommodities", "yunmarket", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string commodityGmtModifiedTo;

		private string commodityGmtModifiedFrom;

		private string commodityId;

		private string commodityGmtPublishFrom;

		private string commodityStatuses;

		private int? pageNumber;

		private string commodityGmtCreatedFrom;

		private string commodityIds;

		private string commodityGmtCreatedTo;

		private int? pageSize;

		private string commodityGmtPublishTo;

		private string commodityAuditStatuses;

		private string properties;

		private string commodityCategoryIds;

		public string CommodityGmtModifiedTo
		{
			get
			{
				return commodityGmtModifiedTo;
			}
			set	
			{
				commodityGmtModifiedTo = value;
				DictionaryUtil.Add(QueryParameters, "CommodityGmtModifiedTo", value);
			}
		}

		public string CommodityGmtModifiedFrom
		{
			get
			{
				return commodityGmtModifiedFrom;
			}
			set	
			{
				commodityGmtModifiedFrom = value;
				DictionaryUtil.Add(QueryParameters, "CommodityGmtModifiedFrom", value);
			}
		}

		public string CommodityId
		{
			get
			{
				return commodityId;
			}
			set	
			{
				commodityId = value;
				DictionaryUtil.Add(QueryParameters, "CommodityId", value);
			}
		}

		public string CommodityGmtPublishFrom
		{
			get
			{
				return commodityGmtPublishFrom;
			}
			set	
			{
				commodityGmtPublishFrom = value;
				DictionaryUtil.Add(QueryParameters, "CommodityGmtPublishFrom", value);
			}
		}

		public string CommodityStatuses
		{
			get
			{
				return commodityStatuses;
			}
			set	
			{
				commodityStatuses = value;
				DictionaryUtil.Add(QueryParameters, "CommodityStatuses", value);
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

		public string CommodityGmtCreatedFrom
		{
			get
			{
				return commodityGmtCreatedFrom;
			}
			set	
			{
				commodityGmtCreatedFrom = value;
				DictionaryUtil.Add(QueryParameters, "CommodityGmtCreatedFrom", value);
			}
		}

		public string CommodityIds
		{
			get
			{
				return commodityIds;
			}
			set	
			{
				commodityIds = value;
				DictionaryUtil.Add(QueryParameters, "CommodityIds", value);
			}
		}

		public string CommodityGmtCreatedTo
		{
			get
			{
				return commodityGmtCreatedTo;
			}
			set	
			{
				commodityGmtCreatedTo = value;
				DictionaryUtil.Add(QueryParameters, "CommodityGmtCreatedTo", value);
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

		public string CommodityGmtPublishTo
		{
			get
			{
				return commodityGmtPublishTo;
			}
			set	
			{
				commodityGmtPublishTo = value;
				DictionaryUtil.Add(QueryParameters, "CommodityGmtPublishTo", value);
			}
		}

		public string CommodityAuditStatuses
		{
			get
			{
				return commodityAuditStatuses;
			}
			set	
			{
				commodityAuditStatuses = value;
				DictionaryUtil.Add(QueryParameters, "CommodityAuditStatuses", value);
			}
		}

		public string Properties
		{
			get
			{
				return properties;
			}
			set	
			{
				properties = value;
				DictionaryUtil.Add(QueryParameters, "Properties", value);
			}
		}

		public string CommodityCategoryIds
		{
			get
			{
				return commodityCategoryIds;
			}
			set	
			{
				commodityCategoryIds = value;
				DictionaryUtil.Add(QueryParameters, "CommodityCategoryIds", value);
			}
		}

        public override DescribeCommoditiesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeCommoditiesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
