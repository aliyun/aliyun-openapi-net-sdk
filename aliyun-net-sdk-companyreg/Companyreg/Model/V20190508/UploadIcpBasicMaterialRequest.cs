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
using Aliyun.Acs.companyreg.Transform;
using Aliyun.Acs.companyreg.Transform.V20190508;

namespace Aliyun.Acs.companyreg.Model.V20190508
{
    public class UploadIcpBasicMaterialRequest : RpcAcsRequest<UploadIcpBasicMaterialResponse>
    {
        public UploadIcpBasicMaterialRequest()
            : base("companyreg", "2019-05-08", "UploadIcpBasicMaterial", "companyreg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string socialCreditCode;

		private string businessLicense;

		private string corporateIdCard;

		private string idCardList;

		private string companyAddress;

		private string companyName;

		private string bizId;

		private string corporateName;

		public string SocialCreditCode
		{
			get
			{
				return socialCreditCode;
			}
			set	
			{
				socialCreditCode = value;
				DictionaryUtil.Add(QueryParameters, "SocialCreditCode", value);
			}
		}

		public string BusinessLicense
		{
			get
			{
				return businessLicense;
			}
			set	
			{
				businessLicense = value;
				DictionaryUtil.Add(QueryParameters, "BusinessLicense", value);
			}
		}

		public string CorporateIdCard
		{
			get
			{
				return corporateIdCard;
			}
			set	
			{
				corporateIdCard = value;
				DictionaryUtil.Add(QueryParameters, "CorporateIdCard", value);
			}
		}

		public string IdCardList
		{
			get
			{
				return idCardList;
			}
			set	
			{
				idCardList = value;
				DictionaryUtil.Add(QueryParameters, "IdCardList", value);
			}
		}

		public string CompanyAddress
		{
			get
			{
				return companyAddress;
			}
			set	
			{
				companyAddress = value;
				DictionaryUtil.Add(QueryParameters, "CompanyAddress", value);
			}
		}

		public string CompanyName
		{
			get
			{
				return companyName;
			}
			set	
			{
				companyName = value;
				DictionaryUtil.Add(QueryParameters, "CompanyName", value);
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
				DictionaryUtil.Add(QueryParameters, "BizId", value);
			}
		}

		public string CorporateName
		{
			get
			{
				return corporateName;
			}
			set	
			{
				corporateName = value;
				DictionaryUtil.Add(QueryParameters, "CorporateName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UploadIcpBasicMaterialResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UploadIcpBasicMaterialResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
