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
using Aliyun.Acs.facebody.Transform;
using Aliyun.Acs.facebody.Transform.V20191230;

namespace Aliyun.Acs.facebody.Model.V20191230
{
    public class FaceMakeupRequest : RpcAcsRequest<FaceMakeupResponse>
    {
        public FaceMakeupRequest()
            : base("facebody", "2019-12-30", "FaceMakeup", "facebody", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.facebody.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.facebody.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private float? strength;

		private string makeupType;

		private string resourceType;

		private string imageURL;

		public float? Strength
		{
			get
			{
				return strength;
			}
			set	
			{
				strength = value;
				DictionaryUtil.Add(BodyParameters, "Strength", value.ToString());
			}
		}

		public string MakeupType
		{
			get
			{
				return makeupType;
			}
			set	
			{
				makeupType = value;
				DictionaryUtil.Add(BodyParameters, "MakeupType", value);
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(BodyParameters, "ResourceType", value);
			}
		}

		public string ImageURL
		{
			get
			{
				return imageURL;
			}
			set	
			{
				imageURL = value;
				DictionaryUtil.Add(BodyParameters, "ImageURL", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override FaceMakeupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return FaceMakeupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
