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
using Aliyun.Acs.Ess.Transform;
using Aliyun.Acs.Ess.Transform.V20140828;
using System.Collections.Generic;

namespace Aliyun.Acs.Ess.Model.V20140828
{
    public class ModifyAlertConfigRequest : RpcAcsRequest<ModifyAlertConfigResponse>
    {
        public ModifyAlertConfigRequest()
            : base("Ess", "2014-08-28", "ModifyAlertConfig", "ess", "openAPI")
        {
        }

		private int? successConfig;

		private int? rejectConfig;

		private string resourceOwnerAccount;

		private string scalingGroupId;

		private string action;

		private long? ownerId;

		private int? failConfig;

		private string accessKeyId;

		public int? SuccessConfig
		{
			get
			{
				return successConfig;
			}
			set	
			{
				successConfig = value;
				DictionaryUtil.Add(QueryParameters, "SuccessConfig", value.ToString());
			}
		}

		public int? RejectConfig
		{
			get
			{
				return rejectConfig;
			}
			set	
			{
				rejectConfig = value;
				DictionaryUtil.Add(QueryParameters, "RejectConfig", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string ScalingGroupId
		{
			get
			{
				return scalingGroupId;
			}
			set	
			{
				scalingGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupId", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public int? FailConfig
		{
			get
			{
				return failConfig;
			}
			set	
			{
				failConfig = value;
				DictionaryUtil.Add(QueryParameters, "FailConfig", value.ToString());
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

        public override ModifyAlertConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyAlertConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}