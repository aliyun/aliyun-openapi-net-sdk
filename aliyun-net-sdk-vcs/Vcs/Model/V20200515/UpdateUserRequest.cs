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
using Aliyun.Acs.Vcs;
using Aliyun.Acs.Vcs.Transform;
using Aliyun.Acs.Vcs.Transform.V20200515;

namespace Aliyun.Acs.Vcs.Model.V20200515
{
    public class UpdateUserRequest : RpcAcsRequest<UpdateUserResponse>
    {
        public UpdateUserRequest()
            : base("Vcs", "2020-05-15", "UpdateUser")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string corpId;

		private string faceImageContent;

		private int? gender;

		private string plateNo;

		private string idNumber;

		private string faceImageUrl;

		private long? userId;

		private string attachment;

		private string isvSubId;

		private string address;

		private long? userGroupId;

		private string phoneNo;

		private string bizId;

		private int? age;

		private string userName;

		public string CorpId
		{
			get
			{
				return corpId;
			}
			set	
			{
				corpId = value;
				DictionaryUtil.Add(BodyParameters, "CorpId", value);
			}
		}

		public string FaceImageContent
		{
			get
			{
				return faceImageContent;
			}
			set	
			{
				faceImageContent = value;
				DictionaryUtil.Add(BodyParameters, "FaceImageContent", value);
			}
		}

		public int? Gender
		{
			get
			{
				return gender;
			}
			set	
			{
				gender = value;
				DictionaryUtil.Add(BodyParameters, "Gender", value.ToString());
			}
		}

		public string PlateNo
		{
			get
			{
				return plateNo;
			}
			set	
			{
				plateNo = value;
				DictionaryUtil.Add(BodyParameters, "PlateNo", value);
			}
		}

		public string IdNumber
		{
			get
			{
				return idNumber;
			}
			set	
			{
				idNumber = value;
				DictionaryUtil.Add(BodyParameters, "IdNumber", value);
			}
		}

		public string FaceImageUrl
		{
			get
			{
				return faceImageUrl;
			}
			set	
			{
				faceImageUrl = value;
				DictionaryUtil.Add(BodyParameters, "FaceImageUrl", value);
			}
		}

		public long? UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(BodyParameters, "UserId", value.ToString());
			}
		}

		public string Attachment
		{
			get
			{
				return attachment;
			}
			set	
			{
				attachment = value;
				DictionaryUtil.Add(BodyParameters, "Attachment", value);
			}
		}

		public string IsvSubId
		{
			get
			{
				return isvSubId;
			}
			set	
			{
				isvSubId = value;
				DictionaryUtil.Add(BodyParameters, "IsvSubId", value);
			}
		}

		public string Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
				DictionaryUtil.Add(BodyParameters, "Address", value);
			}
		}

		public long? UserGroupId
		{
			get
			{
				return userGroupId;
			}
			set	
			{
				userGroupId = value;
				DictionaryUtil.Add(BodyParameters, "UserGroupId", value.ToString());
			}
		}

		public string PhoneNo
		{
			get
			{
				return phoneNo;
			}
			set	
			{
				phoneNo = value;
				DictionaryUtil.Add(BodyParameters, "PhoneNo", value);
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
				DictionaryUtil.Add(BodyParameters, "BizId", value);
			}
		}

		public int? Age
		{
			get
			{
				return age;
			}
			set	
			{
				age = value;
				DictionaryUtil.Add(BodyParameters, "Age", value.ToString());
			}
		}

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(BodyParameters, "UserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateUserResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateUserResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
