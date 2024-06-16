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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Rds.Transform;
using Aliyun.Acs.Rds.Transform.V20140815;

namespace Aliyun.Acs.Rds.Model.V20140815
{
    public class ModifyEventInfoRequest : RpcAcsRequest<ModifyEventInfoResponse>
    {
        public ModifyEventInfoRequest()
            : base("Rds", "2014-08-15", "ModifyEventInfo", "rds", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Rds.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string eventId;

		private string eventAction;

		private string securityToken;

		private string actionParams;

		[JsonProperty(PropertyName = "EventId")]
		public string EventId
		{
			get
			{
				return eventId;
			}
			set	
			{
				eventId = value;
				DictionaryUtil.Add(QueryParameters, "EventId", value);
			}
		}

		[JsonProperty(PropertyName = "EventAction")]
		public string EventAction
		{
			get
			{
				return eventAction;
			}
			set	
			{
				eventAction = value;
				DictionaryUtil.Add(QueryParameters, "EventAction", value);
			}
		}

		[JsonProperty(PropertyName = "SecurityToken")]
		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		[JsonProperty(PropertyName = "ActionParams")]
		public string ActionParams
		{
			get
			{
				return actionParams;
			}
			set	
			{
				actionParams = value;
				DictionaryUtil.Add(QueryParameters, "ActionParams", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyEventInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyEventInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
