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
using Aliyun.Acs.ltl;
using Aliyun.Acs.ltl.Transform;
using Aliyun.Acs.ltl.Transform.V20190510;

namespace Aliyun.Acs.ltl.Model.V20190510
{
    public class ListMPCoSPhaseGroupRequest : RpcAcsRequest<ListMPCoSPhaseGroupResponse>
    {
        public ListMPCoSPhaseGroupRequest()
            : base("ltl", "2019-05-10", "ListMPCoSPhaseGroup")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ltl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ltl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? size;

		private int? num;

		private string name;

		private string apiVersion;

		private string bizChainId;

		[JsonProperty(PropertyName = "Size")]
		public int? Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(QueryParameters, "Size", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Num")]
		public int? Num
		{
			get
			{
				return num;
			}
			set	
			{
				num = value;
				DictionaryUtil.Add(QueryParameters, "Num", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Name")]
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

		[JsonProperty(PropertyName = "ApiVersion")]
		public string ApiVersion
		{
			get
			{
				return apiVersion;
			}
			set	
			{
				apiVersion = value;
				DictionaryUtil.Add(QueryParameters, "ApiVersion", value);
			}
		}

		[JsonProperty(PropertyName = "BizChainId")]
		public string BizChainId
		{
			get
			{
				return bizChainId;
			}
			set	
			{
				bizChainId = value;
				DictionaryUtil.Add(QueryParameters, "BizChainId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListMPCoSPhaseGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListMPCoSPhaseGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
