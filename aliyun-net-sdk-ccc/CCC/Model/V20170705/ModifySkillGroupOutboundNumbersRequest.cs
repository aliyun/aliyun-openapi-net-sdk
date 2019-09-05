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
using Aliyun.Acs.CCC;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class ModifySkillGroupOutboundNumbersRequest : RpcAcsRequest<ModifySkillGroupOutboundNumbersResponse>
    {
        public ModifySkillGroupOutboundNumbersRequest()
            : base("CCC", "2017-07-05", "ModifySkillGroupOutboundNumbers")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private int? operationType;

		private string instanceId;

		private List<string> outboundPhoneNumberIds = new List<string>(){ };

		private string skillGroupId;

		public int? OperationType
		{
			get
			{
				return operationType;
			}
			set	
			{
				operationType = value;
				DictionaryUtil.Add(QueryParameters, "OperationType", value.ToString());
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

		public List<string> OutboundPhoneNumberIds
		{
			get
			{
				return outboundPhoneNumberIds;
			}

			set
			{
				outboundPhoneNumberIds = value;
				for (int i = 0; i < outboundPhoneNumberIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OutboundPhoneNumberId." + (i + 1) , outboundPhoneNumberIds[i]);
				}
			}
		}

		public string SkillGroupId
		{
			get
			{
				return skillGroupId;
			}
			set	
			{
				skillGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SkillGroupId", value);
			}
		}

        public override ModifySkillGroupOutboundNumbersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifySkillGroupOutboundNumbersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
