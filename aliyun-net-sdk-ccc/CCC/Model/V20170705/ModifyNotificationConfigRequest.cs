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
    public class ModifyNotificationConfigRequest : RpcAcsRequest<ModifyNotificationConfigResponse>
    {
        public ModifyNotificationConfigRequest()
            : base("CCC", "2017-07-05", "ModifyNotificationConfig")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private List<Subscriptions> subscriptionss = new List<Subscriptions>(){ };

		private string accessPoint;

		private string instanceId;

		private string topic;

		private string producerId;

		public List<Subscriptions> Subscriptionss
		{
			get
			{
				return subscriptionss;
			}

			set
			{
				subscriptionss = value;
				for (int i = 0; i < subscriptionss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Subscriptions." + (i + 1) + ".DisplayName", subscriptionss[i].DisplayName);
					DictionaryUtil.Add(QueryParameters,"Subscriptions." + (i + 1) + ".Name", subscriptionss[i].Name);
					DictionaryUtil.Add(QueryParameters,"Subscriptions." + (i + 1) + ".Selected", subscriptionss[i].Selected);
				}
			}
		}

		public string AccessPoint
		{
			get
			{
				return accessPoint;
			}
			set	
			{
				accessPoint = value;
				DictionaryUtil.Add(QueryParameters, "AccessPoint", value);
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

		public string Topic
		{
			get
			{
				return topic;
			}
			set	
			{
				topic = value;
				DictionaryUtil.Add(QueryParameters, "Topic", value);
			}
		}

		public string ProducerId
		{
			get
			{
				return producerId;
			}
			set	
			{
				producerId = value;
				DictionaryUtil.Add(QueryParameters, "ProducerId", value);
			}
		}

		public class Subscriptions
		{

			private string displayName;

			private string name;

			private bool? selected;

			public string DisplayName
			{
				get
				{
					return displayName;
				}
				set	
				{
					displayName = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public bool? Selected
			{
				get
				{
					return selected;
				}
				set	
				{
					selected = value;
				}
			}
		}

        public override ModifyNotificationConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyNotificationConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
