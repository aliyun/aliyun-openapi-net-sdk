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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class SetCasterConfigRequest : RpcAcsRequest<SetCasterConfigResponse>
    {
        public SetCasterConfigRequest()
            : base("live", "2016-11-01", "SetCasterConfig", "live", "openAPI")
        {
        }

		private string sideOutputUrl;

		private string casterId;

		private string domainName;

		private int? programEffect;

		private string programName;

		private long? ownerId;

		private string recordConfig;

		private string urgentMaterialId;

		private string transcodeConfig;

		private float? delay;

		private string casterName;

		private string action;

		private string callbackUrl;

		public string SideOutputUrl
		{
			get
			{
				return sideOutputUrl;
			}
			set	
			{
				sideOutputUrl = value;
				DictionaryUtil.Add(QueryParameters, "SideOutputUrl", value);
			}
		}

		public string CasterId
		{
			get
			{
				return casterId;
			}
			set	
			{
				casterId = value;
				DictionaryUtil.Add(QueryParameters, "CasterId", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public int? ProgramEffect
		{
			get
			{
				return programEffect;
			}
			set	
			{
				programEffect = value;
				DictionaryUtil.Add(QueryParameters, "ProgramEffect", value.ToString());
			}
		}

		public string ProgramName
		{
			get
			{
				return programName;
			}
			set	
			{
				programName = value;
				DictionaryUtil.Add(QueryParameters, "ProgramName", value);
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

		public string RecordConfig
		{
			get
			{
				return recordConfig;
			}
			set	
			{
				recordConfig = value;
				DictionaryUtil.Add(QueryParameters, "RecordConfig", value);
			}
		}

		public string UrgentMaterialId
		{
			get
			{
				return urgentMaterialId;
			}
			set	
			{
				urgentMaterialId = value;
				DictionaryUtil.Add(QueryParameters, "UrgentMaterialId", value);
			}
		}

		public string TranscodeConfig
		{
			get
			{
				return transcodeConfig;
			}
			set	
			{
				transcodeConfig = value;
				DictionaryUtil.Add(QueryParameters, "TranscodeConfig", value);
			}
		}

		public float? Delay
		{
			get
			{
				return delay;
			}
			set	
			{
				delay = value;
				DictionaryUtil.Add(QueryParameters, "Delay", value.ToString());
			}
		}

		public string CasterName
		{
			get
			{
				return casterName;
			}
			set	
			{
				casterName = value;
				DictionaryUtil.Add(QueryParameters, "CasterName", value);
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

		public string CallbackUrl
		{
			get
			{
				return callbackUrl;
			}
			set	
			{
				callbackUrl = value;
				DictionaryUtil.Add(QueryParameters, "CallbackUrl", value);
			}
		}

        public override SetCasterConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SetCasterConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}