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
    public class AddMultiRateConfigRequest : RpcAcsRequest<AddMultiRateConfigResponse>
    {
        public AddMultiRateConfigRequest()
            : base("live", "2016-11-01", "AddMultiRateConfig", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string app;

		private string groupId;

		private string templates;

		private string domainName;

		private long? ownerId;

		private string isLazy;

		private string avFormat;

		private string isTimeAlign;

		public string App
		{
			get
			{
				return app;
			}
			set	
			{
				app = value;
				DictionaryUtil.Add(QueryParameters, "App", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string Templates
		{
			get
			{
				return templates;
			}
			set	
			{
				templates = value;
				DictionaryUtil.Add(QueryParameters, "Templates", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
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

		public string IsLazy
		{
			get
			{
				return isLazy;
			}
			set	
			{
				isLazy = value;
				DictionaryUtil.Add(QueryParameters, "IsLazy", value);
			}
		}

		public string AvFormat
		{
			get
			{
				return avFormat;
			}
			set	
			{
				avFormat = value;
				DictionaryUtil.Add(QueryParameters, "AvFormat", value);
			}
		}

		public string IsTimeAlign
		{
			get
			{
				return isTimeAlign;
			}
			set	
			{
				isTimeAlign = value;
				DictionaryUtil.Add(QueryParameters, "IsTimeAlign", value);
			}
		}

        public override AddMultiRateConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddMultiRateConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
