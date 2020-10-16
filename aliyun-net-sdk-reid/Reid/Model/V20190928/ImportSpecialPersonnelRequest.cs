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
using Aliyun.Acs.reid.Transform;
using Aliyun.Acs.reid.Transform.V20190928;

namespace Aliyun.Acs.reid.Model.V20190928
{
    public class ImportSpecialPersonnelRequest : RpcAcsRequest<ImportSpecialPersonnelResponse>
    {
        public ImportSpecialPersonnelRequest()
            : base("reid", "2019-09-28", "ImportSpecialPersonnel", "1.1.8.5", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? ukId;

		private string description;

		private string externalId;

		private string personType;

		private string urls;

		private string personName;

		private string storeIds;

		private string status;

		public long? UkId
		{
			get
			{
				return ukId;
			}
			set	
			{
				ukId = value;
				DictionaryUtil.Add(BodyParameters, "UkId", value.ToString());
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

		public string ExternalId
		{
			get
			{
				return externalId;
			}
			set	
			{
				externalId = value;
				DictionaryUtil.Add(BodyParameters, "ExternalId", value);
			}
		}

		public string PersonType
		{
			get
			{
				return personType;
			}
			set	
			{
				personType = value;
				DictionaryUtil.Add(BodyParameters, "PersonType", value);
			}
		}

		public string Urls
		{
			get
			{
				return urls;
			}
			set	
			{
				urls = value;
				DictionaryUtil.Add(BodyParameters, "Urls", value);
			}
		}

		public string PersonName
		{
			get
			{
				return personName;
			}
			set	
			{
				personName = value;
				DictionaryUtil.Add(BodyParameters, "PersonName", value);
			}
		}

		public string StoreIds
		{
			get
			{
				return storeIds;
			}
			set	
			{
				storeIds = value;
				DictionaryUtil.Add(BodyParameters, "StoreIds", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value);
			}
		}

        public override ImportSpecialPersonnelResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImportSpecialPersonnelResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
