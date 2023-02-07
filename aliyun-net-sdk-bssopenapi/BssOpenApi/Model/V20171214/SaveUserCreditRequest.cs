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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class SaveUserCreditRequest : RpcAcsRequest<SaveUserCreditResponse>
    {
        public SaveUserCreditRequest()
            : base("BssOpenApi", "2017-12-14", "SaveUserCredit", "bssopenapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private bool? avoidExpiration;

		private string description;

		private bool? avoidPrepaidNotification;

		private bool? avoidPrepaidExpiration;

		private bool? avoidNotification;

		private string _operator;

		private string creditValue;

		private string creditType;

		[JsonProperty(PropertyName = "AvoidExpiration")]
		public bool? AvoidExpiration
		{
			get
			{
				return avoidExpiration;
			}
			set	
			{
				avoidExpiration = value;
				DictionaryUtil.Add(QueryParameters, "AvoidExpiration", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Description")]
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

		[JsonProperty(PropertyName = "AvoidPrepaidNotification")]
		public bool? AvoidPrepaidNotification
		{
			get
			{
				return avoidPrepaidNotification;
			}
			set	
			{
				avoidPrepaidNotification = value;
				DictionaryUtil.Add(QueryParameters, "AvoidPrepaidNotification", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AvoidPrepaidExpiration")]
		public bool? AvoidPrepaidExpiration
		{
			get
			{
				return avoidPrepaidExpiration;
			}
			set	
			{
				avoidPrepaidExpiration = value;
				DictionaryUtil.Add(QueryParameters, "AvoidPrepaidExpiration", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AvoidNotification")]
		public bool? AvoidNotification
		{
			get
			{
				return avoidNotification;
			}
			set	
			{
				avoidNotification = value;
				DictionaryUtil.Add(QueryParameters, "AvoidNotification", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Operator")]
		public string _Operator
		{
			get
			{
				return _operator;
			}
			set	
			{
				_operator = value;
				DictionaryUtil.Add(QueryParameters, "Operator", value);
			}
		}

		[JsonProperty(PropertyName = "CreditValue")]
		public string CreditValue
		{
			get
			{
				return creditValue;
			}
			set	
			{
				creditValue = value;
				DictionaryUtil.Add(QueryParameters, "CreditValue", value);
			}
		}

		[JsonProperty(PropertyName = "CreditType")]
		public string CreditType
		{
			get
			{
				return creditType;
			}
			set	
			{
				creditType = value;
				DictionaryUtil.Add(QueryParameters, "CreditType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveUserCreditResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveUserCreditResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
