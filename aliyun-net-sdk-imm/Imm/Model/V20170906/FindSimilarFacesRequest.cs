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
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class FindSimilarFacesRequest : RpcAcsRequest<FindSimilarFacesResponse>
    {
        public FindSimilarFacesRequest()
            : base("imm", "2017-09-06", "FindSimilarFaces", "imm", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string project;

		private float? minSimilarity;

		private string responseFormat;

		private int? limit;

		private string faceId;

		private string imageUri;

		private string setId;

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public float? MinSimilarity
		{
			get
			{
				return minSimilarity;
			}
			set	
			{
				minSimilarity = value;
				DictionaryUtil.Add(QueryParameters, "MinSimilarity", value.ToString());
			}
		}

		public string ResponseFormat
		{
			get
			{
				return responseFormat;
			}
			set	
			{
				responseFormat = value;
				DictionaryUtil.Add(QueryParameters, "ResponseFormat", value);
			}
		}

		public int? Limit
		{
			get
			{
				return limit;
			}
			set	
			{
				limit = value;
				DictionaryUtil.Add(QueryParameters, "Limit", value.ToString());
			}
		}

		public string FaceId
		{
			get
			{
				return faceId;
			}
			set	
			{
				faceId = value;
				DictionaryUtil.Add(QueryParameters, "FaceId", value);
			}
		}

		public string ImageUri
		{
			get
			{
				return imageUri;
			}
			set	
			{
				imageUri = value;
				DictionaryUtil.Add(QueryParameters, "ImageUri", value);
			}
		}

		public string SetId
		{
			get
			{
				return setId;
			}
			set	
			{
				setId = value;
				DictionaryUtil.Add(QueryParameters, "SetId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override FindSimilarFacesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return FindSimilarFacesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
