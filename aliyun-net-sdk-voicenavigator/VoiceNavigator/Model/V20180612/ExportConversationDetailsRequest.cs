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
    public class ExportConversationDetailsRequest : RpcAcsRequest<ExportConversationDetailsResponse>
    {
        public ExportConversationDetailsRequest()
            : base("VoiceNavigator", "2018-06-12", "ExportConversationDetails", "voicebot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.VoiceNavigator.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.VoiceNavigator.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? beginTimeLeftRange;

		private string callingNumber;

		private string instanceId;

		private long? beginTimeRightRange;

		private List<string> optionss = new List<string>(){ };

		public long? BeginTimeLeftRange
		{
			get
			{
				return beginTimeLeftRange;
			}
			set	
			{
				beginTimeLeftRange = value;
				DictionaryUtil.Add(QueryParameters, "BeginTimeLeftRange", value.ToString());
			}
		}

		public string CallingNumber
		{
			get
			{
				return callingNumber;
			}
			set	
			{
				callingNumber = value;
				DictionaryUtil.Add(QueryParameters, "CallingNumber", value);
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

		public long? BeginTimeRightRange
		{
			get
			{
				return beginTimeRightRange;
			}
			set	
			{
				beginTimeRightRange = value;
				DictionaryUtil.Add(QueryParameters, "BeginTimeRightRange", value.ToString());
			}
		}

		public List<string> Optionss
		{
			get
			{
				return optionss;
			}

			set
			{
				optionss = value;
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ExportConversationDetailsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ExportConversationDetailsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
