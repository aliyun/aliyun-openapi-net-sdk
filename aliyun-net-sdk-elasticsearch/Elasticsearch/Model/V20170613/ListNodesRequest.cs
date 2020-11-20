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
using Aliyun.Acs.elasticsearch.Transform;
using Aliyun.Acs.elasticsearch.Transform.V20170613;

namespace Aliyun.Acs.elasticsearch.Model.V20170613
{
    public class ListNodesRequest : RoaAcsRequest<ListNodesResponse>
    {
        public ListNodesRequest()
            : base("elasticsearch", "2017-06-13", "ListNodes", "elasticsearch", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.elasticsearch.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.elasticsearch.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/openapi/collectors/[ResId]/nodes";
			Method = MethodType.GET;
        }

		private string ecsInstanceName;

		private string ecsInstanceIds;

		private int? size;

		private int? page;

		private string resId;

		private string tags;

		public string EcsInstanceName
		{
			get
			{
				return ecsInstanceName;
			}
			set	
			{
				ecsInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "ecsInstanceName", value);
			}
		}

		public string EcsInstanceIds
		{
			get
			{
				return ecsInstanceIds;
			}
			set	
			{
				ecsInstanceIds = value;
				DictionaryUtil.Add(QueryParameters, "ecsInstanceIds", value);
			}
		}

		public int? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(QueryParameters, "size", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "page", value.ToString());
			}
		}

		public string ResId
		{
			get
			{
				return resId;
			}
			set	
			{
				resId = value;
				DictionaryUtil.Add(PathParameters, "ResId", value);
			}
		}

		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "tags", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListNodesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListNodesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
