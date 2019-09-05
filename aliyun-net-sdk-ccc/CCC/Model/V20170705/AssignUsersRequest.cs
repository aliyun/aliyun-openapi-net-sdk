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
    public class AssignUsersRequest : RpcAcsRequest<AssignUsersResponse>
    {
        public AssignUsersRequest()
            : base("CCC", "2017-07-05", "AssignUsers")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private List<string> roleIds = new List<string>(){ };

		private List<string> userRamIds = new List<string>(){ };

		private List<int?> skillLevels = new List<int?>(){ };

		private string instanceId;

		private List<string> skillGroupIds = new List<string>(){ };

		public List<string> RoleIds
		{
			get
			{
				return roleIds;
			}

			set
			{
				roleIds = value;
				for (int i = 0; i < roleIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RoleId." + (i + 1) , roleIds[i]);
				}
			}
		}

		public List<string> UserRamIds
		{
			get
			{
				return userRamIds;
			}

			set
			{
				userRamIds = value;
				for (int i = 0; i < userRamIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"UserRamId." + (i + 1) , userRamIds[i]);
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

		public List<string> SkillGroupIds
		{
			get
			{
				return skillGroupIds;
			}

			set
			{
				skillGroupIds = value;
				for (int i = 0; i < skillGroupIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SkillGroupId." + (i + 1) , skillGroupIds[i]);
				}
			}
		}

        public override AssignUsersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AssignUsersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
