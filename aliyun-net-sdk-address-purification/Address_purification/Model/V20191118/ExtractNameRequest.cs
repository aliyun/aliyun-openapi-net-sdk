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
using Aliyun.Acs.address_purification.Transform;
using Aliyun.Acs.address_purification.Transform.V20191118;

namespace Aliyun.Acs.address_purification.Model.V20191118
{
    public class ExtractNameRequest : RpcAcsRequest<ExtractNameResponse>
    {
        public ExtractNameRequest()
            : base("address-purification", "2019-11-18", "ExtractName", "addrp", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.address_purification.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.address_purification.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string defaultProvince;

		private string serviceCode;

		private string defaultCity;

		private string defaultDistrict;

		private string appKey;

		private string text;

		public string DefaultProvince
		{
			get
			{
				return defaultProvince;
			}
			set	
			{
				defaultProvince = value;
				DictionaryUtil.Add(BodyParameters, "DefaultProvince", value);
			}
		}

		public string ServiceCode
		{
			get
			{
				return serviceCode;
			}
			set	
			{
				serviceCode = value;
				DictionaryUtil.Add(BodyParameters, "ServiceCode", value);
			}
		}

		public string DefaultCity
		{
			get
			{
				return defaultCity;
			}
			set	
			{
				defaultCity = value;
				DictionaryUtil.Add(BodyParameters, "DefaultCity", value);
			}
		}

		public string DefaultDistrict
		{
			get
			{
				return defaultDistrict;
			}
			set	
			{
				defaultDistrict = value;
				DictionaryUtil.Add(BodyParameters, "DefaultDistrict", value);
			}
		}

		public string AppKey
		{
			get
			{
				return appKey;
			}
			set	
			{
				appKey = value;
				DictionaryUtil.Add(BodyParameters, "AppKey", value);
			}
		}

		public string Text
		{
			get
			{
				return text;
			}
			set	
			{
				text = value;
				DictionaryUtil.Add(BodyParameters, "Text", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ExtractNameResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ExtractNameResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
