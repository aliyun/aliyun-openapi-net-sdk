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
using Aliyun.Acs.foas.Transform;
using Aliyun.Acs.foas.Transform.V20181111;

namespace Aliyun.Acs.foas.Model.V20181111
{
    public class ListClusterRequest : RoaAcsRequest<ListClusterResponse>
    {
        public ListClusterRequest()
            : base("foas", "2018-11-11", "ListCluster", "foas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/api/v2/clusters";
			Method = MethodType.GET;
        }

		private string displayName;

		private int? pageSize;

		private int? pageIndex;

		private string clusterId;

		private string state;

		private string region;

		public string DisplayName
		{
			get
			{
				return displayName;
			}
			set	
			{
				displayName = value;
				DictionaryUtil.Add(QueryParameters, "displayName", value);
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
				DictionaryUtil.Add(QueryParameters, "pageSize", value.ToString());
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
				DictionaryUtil.Add(QueryParameters, "pageIndex", value.ToString());
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "clusterId", value);
			}
		}

		public string State
		{
			get
			{
				return state;
			}
			set	
			{
				state = value;
				DictionaryUtil.Add(QueryParameters, "state", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "region", value);
			}
		}

        public override ListClusterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListClusterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
