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
using Aliyun.Acs.Dyvmsapi.Transform;
using Aliyun.Acs.Dyvmsapi.Transform.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Model.V20170525
{
    public class SubmitHotlineTransferRegisterRequest : RpcAcsRequest<SubmitHotlineTransferRegisterResponse>
    {
        public SubmitHotlineTransferRegisterRequest()
            : base("Dyvmsapi", "2017-05-25", "SubmitHotlineTransferRegister", "dyvms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dyvmsapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dyvmsapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string operatorIdentityCard;

		private long? resourceOwnerId;

		private string operatorMail;

		private string hotlineNumber;

		private List<TransferPhoneNumberInfos> transferPhoneNumberInfoss = new List<TransferPhoneNumberInfos>(){ };

		private string operatorMobileVerifyCode;

		private string agreement;

		private string qualificationId;

		private string resourceOwnerAccount;

		private long? ownerId;

		private string operatorMobile;

		private string operatorMailVerifyCode;

		private string operatorName;

		public string OperatorIdentityCard
		{
			get
			{
				return operatorIdentityCard;
			}
			set	
			{
				operatorIdentityCard = value;
				DictionaryUtil.Add(QueryParameters, "OperatorIdentityCard", value);
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

		public string OperatorMail
		{
			get
			{
				return operatorMail;
			}
			set	
			{
				operatorMail = value;
				DictionaryUtil.Add(QueryParameters, "OperatorMail", value);
			}
		}

		public string HotlineNumber
		{
			get
			{
				return hotlineNumber;
			}
			set	
			{
				hotlineNumber = value;
				DictionaryUtil.Add(QueryParameters, "HotlineNumber", value);
			}
		}

		public List<TransferPhoneNumberInfos> TransferPhoneNumberInfoss
		{
			get
			{
				return transferPhoneNumberInfoss;
			}

			set
			{
				transferPhoneNumberInfoss = value;
				for (int i = 0; i < transferPhoneNumberInfoss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TransferPhoneNumberInfos." + (i + 1) + ".PhoneNumber", transferPhoneNumberInfoss[i].PhoneNumber);
					DictionaryUtil.Add(QueryParameters,"TransferPhoneNumberInfos." + (i + 1) + ".PhoneNumberOwnerName", transferPhoneNumberInfoss[i].PhoneNumberOwnerName);
					DictionaryUtil.Add(QueryParameters,"TransferPhoneNumberInfos." + (i + 1) + ".IdentityCard", transferPhoneNumberInfoss[i].IdentityCard);
				}
			}
		}

		public string OperatorMobileVerifyCode
		{
			get
			{
				return operatorMobileVerifyCode;
			}
			set	
			{
				operatorMobileVerifyCode = value;
				DictionaryUtil.Add(QueryParameters, "OperatorMobileVerifyCode", value);
			}
		}

		public string Agreement
		{
			get
			{
				return agreement;
			}
			set	
			{
				agreement = value;
				DictionaryUtil.Add(QueryParameters, "Agreement", value);
			}
		}

		public string QualificationId
		{
			get
			{
				return qualificationId;
			}
			set	
			{
				qualificationId = value;
				DictionaryUtil.Add(QueryParameters, "QualificationId", value);
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

		public string OperatorMobile
		{
			get
			{
				return operatorMobile;
			}
			set	
			{
				operatorMobile = value;
				DictionaryUtil.Add(QueryParameters, "OperatorMobile", value);
			}
		}

		public string OperatorMailVerifyCode
		{
			get
			{
				return operatorMailVerifyCode;
			}
			set	
			{
				operatorMailVerifyCode = value;
				DictionaryUtil.Add(QueryParameters, "OperatorMailVerifyCode", value);
			}
		}

		public string OperatorName
		{
			get
			{
				return operatorName;
			}
			set	
			{
				operatorName = value;
				DictionaryUtil.Add(QueryParameters, "OperatorName", value);
			}
		}

		public class TransferPhoneNumberInfos
		{

			private string phoneNumber;

			private string phoneNumberOwnerName;

			private string identityCard;

			public string PhoneNumber
			{
				get
				{
					return phoneNumber;
				}
				set	
				{
					phoneNumber = value;
				}
			}

			public string PhoneNumberOwnerName
			{
				get
				{
					return phoneNumberOwnerName;
				}
				set	
				{
					phoneNumberOwnerName = value;
				}
			}

			public string IdentityCard
			{
				get
				{
					return identityCard;
				}
				set	
				{
					identityCard = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitHotlineTransferRegisterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitHotlineTransferRegisterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
