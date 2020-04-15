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
using Aliyun.Acs.Trademark.Transform;
using Aliyun.Acs.Trademark.Transform.V20180724;

namespace Aliyun.Acs.Trademark.Model.V20180724
{
    public class SaveTradeMarkReviewMaterialDetailRequest : RpcAcsRequest<SaveTradeMarkReviewMaterialDetailResponse>
    {
        public SaveTradeMarkReviewMaterialDetailRequest()
            : base("Trademark", "2018-07-24", "SaveTradeMarkReviewMaterialDetail", "trademark", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string contactEmail;

		private string engName;

		private string country;

		private string legalNoticeOssKey;

		private string contactNumber;

		private string engAddress;

		private int? type;

		private string contactName;

		private string passportOssKey;

		private string province;

		private int? submitType;

		private string loaOssKey;

		private string contactAddress;

		private string address;

		private string idCardOssKey;

		private string applicationOssKey;

		private string businessLicenceOssKey;

		private string bizId;

		private string name;

		private string additionalOssKeyList;

		private string cardNumber;

		private int? region;

		public string ContactEmail
		{
			get
			{
				return contactEmail;
			}
			set	
			{
				contactEmail = value;
				DictionaryUtil.Add(BodyParameters, "ContactEmail", value);
			}
		}

		public string EngName
		{
			get
			{
				return engName;
			}
			set	
			{
				engName = value;
				DictionaryUtil.Add(BodyParameters, "EngName", value);
			}
		}

		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
				DictionaryUtil.Add(BodyParameters, "Country", value);
			}
		}

		public string LegalNoticeOssKey
		{
			get
			{
				return legalNoticeOssKey;
			}
			set	
			{
				legalNoticeOssKey = value;
				DictionaryUtil.Add(BodyParameters, "LegalNoticeOssKey", value);
			}
		}

		public string ContactNumber
		{
			get
			{
				return contactNumber;
			}
			set	
			{
				contactNumber = value;
				DictionaryUtil.Add(BodyParameters, "ContactNumber", value);
			}
		}

		public string EngAddress
		{
			get
			{
				return engAddress;
			}
			set	
			{
				engAddress = value;
				DictionaryUtil.Add(BodyParameters, "EngAddress", value);
			}
		}

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value.ToString());
			}
		}

		public string ContactName
		{
			get
			{
				return contactName;
			}
			set	
			{
				contactName = value;
				DictionaryUtil.Add(BodyParameters, "ContactName", value);
			}
		}

		public string PassportOssKey
		{
			get
			{
				return passportOssKey;
			}
			set	
			{
				passportOssKey = value;
				DictionaryUtil.Add(BodyParameters, "PassportOssKey", value);
			}
		}

		public string Province
		{
			get
			{
				return province;
			}
			set	
			{
				province = value;
				DictionaryUtil.Add(BodyParameters, "Province", value);
			}
		}

		public int? SubmitType
		{
			get
			{
				return submitType;
			}
			set	
			{
				submitType = value;
				DictionaryUtil.Add(BodyParameters, "SubmitType", value.ToString());
			}
		}

		public string LoaOssKey
		{
			get
			{
				return loaOssKey;
			}
			set	
			{
				loaOssKey = value;
				DictionaryUtil.Add(BodyParameters, "LoaOssKey", value);
			}
		}

		public string ContactAddress
		{
			get
			{
				return contactAddress;
			}
			set	
			{
				contactAddress = value;
				DictionaryUtil.Add(BodyParameters, "ContactAddress", value);
			}
		}

		public string Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
				DictionaryUtil.Add(BodyParameters, "Address", value);
			}
		}

		public string IdCardOssKey
		{
			get
			{
				return idCardOssKey;
			}
			set	
			{
				idCardOssKey = value;
				DictionaryUtil.Add(BodyParameters, "IdCardOssKey", value);
			}
		}

		public string ApplicationOssKey
		{
			get
			{
				return applicationOssKey;
			}
			set	
			{
				applicationOssKey = value;
				DictionaryUtil.Add(BodyParameters, "ApplicationOssKey", value);
			}
		}

		public string BusinessLicenceOssKey
		{
			get
			{
				return businessLicenceOssKey;
			}
			set	
			{
				businessLicenceOssKey = value;
				DictionaryUtil.Add(BodyParameters, "BusinessLicenceOssKey", value);
			}
		}

		public string BizId
		{
			get
			{
				return bizId;
			}
			set	
			{
				bizId = value;
				DictionaryUtil.Add(BodyParameters, "BizId", value);
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
				DictionaryUtil.Add(BodyParameters, "Name", value);
			}
		}

		public string AdditionalOssKeyList
		{
			get
			{
				return additionalOssKeyList;
			}
			set	
			{
				additionalOssKeyList = value;
				DictionaryUtil.Add(BodyParameters, "AdditionalOssKeyList", value);
			}
		}

		public string CardNumber
		{
			get
			{
				return cardNumber;
			}
			set	
			{
				cardNumber = value;
				DictionaryUtil.Add(BodyParameters, "CardNumber", value);
			}
		}

		public int? Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(BodyParameters, "Region", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveTradeMarkReviewMaterialDetailResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveTradeMarkReviewMaterialDetailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
