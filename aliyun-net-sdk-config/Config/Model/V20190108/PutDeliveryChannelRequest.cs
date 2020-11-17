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
using Aliyun.Acs.Config.Transform;
using Aliyun.Acs.Config.Transform.V20190108;

namespace Aliyun.Acs.Config.Model.V20190108
{
    public class PutDeliveryChannelRequest : RpcAcsRequest<PutDeliveryChannelResponse>
    {
        public PutDeliveryChannelRequest()
            : base("Config", "2019-01-08", "PutDeliveryChannel", "Config", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Config.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Config.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string description;

		private string deliveryChannelTargetArn;

		private string deliveryChannelCondition;

		private string deliveryChannelAssumeRoleArn;

		private string deliveryChannelName;

		private string deliveryChannelId;

		private string deliveryChannelType;

		private int? status;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(BodyParameters, "ClientToken", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public string DeliveryChannelTargetArn
		{
			get
			{
				return deliveryChannelTargetArn;
			}
			set	
			{
				deliveryChannelTargetArn = value;
				DictionaryUtil.Add(BodyParameters, "DeliveryChannelTargetArn", value);
			}
		}

		public string DeliveryChannelCondition
		{
			get
			{
				return deliveryChannelCondition;
			}
			set	
			{
				deliveryChannelCondition = value;
				DictionaryUtil.Add(BodyParameters, "DeliveryChannelCondition", value);
			}
		}

		public string DeliveryChannelAssumeRoleArn
		{
			get
			{
				return deliveryChannelAssumeRoleArn;
			}
			set	
			{
				deliveryChannelAssumeRoleArn = value;
				DictionaryUtil.Add(BodyParameters, "DeliveryChannelAssumeRoleArn", value);
			}
		}

		public string DeliveryChannelName
		{
			get
			{
				return deliveryChannelName;
			}
			set	
			{
				deliveryChannelName = value;
				DictionaryUtil.Add(BodyParameters, "DeliveryChannelName", value);
			}
		}

		public string DeliveryChannelId
		{
			get
			{
				return deliveryChannelId;
			}
			set	
			{
				deliveryChannelId = value;
				DictionaryUtil.Add(BodyParameters, "DeliveryChannelId", value);
			}
		}

		public string DeliveryChannelType
		{
			get
			{
				return deliveryChannelType;
			}
			set	
			{
				deliveryChannelType = value;
				DictionaryUtil.Add(BodyParameters, "DeliveryChannelType", value);
			}
		}

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PutDeliveryChannelResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PutDeliveryChannelResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
