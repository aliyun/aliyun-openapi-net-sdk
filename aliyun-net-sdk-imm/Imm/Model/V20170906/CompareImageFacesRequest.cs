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
    public class CompareImageFacesRequest : RpcAcsRequest<CompareImageFacesResponse>
    {
        public CompareImageFacesRequest()
            : base("imm", "2017-09-06", "CompareImageFaces", "imm", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imm.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string project;

		private string faceIdA;

		private string faceIdB;

		private string imageUriB;

		private string imageUriA;

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

		public string FaceIdA
		{
			get
			{
				return faceIdA;
			}
			set	
			{
				faceIdA = value;
				DictionaryUtil.Add(QueryParameters, "FaceIdA", value);
			}
		}

		public string FaceIdB
		{
			get
			{
				return faceIdB;
			}
			set	
			{
				faceIdB = value;
				DictionaryUtil.Add(QueryParameters, "FaceIdB", value);
			}
		}

		public string ImageUriB
		{
			get
			{
				return imageUriB;
			}
			set	
			{
				imageUriB = value;
				DictionaryUtil.Add(QueryParameters, "ImageUriB", value);
			}
		}

		public string ImageUriA
		{
			get
			{
				return imageUriA;
			}
			set	
			{
				imageUriA = value;
				DictionaryUtil.Add(QueryParameters, "ImageUriA", value);
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

        public override CompareImageFacesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CompareImageFacesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
