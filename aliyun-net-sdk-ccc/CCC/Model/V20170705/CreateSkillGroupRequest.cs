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
    public class CreateSkillGroupRequest : RpcAcsRequest<CreateSkillGroupResponse>
    {
        public CreateSkillGroupRequest()
            : base("CCC", "2017-07-05", "CreateSkillGroup")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private bool? allowPrivateOutboundNumber;

		private string description;

		private string routingStrategy;

		private List<string> userIds = new List<string>(){ };

		private List<int?> skillLevels = new List<int?>(){ };

		private string instanceId;

		private List<string> outboundPhoneNumberIds = new List<string>(){ };

		private string name;

		public bool? AllowPrivateOutboundNumber
		{
			get
			{
				return allowPrivateOutboundNumber;
			}
			set	
			{
				allowPrivateOutboundNumber = value;
				DictionaryUtil.Add(QueryParameters, "AllowPrivateOutboundNumber", value.ToString());
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string RoutingStrategy
		{
			get
			{
				return routingStrategy;
			}
			set	
			{
				routingStrategy = value;
				DictionaryUtil.Add(QueryParameters, "RoutingStrategy", value);
			}
		}

		public List<string> UserIds
		{
			get
			{
				return userIds;
			}

			set
			{
				userIds = value;
				for (int i = 0; i < userIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UserId." + (i + 1) , userIds[i]);
				}
			}
		}

		public List<int?> SkillLevels
		{
			get
			{
				return skillLevels;
			}

			set
			{
				skillLevels = value;
				for (int i = 0; i < skillLevels.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SkillLevel." + (i + 1) , skillLevels[i]);
				}
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

        public override CreateSkillGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSkillGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
