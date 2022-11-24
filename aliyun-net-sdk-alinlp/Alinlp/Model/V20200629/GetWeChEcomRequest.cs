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
using Aliyun.Acs.alinlp;
using Aliyun.Acs.alinlp.Transform;
using Aliyun.Acs.alinlp.Transform.V20200629;

namespace Aliyun.Acs.alinlp.Model.V20200629
{
    public class GetWeChEcomRequest : RpcAcsRequest<GetWeChEcomResponse>
    {
        public GetWeChEcomRequest()
            : base("alinlp", "2020-06-29", "GetWeChEcom")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.alinlp.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.alinlp.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string type;

		private string serviceCode;

		private string size;

		private string tokenizerId;

		private string text;

		private string operation;

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value);
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

		public string Size
		{
			get
			{
				return size;
			}
			set	
			{
				size = value;
				DictionaryUtil.Add(BodyParameters, "Size", value);
			}
		}

		public string TokenizerId
		{
			get
			{
				return tokenizerId;
			}
			set	
			{
				tokenizerId = value;
				DictionaryUtil.Add(BodyParameters, "TokenizerId", value);
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

		public string Operation
		{
			get
			{
				return operation;
			}
			set	
			{
				operation = value;
				DictionaryUtil.Add(BodyParameters, "Operation", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetWeChEcomResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetWeChEcomResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
