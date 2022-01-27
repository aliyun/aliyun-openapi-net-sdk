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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class ControlHtmlResourceRequest : RpcAcsRequest<ControlHtmlResourceResponse>
    {
        public ControlHtmlResourceRequest()
            : base("live", "2016-11-01", "ControlHtmlResource", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string htmlUrl;

		private string casterId;

		private long? ownerId;

		private string operate;

		private string htmlResourceId;

		public string HtmlUrl
		{
			get
			{
				return htmlUrl;
			}
			set	
			{
				htmlUrl = value;
				DictionaryUtil.Add(QueryParameters, "htmlUrl", value);
			}
		}

		public string CasterId
		{
			get
			{
				return casterId;
			}
			set	
			{
				casterId = value;
				DictionaryUtil.Add(QueryParameters, "CasterId", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string Operate
		{
			get
			{
				return operate;
			}
			set	
			{
				operate = value;
				DictionaryUtil.Add(QueryParameters, "Operate", value);
			}
		}

		public string HtmlResourceId
		{
			get
			{
				return htmlResourceId;
			}
			set	
			{
				htmlResourceId = value;
				DictionaryUtil.Add(QueryParameters, "HtmlResourceId", value);
			}
		}

        public override ControlHtmlResourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ControlHtmlResourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
