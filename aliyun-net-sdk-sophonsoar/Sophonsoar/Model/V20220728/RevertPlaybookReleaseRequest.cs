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
using Aliyun.Acs.sophonsoar;
using Aliyun.Acs.sophonsoar.Transform;
using Aliyun.Acs.sophonsoar.Transform.V20220728;

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
    public class RevertPlaybookReleaseRequest : RpcAcsRequest<RevertPlaybookReleaseResponse>
    {
        public RevertPlaybookReleaseRequest()
            : base("sophonsoar", "2022-07-28", "RevertPlaybookRelease")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string playbookUuid;

		private int? playReleaseId;

		private bool? isPublish;

		public string PlaybookUuid
		{
			get
			{
				return playbookUuid;
			}
			set	
			{
				playbookUuid = value;
				DictionaryUtil.Add(BodyParameters, "PlaybookUuid", value);
			}
		}

		public int? PlayReleaseId
		{
			get
			{
				return playReleaseId;
			}
			set	
			{
				playReleaseId = value;
				DictionaryUtil.Add(BodyParameters, "PlayReleaseId", value.ToString());
			}
		}

		public bool? IsPublish
		{
			get
			{
				return isPublish;
			}
			set	
			{
				isPublish = value;
				DictionaryUtil.Add(BodyParameters, "IsPublish", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RevertPlaybookReleaseResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RevertPlaybookReleaseResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
