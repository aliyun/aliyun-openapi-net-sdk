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
    public class GetProfileListRequest : RpcAcsRequest<GetProfileListResponse>
    {
        public GetProfileListRequest()
            : base("Vcs", "2020-05-15", "GetProfileList")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<object> profileIdList;

		private string corpId;

		private int? gender;

		private string plateNo;

		private string idNumber;

		private long? pageNumber;

		private string faceImageId;

		private string faceUrl;

		private long? pageSize;

		private List<object> personIdList;

		private string liveAddress;

		private string isvSubId;

		private string sceneType;

		private string phoneNo;

		private long? catalogId;

		private string name;

		private string bizId;

		private string matchingRateThreshold;

		public List<object> ProfileIdList
		{
			get
			{
				return profileIdList;
			}
			set	
			{
				profileIdList = value;
				DictionaryUtil.Add(BodyParameters, "ProfileIdList", JsonConvert.SerializeObject(value));
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

		public string FaceImageId
		{
			get
			{
				return faceImageId;
			}
			set	
			{
				faceImageId = value;
				DictionaryUtil.Add(BodyParameters, "FaceImageId", value);
			}
		}

		public string FaceUrl
		{
			get
			{
				return faceUrl;
			}
			set	
			{
				faceUrl = value;
				DictionaryUtil.Add(BodyParameters, "FaceUrl", value);
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

		public List<object> PersonIdList
		{
			get
			{
				return personIdList;
			}
			set	
			{
				personIdList = value;
				DictionaryUtil.Add(BodyParameters, "PersonIdList", JsonConvert.SerializeObject(value));
			}
		}

		public string LiveAddress
		{
			get
			{
				return liveAddress;
			}
			set	
			{
				liveAddress = value;
				DictionaryUtil.Add(BodyParameters, "LiveAddress", value);
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

		public string SceneType
		{
			get
			{
				return sceneType;
			}
			set	
			{
				sceneType = value;
				DictionaryUtil.Add(BodyParameters, "SceneType", value);
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

		public long? CatalogId
		{
			get
			{
				return catalogId;
			}
			set	
			{
				catalogId = value;
				DictionaryUtil.Add(BodyParameters, "CatalogId", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "Name", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetProfileListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetProfileListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
