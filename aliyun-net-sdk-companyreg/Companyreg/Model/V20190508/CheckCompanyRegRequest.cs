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
    public class CheckCompanyRegRequest : RpcAcsRequest<CheckCompanyRegResponse>
    {
        public CheckCompanyRegRequest()
            : base("companyreg", "2019-05-08", "CheckCompanyReg", "companyreg", "openAPI")
        {
        }

		private string orgType;

		private string industryType;

		private string tradeName;

		private string city;

		private int? nameType;

		public string OrgType
		{
			get
			{
				return orgType;
			}
			set	
			{
				orgType = value;
				DictionaryUtil.Add(QueryParameters, "OrgType", value);
			}
		}

		public string IndustryType
		{
			get
			{
				return industryType;
			}
			set	
			{
				industryType = value;
				DictionaryUtil.Add(QueryParameters, "IndustryType", value);
			}
		}

		public string TradeName
		{
			get
			{
				return tradeName;
			}
			set	
			{
				tradeName = value;
				DictionaryUtil.Add(QueryParameters, "TradeName", value);
			}
		}

		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
				DictionaryUtil.Add(QueryParameters, "City", value);
			}
		}

		public int? NameType
		{
			get
			{
				return nameType;
			}
			set	
			{
				nameType = value;
				DictionaryUtil.Add(QueryParameters, "NameType", value.ToString());
			}
		}

        public override CheckCompanyRegResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CheckCompanyRegResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
