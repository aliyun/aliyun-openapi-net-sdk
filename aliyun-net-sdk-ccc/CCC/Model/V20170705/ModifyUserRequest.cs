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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class ModifyUserRequest : RpcAcsRequest<ModifyUserResponse>
    {
        public ModifyUserRequest()
            : base("CCC", "2017-07-05", "ModifyUser", "ccc", "openAPI")
        {
        }

        private List<int?> skillLevels;

        private string instanceId;

        private string phone;

        private List<string> roleIds;

        private string displayName;

        private List<string> skillGroupIds;

        private string userId;

        private string email;

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
                    DictionaryUtil.Add(QueryParameters, "SkillLevel." + (i + 1), skillLevels[i]);
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

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
                DictionaryUtil.Add(QueryParameters, "Phone", value);
            }
        }

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
                    DictionaryUtil.Add(QueryParameters, "RoleId." + (i + 1), roleIds[i]);
                }
            }
        }

        public string DisplayName
        {
            get
            {
                return displayName;
            }
            set
            {
                displayName = value;
                DictionaryUtil.Add(QueryParameters, "DisplayName", value);
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
                    DictionaryUtil.Add(QueryParameters, "SkillGroupId." + (i + 1), skillGroupIds[i]);
                }
            }
        }

        public string UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
                DictionaryUtil.Add(QueryParameters, "UserId", value);
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                DictionaryUtil.Add(QueryParameters, "Email", value);
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

        public override ModifyUserResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}