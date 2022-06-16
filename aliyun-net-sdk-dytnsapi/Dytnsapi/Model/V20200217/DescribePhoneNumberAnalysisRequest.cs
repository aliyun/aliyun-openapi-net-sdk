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
using Aliyun.Acs.Dytnsapi;
using Aliyun.Acs.Dytnsapi.Transform;
using Aliyun.Acs.Dytnsapi.Transform.V20200217;

namespace Aliyun.Acs.Dytnsapi.Model.V20200217
{
    public class DescribePhoneNumberAnalysisRequest : RpcAcsRequest<DescribePhoneNumberAnalysisResponse>
    {
        public DescribePhoneNumberAnalysisRequest()
            : base("Dytnsapi", "2020-02-17", "DescribePhoneNumberAnalysis")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dytnsapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dytnsapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private long? rate;

		private string mask;

		private string resourceOwnerAccount;

		private long? ownerId;

		private int? numberType;

		private string authCode;

		private string inputNumber;

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

		public long? Rate
		{
			get
			{
				return rate;
			}
			set	
			{
				rate = value;
				DictionaryUtil.Add(QueryParameters, "Rate", value.ToString());
			}
		}

		public string Mask
		{
			get
			{
				return mask;
			}
			set	
			{
				mask = value;
				DictionaryUtil.Add(QueryParameters, "Mask", value);
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

		public int? NumberType
		{
			get
			{
				return numberType;
			}
			set	
			{
				numberType = value;
				DictionaryUtil.Add(QueryParameters, "NumberType", value.ToString());
			}
		}

		public string AuthCode
		{
			get
			{
				return authCode;
			}
			set	
			{
				authCode = value;
				DictionaryUtil.Add(QueryParameters, "AuthCode", value);
			}
		}

		public string InputNumber
		{
			get
			{
				return inputNumber;
			}
			set	
			{
				inputNumber = value;
				DictionaryUtil.Add(QueryParameters, "InputNumber", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribePhoneNumberAnalysisResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribePhoneNumberAnalysisResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
