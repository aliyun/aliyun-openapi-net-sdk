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
    public class ModifyPhoneTagsRequest : RpcAcsRequest<ModifyPhoneTagsResponse>
    {
        public ModifyPhoneTagsRequest()
            : base("CCC", "2017-07-05", "ModifyPhoneTags")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string instanceId;

		private List<string> skillGroupIdLists = new List<string>(){ };

		private string serviceTag;

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

		public List<string> SkillGroupIdLists
		{
			get
			{
				return skillGroupIdLists;
			}

			set
			{
				skillGroupIdLists = value;
				for (int i = 0; i < skillGroupIdLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SkillGroupIdList." + (i + 1) , skillGroupIdLists[i]);
				}
			}
		}

		public string ServiceTag
		{
			get
			{
				return serviceTag;
			}
			set	
			{
				serviceTag = value;
				DictionaryUtil.Add(QueryParameters, "ServiceTag", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyPhoneTagsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyPhoneTagsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
