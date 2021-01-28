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
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class ListSlbAPsRequest : RpcAcsRequest<ListSlbAPsResponse>
    {
        public ListSlbAPsRequest()
            : base("retailcloud", "2018-03-13", "ListSlbAPs", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> protocolLists = new List<string>(){ };

		private string slbId;

		private long? appId;

		private string name;

		private int? pageSize;

		private long? envId;

		private string networkMode;

		private int? pageNumber;

		public List<string> ProtocolLists
		{
			get
			{
				return protocolLists;
			}

			set
			{
				protocolLists = value;
				for (int i = 0; i < protocolLists.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"ProtocolList." + (i + 1) , protocolLists[i]);
				}
			}
		}

		public string SlbId
		{
			get
			{
				return slbId;
			}
			set	
			{
				slbId = value;
				DictionaryUtil.Add(QueryParameters, "SlbId", value);
			}
		}

		public long? AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
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

		public long? EnvId
		{
			get
			{
				return envId;
			}
			set	
			{
				envId = value;
				DictionaryUtil.Add(QueryParameters, "EnvId", value.ToString());
			}
		}

		public string NetworkMode
		{
			get
			{
				return networkMode;
			}
			set	
			{
				networkMode = value;
				DictionaryUtil.Add(QueryParameters, "NetworkMode", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListSlbAPsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListSlbAPsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
