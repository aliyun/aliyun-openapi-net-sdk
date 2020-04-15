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
using Aliyun.Acs.Smartag.Transform;
using Aliyun.Acs.Smartag.Transform.V20180313;

namespace Aliyun.Acs.Smartag.Model.V20180313
{
    public class CreateSmartAccessGatewayRequest : RpcAcsRequest<CreateSmartAccessGatewayResponse>
    {
        public CreateSmartAccessGatewayRequest()
            : base("Smartag", "2018-03-13", "CreateSmartAccessGateway", "smartag", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private int? maxBandWidth;

		private long? resourceOwnerId;

		private string description;

		private string receiverTown;

		private string receiverDistrict;

		private string receiverAddress;

		private string buyerMessage;

		private string hardWareSpec;

		private string receiverEmail;

		private string receiverState;

		private string receiverCity;

		private int? period;

		private bool? autoPay;

		private string receiverMobile;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string receiverPhone;

		private string receiverName;

		private string haType;

		private string name;

		private bool? alreadyHaveSag;

		private string receiverCountry;

		private string chargeType;

		private string receiverZip;

		public int? MaxBandWidth
		{
			get
			{
				return maxBandWidth;
			}
			set	
			{
				maxBandWidth = value;
				DictionaryUtil.Add(QueryParameters, "MaxBandWidth", value.ToString());
			}
		}

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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string ReceiverTown
		{
			get
			{
				return receiverTown;
			}
			set	
			{
				receiverTown = value;
				DictionaryUtil.Add(QueryParameters, "ReceiverTown", value);
			}
		}

		public string ReceiverDistrict
		{
			get
			{
				return receiverDistrict;
			}
			set	
			{
				receiverDistrict = value;
				DictionaryUtil.Add(QueryParameters, "ReceiverDistrict", value);
			}
		}

		public string ReceiverAddress
		{
			get
			{
				return receiverAddress;
			}
			set	
			{
				receiverAddress = value;
				DictionaryUtil.Add(QueryParameters, "ReceiverAddress", value);
			}
		}

		public string BuyerMessage
		{
			get
			{
				return buyerMessage;
			}
			set	
			{
				buyerMessage = value;
				DictionaryUtil.Add(QueryParameters, "BuyerMessage", value);
			}
		}

		public string HardWareSpec
		{
			get
			{
				return hardWareSpec;
			}
			set	
			{
				hardWareSpec = value;
				DictionaryUtil.Add(QueryParameters, "HardWareSpec", value);
			}
		}

		public string ReceiverEmail
		{
			get
			{
				return receiverEmail;
			}
			set	
			{
				receiverEmail = value;
				DictionaryUtil.Add(QueryParameters, "ReceiverEmail", value);
			}
		}

		public string ReceiverState
		{
			get
			{
				return receiverState;
			}
			set	
			{
				receiverState = value;
				DictionaryUtil.Add(QueryParameters, "ReceiverState", value);
			}
		}

		public string ReceiverCity
		{
			get
			{
				return receiverCity;
			}
			set	
			{
				receiverCity = value;
				DictionaryUtil.Add(QueryParameters, "ReceiverCity", value);
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public bool? AutoPay
		{
			get
			{
				return autoPay;
			}
			set	
			{
				autoPay = value;
				DictionaryUtil.Add(QueryParameters, "AutoPay", value.ToString());
			}
		}

		public string ReceiverMobile
		{
			get
			{
				return receiverMobile;
			}
			set	
			{
				receiverMobile = value;
				DictionaryUtil.Add(QueryParameters, "ReceiverMobile", value);
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

		public string ReceiverPhone
		{
			get
			{
				return receiverPhone;
			}
			set	
			{
				receiverPhone = value;
				DictionaryUtil.Add(QueryParameters, "ReceiverPhone", value);
			}
		}

		public string ReceiverName
		{
			get
			{
				return receiverName;
			}
			set	
			{
				receiverName = value;
				DictionaryUtil.Add(QueryParameters, "ReceiverName", value);
			}
		}

		public string HaType
		{
			get
			{
				return haType;
			}
			set	
			{
				haType = value;
				DictionaryUtil.Add(QueryParameters, "HaType", value);
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
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public bool? AlreadyHaveSag
		{
			get
			{
				return alreadyHaveSag;
			}
			set	
			{
				alreadyHaveSag = value;
				DictionaryUtil.Add(QueryParameters, "AlreadyHaveSag", value.ToString());
			}
		}

		public string ReceiverCountry
		{
			get
			{
				return receiverCountry;
			}
			set	
			{
				receiverCountry = value;
				DictionaryUtil.Add(QueryParameters, "ReceiverCountry", value);
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

		public string ReceiverZip
		{
			get
			{
				return receiverZip;
			}
			set	
			{
				receiverZip = value;
				DictionaryUtil.Add(QueryParameters, "ReceiverZip", value);
			}
		}

        public override CreateSmartAccessGatewayResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSmartAccessGatewayResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
