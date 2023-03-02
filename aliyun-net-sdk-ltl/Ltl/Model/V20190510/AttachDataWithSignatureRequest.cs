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
using Aliyun.Acs.ltl;
using Aliyun.Acs.ltl.Transform;
using Aliyun.Acs.ltl.Transform.V20190510;

namespace Aliyun.Acs.ltl.Model.V20190510
{
    public class AttachDataWithSignatureRequest : RpcAcsRequest<AttachDataWithSignatureResponse>
    {
        public AttachDataWithSignatureRequest()
            : base("ltl", "2019-05-10", "AttachDataWithSignature")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ltl.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ltl.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string iotSignature;

		private string iotAuthType;

		private string iotIdSource;

		private string businessId;

		private string apiVersion;

		private string productKey;

		private string iotId;

		private string iotDataDigest;

		private string iotIdServiceProvider;

		private string _value;

		private string key;

		public string IotSignature
		{
			get
			{
				return iotSignature;
			}
			set	
			{
				iotSignature = value;
				DictionaryUtil.Add(QueryParameters, "IotSignature", value);
			}
		}

		public string IotAuthType
		{
			get
			{
				return iotAuthType;
			}
			set	
			{
				iotAuthType = value;
				DictionaryUtil.Add(QueryParameters, "IotAuthType", value);
			}
		}

		public string IotIdSource
		{
			get
			{
				return iotIdSource;
			}
			set	
			{
				iotIdSource = value;
				DictionaryUtil.Add(QueryParameters, "IotIdSource", value);
			}
		}

		public string BusinessId
		{
			get
			{
				return businessId;
			}
			set	
			{
				businessId = value;
				DictionaryUtil.Add(QueryParameters, "BusinessId", value);
			}
		}

		public string ApiVersion
		{
			get
			{
				return apiVersion;
			}
			set	
			{
				apiVersion = value;
				DictionaryUtil.Add(QueryParameters, "ApiVersion", value);
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		public string IotId
		{
			get
			{
				return iotId;
			}
			set	
			{
				iotId = value;
				DictionaryUtil.Add(QueryParameters, "IotId", value);
			}
		}

		public string IotDataDigest
		{
			get
			{
				return iotDataDigest;
			}
			set	
			{
				iotDataDigest = value;
				DictionaryUtil.Add(QueryParameters, "IotDataDigest", value);
			}
		}

		public string IotIdServiceProvider
		{
			get
			{
				return iotIdServiceProvider;
			}
			set	
			{
				iotIdServiceProvider = value;
				DictionaryUtil.Add(QueryParameters, "IotIdServiceProvider", value);
			}
		}

		public string _Value
		{
			get
			{
				return _value;
			}
			set	
			{
				_value = value;
				DictionaryUtil.Add(QueryParameters, "Value", value);
			}
		}

		public string Key
		{
			get
			{
				return key;
			}
			set	
			{
				key = value;
				DictionaryUtil.Add(QueryParameters, "Key", value);
			}
		}

        public override AttachDataWithSignatureResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AttachDataWithSignatureResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
