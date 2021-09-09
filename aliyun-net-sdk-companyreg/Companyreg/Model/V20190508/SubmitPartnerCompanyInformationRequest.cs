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
    public class SubmitPartnerCompanyInformationRequest : RpcAcsRequest<SubmitPartnerCompanyInformationResponse>
    {
        public SubmitPartnerCompanyInformationRequest()
            : base("companyreg", "2019-05-08", "SubmitPartnerCompanyInformation", "companyreg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.companyreg.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string uscc;

		private string contactName;

		private string companyName;

		private string bizId;

		private string contactMobile;

		private string companyBizType;

		public string Uscc
		{
			get
			{
				return uscc;
			}
			set	
			{
				uscc = value;
				DictionaryUtil.Add(QueryParameters, "Uscc", value);
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
				DictionaryUtil.Add(QueryParameters, "ContactName", value);
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

		public string ContactMobile
		{
			get
			{
				return contactMobile;
			}
			set	
			{
				contactMobile = value;
				DictionaryUtil.Add(QueryParameters, "ContactMobile", value);
			}
		}

		public string CompanyBizType
		{
			get
			{
				return companyBizType;
			}
			set	
			{
				companyBizType = value;
				DictionaryUtil.Add(QueryParameters, "CompanyBizType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitPartnerCompanyInformationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitPartnerCompanyInformationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
