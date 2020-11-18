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
using Aliyun.Acs.Green.Transform;
using Aliyun.Acs.Green.Transform.V20170823;

namespace Aliyun.Acs.Green.Model.V20170823
{
    public class UpdateBizTypeTextLibRequest : RpcAcsRequest<UpdateBizTypeTextLibResponse>
    {
        public UpdateBizTypeTextLibRequest()
            : base("Green", "2017-08-23", "UpdateBizTypeTextLib", "green", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Green.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string scene;

		private string white;

		private string review;

		private string ignore;

		private string bizTypeName;

		private string black;

		private string resourceType;

		public string Scene
		{
			get
			{
				return scene;
			}
			set	
			{
				scene = value;
				DictionaryUtil.Add(QueryParameters, "Scene", value);
			}
		}

		public string White
		{
			get
			{
				return white;
			}
			set	
			{
				white = value;
				DictionaryUtil.Add(QueryParameters, "White", value);
			}
		}

		public string Review
		{
			get
			{
				return review;
			}
			set	
			{
				review = value;
				DictionaryUtil.Add(QueryParameters, "Review", value);
			}
		}

		public string Ignore
		{
			get
			{
				return ignore;
			}
			set	
			{
				ignore = value;
				DictionaryUtil.Add(QueryParameters, "Ignore", value);
			}
		}

		public string BizTypeName
		{
			get
			{
				return bizTypeName;
			}
			set	
			{
				bizTypeName = value;
				DictionaryUtil.Add(QueryParameters, "BizTypeName", value);
			}
		}

		public string Black
		{
			get
			{
				return black;
			}
			set	
			{
				black = value;
				DictionaryUtil.Add(QueryParameters, "Black", value);
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
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateBizTypeTextLibResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateBizTypeTextLibResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
