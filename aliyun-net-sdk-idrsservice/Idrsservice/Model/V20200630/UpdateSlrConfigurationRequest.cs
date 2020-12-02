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
using Aliyun.Acs.idrsservice.Transform;
using Aliyun.Acs.idrsservice.Transform.V20200630;

namespace Aliyun.Acs.idrsservice.Model.V20200630
{
    public class UpdateSlrConfigurationRequest : RpcAcsRequest<UpdateSlrConfigurationResponse>
    {
        public UpdateSlrConfigurationRequest()
            : base("idrsservice", "2020-06-30", "UpdateSlrConfiguration", "idrsservice", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.idrsservice.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.idrsservice.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string mqInstanceId;

		private string mqGroupId;

		private List<string> mqEvents = new List<string>(){ };

		private string mqEndpoint;

		private string mqTopic;

		private bool? mqSubscribe;

		public string MqInstanceId
		{
			get
			{
				return mqInstanceId;
			}
			set	
			{
				mqInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "MqInstanceId", value);
			}
		}

		public string MqGroupId
		{
			get
			{
				return mqGroupId;
			}
			set	
			{
				mqGroupId = value;
				DictionaryUtil.Add(QueryParameters, "MqGroupId", value);
			}
		}

		public List<string> MqEvents
		{
			get
			{
				return mqEvents;
			}

			set
			{
				mqEvents = value;
				for (int i = 0; i < mqEvents.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"MqEvent." + (i + 1) , mqEvents[i]);
				}
			}
		}

		public string MqEndpoint
		{
			get
			{
				return mqEndpoint;
			}
			set	
			{
				mqEndpoint = value;
				DictionaryUtil.Add(QueryParameters, "MqEndpoint", value);
			}
		}

		public string MqTopic
		{
			get
			{
				return mqTopic;
			}
			set	
			{
				mqTopic = value;
				DictionaryUtil.Add(QueryParameters, "MqTopic", value);
			}
		}

		public bool? MqSubscribe
		{
			get
			{
				return mqSubscribe;
			}
			set	
			{
				mqSubscribe = value;
				DictionaryUtil.Add(QueryParameters, "MqSubscribe", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateSlrConfigurationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateSlrConfigurationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
