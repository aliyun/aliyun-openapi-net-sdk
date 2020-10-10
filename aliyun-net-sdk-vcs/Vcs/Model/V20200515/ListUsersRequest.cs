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
    public class ListUsersRequest : RpcAcsRequest<ListUsersResponse>
    {
        public ListUsersRequest()
            : base("Vcs", "2020-05-15", "ListUsers")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<object> userList;

		private string corpId;

		private int? gender;

		private string plateNo;

		private string idNumber;

		private string faceImageUrl;

		private List<object> personList;

		private long? pageNumber;

		private string attachment;

		private long? pageSize;

		private string isvSubId;

		private string address;

		private long? userGroupId;

		private string phoneNo;

		private string bizId;

		private int? age;

		private string matchingRateThreshold;

		private string userName;

		public List<object> UserList
		{
			get
			{
				return userList;
			}
			set	
			{
				userList = value;
				DictionaryUtil.Add(BodyParameters, "UserList", JsonConvert.SerializeObject(value));
			}
		}

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

		public List<object> PersonList
		{
			get
			{
				return personList;
			}
			set	
			{
				personList = value;
				DictionaryUtil.Add(BodyParameters, "PersonList", JsonConvert.SerializeObject(value));
			}
		}

		public long? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
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

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
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

		public string MatchingRateThreshold
		{
			get
			{
				return matchingRateThreshold;
			}
			set	
			{
				matchingRateThreshold = value;
				DictionaryUtil.Add(BodyParameters, "MatchingRateThreshold", value);
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

        public override ListUsersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListUsersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
