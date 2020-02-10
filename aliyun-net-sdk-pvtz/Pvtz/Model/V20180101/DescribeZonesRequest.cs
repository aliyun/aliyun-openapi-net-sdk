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
using Aliyun.Acs.pvtz.Transform;
using Aliyun.Acs.pvtz.Transform.V20180101;

namespace Aliyun.Acs.pvtz.Model.V20180101
{
    public class DescribeZonesRequest : RpcAcsRequest<DescribeZonesResponse>
    {
        public DescribeZonesRequest()
            : base("pvtz", "2018-01-01", "DescribeZones", "pvtz", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string queryVpcId;

		private int? pageNumber;

		private string resourceGroupId;

		private int? pageSize;

		private string lang;

		private string keyword;

		private string searchMode;

		private string queryRegionId;

		public string QueryVpcId
		{
			get
			{
				return queryVpcId;
			}
			set	
			{
				queryVpcId = value;
				DictionaryUtil.Add(QueryParameters, "QueryVpcId", value);
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

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
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

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string Keyword
		{
			get
			{
				return keyword;
			}
			set	
			{
				keyword = value;
				DictionaryUtil.Add(QueryParameters, "Keyword", value);
			}
		}

		public string SearchMode
		{
			get
			{
				return searchMode;
			}
			set	
			{
				searchMode = value;
				DictionaryUtil.Add(QueryParameters, "SearchMode", value);
			}
		}

		public string QueryRegionId
		{
			get
			{
				return queryRegionId;
			}
			set	
			{
				queryRegionId = value;
				DictionaryUtil.Add(QueryParameters, "QueryRegionId", value);
			}
		}

        public override DescribeZonesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeZonesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
