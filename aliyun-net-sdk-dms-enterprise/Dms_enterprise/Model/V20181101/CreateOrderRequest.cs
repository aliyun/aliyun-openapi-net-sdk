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
using Aliyun.Acs.dms_enterprise;
using Aliyun.Acs.dms_enterprise.Transform;
using Aliyun.Acs.dms_enterprise.Transform.V20181101;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
    public class CreateOrderRequest : RpcAcsRequest<CreateOrderResponse>
    {
        public CreateOrderRequest()
            : base("dms-enterprise", "2018-11-01", "CreateOrder")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string pluginType;

		private string comment;

		private long? tid;

		private Dictionary<object,object> pluginParam;

		private string relatedUserList;

		public string PluginType
		{
			get
			{
				return pluginType;
			}
			set	
			{
				pluginType = value;
				DictionaryUtil.Add(QueryParameters, "PluginType", value);
			}
		}

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

		public Dictionary<object,object> PluginParam
		{
			get
			{
				return pluginParam;
			}
			set	
			{
				pluginParam = value;
				DictionaryUtil.Add(QueryParameters, "PluginParam", JsonConvert.SerializeObject(value));
			}
		}

		public string RelatedUserList
		{
			get
			{
				return relatedUserList;
			}
			set	
			{
				relatedUserList = value;
				DictionaryUtil.Add(QueryParameters, "RelatedUserList", value);
			}
		}

        public override CreateOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
