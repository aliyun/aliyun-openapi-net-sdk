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
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20200701;

namespace Aliyun.Acs.CCC.Model.V20200701
{
    public class PickOutboundNumbersRequest : RpcAcsRequest<PickOutboundNumbersResponse>
    {
        public PickOutboundNumbersRequest()
            : base("CCC", "2020-07-01", "PickOutboundNumbers", "CCC", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? count;

		private string instanceId;

		private string skillGroupIdList;

		private string calledNumber;

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
				DictionaryUtil.Add(QueryParameters, "Count", value.ToString());
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string SkillGroupIdList
		{
			get
			{
				return skillGroupIdList;
			}
			set	
			{
				skillGroupIdList = value;
				DictionaryUtil.Add(QueryParameters, "SkillGroupIdList", value);
			}
		}

		public string CalledNumber
		{
			get
			{
				return calledNumber;
			}
			set	
			{
				calledNumber = value;
				DictionaryUtil.Add(QueryParameters, "CalledNumber", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PickOutboundNumbersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PickOutboundNumbersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
