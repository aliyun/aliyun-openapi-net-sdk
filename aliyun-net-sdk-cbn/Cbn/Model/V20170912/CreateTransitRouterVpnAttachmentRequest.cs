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
using Aliyun.Acs.Cbn.Transform;
using Aliyun.Acs.Cbn.Transform.V20170912;

namespace Aliyun.Acs.Cbn.Model.V20170912
{
    public class CreateTransitRouterVpnAttachmentRequest : RpcAcsRequest<CreateTransitRouterVpnAttachmentResponse>
    {
        public CreateTransitRouterVpnAttachmentRequest()
            : base("Cbn", "2017-09-12", "CreateTransitRouterVpnAttachment", "cbn", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string cenId;

		private string transitRouterAttachmentName;

		private List<string> zones = new List<string>(){ };

		private List<string> tags = new List<string>(){ };

		private bool? autoPublishRouteEnabled;

		private bool? dryRun;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string transitRouterId;

		private string transitRouterAttachmentDescription;

		private long? vpnOwnerId;

		private string chargeType;

		private string vpnId;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string CenId
		{
			get
			{
				return cenId;
			}
			set	
			{
				cenId = value;
				DictionaryUtil.Add(QueryParameters, "CenId", value);
			}
		}

		public string TransitRouterAttachmentName
		{
			get
			{
				return transitRouterAttachmentName;
			}
			set	
			{
				transitRouterAttachmentName = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterAttachmentName", value);
			}
		}

		public List<string> Zones
		{
			get
			{
				return zones;
			}

			set
			{
				zones = value;
				if(zones != null)
				{
					for (int depth1 = 0; depth1 < zones.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Zone." + (depth1 + 1), zones[depth1]);
					}
				}
			}
		}

		public List<string> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				if(tags != null)
				{
					for (int depth1 = 0; depth1 < tags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
					}
				}
			}
		}

		public bool? AutoPublishRouteEnabled
		{
			get
			{
				return autoPublishRouteEnabled;
			}
			set	
			{
				autoPublishRouteEnabled = value;
				DictionaryUtil.Add(QueryParameters, "AutoPublishRouteEnabled", value.ToString());
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
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

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
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

		public string TransitRouterId
		{
			get
			{
				return transitRouterId;
			}
			set	
			{
				transitRouterId = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterId", value);
			}
		}

		public string TransitRouterAttachmentDescription
		{
			get
			{
				return transitRouterAttachmentDescription;
			}
			set	
			{
				transitRouterAttachmentDescription = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterAttachmentDescription", value);
			}
		}

		public long? VpnOwnerId
		{
			get
			{
				return vpnOwnerId;
			}
			set	
			{
				vpnOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "VpnOwnerId", value.ToString());
			}
		}

		public string ChargeType
		{
			get
			{
				return chargeType;
			}
			set	
			{
				chargeType = value;
				DictionaryUtil.Add(QueryParameters, "ChargeType", value);
			}
		}

		public string VpnId
		{
			get
			{
				return vpnId;
			}
			set	
			{
				vpnId = value;
				DictionaryUtil.Add(QueryParameters, "VpnId", value);
			}
		}

		public class Zone
		{

			private string zoneId;

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
				}
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTransitRouterVpnAttachmentResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTransitRouterVpnAttachmentResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
