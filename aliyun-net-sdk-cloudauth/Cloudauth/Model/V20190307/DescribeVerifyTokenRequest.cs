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
using Aliyun.Acs.Cloudauth.Transform;
using Aliyun.Acs.Cloudauth.Transform.V20190307;

namespace Aliyun.Acs.Cloudauth.Model.V20190307
{
    public class DescribeVerifyTokenRequest : RpcAcsRequest<DescribeVerifyTokenResponse>
    {
        public DescribeVerifyTokenRequest()
            : base("Cloudauth", "2019-03-07", "DescribeVerifyToken", "cloudauth", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string faceRetainedImageUrl;

		private string userId;

		private string callbackSeed;

		private string userIp;

		private string idCardBackImageUrl;

		private string idCardNumber;

		private string idCardFrontImageUrl;

		private string bizType;

		private string passedRedirectUrl;

		private long? userRegistTime;

		private string bizId;

		private string name;

		private string userPhoneNumber;

		private string callbackUrl;

		private string failedRedirectUrl;

		public string FaceRetainedImageUrl
		{
			get
			{
				return faceRetainedImageUrl;
			}
			set	
			{
				faceRetainedImageUrl = value;
				DictionaryUtil.Add(QueryParameters, "FaceRetainedImageUrl", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
			}
		}

		public string CallbackSeed
		{
			get
			{
				return callbackSeed;
			}
			set	
			{
				callbackSeed = value;
				DictionaryUtil.Add(QueryParameters, "CallbackSeed", value);
			}
		}

		public string UserIp
		{
			get
			{
				return userIp;
			}
			set	
			{
				userIp = value;
				DictionaryUtil.Add(QueryParameters, "UserIp", value);
			}
		}

		public string IdCardBackImageUrl
		{
			get
			{
				return idCardBackImageUrl;
			}
			set	
			{
				idCardBackImageUrl = value;
				DictionaryUtil.Add(QueryParameters, "IdCardBackImageUrl", value);
			}
		}

		public string IdCardNumber
		{
			get
			{
				return idCardNumber;
			}
			set	
			{
				idCardNumber = value;
				DictionaryUtil.Add(QueryParameters, "IdCardNumber", value);
			}
		}

		public string IdCardFrontImageUrl
		{
			get
			{
				return idCardFrontImageUrl;
			}
			set	
			{
				idCardFrontImageUrl = value;
				DictionaryUtil.Add(QueryParameters, "IdCardFrontImageUrl", value);
			}
		}

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(QueryParameters, "BizType", value);
			}
		}

		public string PassedRedirectUrl
		{
			get
			{
				return passedRedirectUrl;
			}
			set	
			{
				passedRedirectUrl = value;
				DictionaryUtil.Add(QueryParameters, "PassedRedirectUrl", value);
			}
		}

		public long? UserRegistTime
		{
			get
			{
				return userRegistTime;
			}
			set	
			{
				userRegistTime = value;
				DictionaryUtil.Add(QueryParameters, "UserRegistTime", value.ToString());
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

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string UserPhoneNumber
		{
			get
			{
				return userPhoneNumber;
			}
			set	
			{
				userPhoneNumber = value;
				DictionaryUtil.Add(QueryParameters, "UserPhoneNumber", value);
			}
		}

		public string CallbackUrl
		{
			get
			{
				return callbackUrl;
			}
			set	
			{
				callbackUrl = value;
				DictionaryUtil.Add(QueryParameters, "CallbackUrl", value);
			}
		}

		public string FailedRedirectUrl
		{
			get
			{
				return failedRedirectUrl;
			}
			set	
			{
				failedRedirectUrl = value;
				DictionaryUtil.Add(QueryParameters, "FailedRedirectUrl", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeVerifyTokenResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeVerifyTokenResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
