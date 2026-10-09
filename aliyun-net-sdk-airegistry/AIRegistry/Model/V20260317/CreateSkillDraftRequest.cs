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
using Aliyun.Acs.AIRegistry.Transform;
using Aliyun.Acs.AIRegistry.Transform.V20260317;

namespace Aliyun.Acs.AIRegistry.Model.V20260317
{
    public class CreateSkillDraftRequest : RpcAcsRequest<CreateSkillDraftResponse>
    {
        public CreateSkillDraftRequest()
            : base("AIRegistry", "2026-03-17", "CreateSkillDraft", "AIRegistry", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string namespaceId;

		private string targetVersion;

		private string skillCard;

		private string basedOnVersion;

		private string skillName;

		private string commitMsg;

		public string NamespaceId
		{
			get
			{
				return namespaceId;
			}
			set	
			{
				namespaceId = value;
				DictionaryUtil.Add(QueryParameters, "NamespaceId", value);
			}
		}

		public string TargetVersion
		{
			get
			{
				return targetVersion;
			}
			set	
			{
				targetVersion = value;
				DictionaryUtil.Add(QueryParameters, "TargetVersion", value);
			}
		}

		public string SkillCard
		{
			get
			{
				return skillCard;
			}
			set	
			{
				skillCard = value;
				DictionaryUtil.Add(QueryParameters, "SkillCard", value);
			}
		}

		public string BasedOnVersion
		{
			get
			{
				return basedOnVersion;
			}
			set	
			{
				basedOnVersion = value;
				DictionaryUtil.Add(QueryParameters, "BasedOnVersion", value);
			}
		}

		public string SkillName
		{
			get
			{
				return skillName;
			}
			set	
			{
				skillName = value;
				DictionaryUtil.Add(QueryParameters, "SkillName", value);
			}
		}

		public string CommitMsg
		{
			get
			{
				return commitMsg;
			}
			set	
			{
				commitMsg = value;
				DictionaryUtil.Add(QueryParameters, "CommitMsg", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateSkillDraftResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSkillDraftResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
