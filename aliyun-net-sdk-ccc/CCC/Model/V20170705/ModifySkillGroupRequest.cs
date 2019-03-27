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
using Aliyun.Acs.CCC.Transform.V20170705;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class ModifySkillGroupRequest : RpcAcsRequest<ModifySkillGroupResponse>
    {
        public ModifySkillGroupRequest()
            : base("CCC", "2017-07-05", "ModifySkillGroup", "ccc", "openAPI")
        {
        }

		private List<int?> skillLevels;

		private string instanceId;

		private bool? allowPrivateOutboundNumber;

		private List<string> outboundPhoneNumberIds;

		private string skillGroupId;

		private string name;

		private string description;

		private List<string> userIds;

		private string accessKeyId;

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

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override ModifySkillGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifySkillGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
