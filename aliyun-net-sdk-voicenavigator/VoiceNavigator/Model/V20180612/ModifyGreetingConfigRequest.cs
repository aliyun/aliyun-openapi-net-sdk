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
using Aliyun.Acs.VoiceNavigator.Transform;
using Aliyun.Acs.VoiceNavigator.Transform.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
    public class ModifyGreetingConfigRequest : RpcAcsRequest<ModifyGreetingConfigResponse>
    {
        public ModifyGreetingConfigRequest()
            : base("VoiceNavigator", "2018-06-12", "ModifyGreetingConfig", "voicebot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string greetingWords;

		private string intentTrigger;

		private string instanceId;

		private string sourceType;

		public string GreetingWords
		{
			get
			{
				return greetingWords;
			}
			set	
			{
				greetingWords = value;
				DictionaryUtil.Add(QueryParameters, "GreetingWords", value);
			}
		}

		public string IntentTrigger
		{
			get
			{
				return intentTrigger;
			}
			set	
			{
				intentTrigger = value;
				DictionaryUtil.Add(QueryParameters, "IntentTrigger", value);
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

		public string SourceType
		{
			get
			{
				return sourceType;
			}
			set	
			{
				sourceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyGreetingConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyGreetingConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
