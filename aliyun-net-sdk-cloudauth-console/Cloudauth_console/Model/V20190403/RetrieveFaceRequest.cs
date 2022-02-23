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
using Aliyun.Acs.Cloudauth_console.Transform;
using Aliyun.Acs.Cloudauth_console.Transform.V20190403;

namespace Aliyun.Acs.Cloudauth_console.Model.V20190403
{
    public class RetrieveFaceRequest : RpcAcsRequest<RetrieveFaceResponse>
    {
        public RetrieveFaceRequest()
            : base("Cloudauth-console", "2019-04-03", "RetrieveFace", "cloudauth-console", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth_console.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth_console.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string face64String;

		private string faceUrl;

		private string projectId;

		public string Face64String
		{
			get
			{
				return face64String;
			}
			set	
			{
				face64String = value;
				DictionaryUtil.Add(BodyParameters, "Face64String", value);
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
				DictionaryUtil.Add(QueryParameters, "FaceUrl", value);
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(QueryParameters, "ProjectId", value);
			}
		}

        public override RetrieveFaceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RetrieveFaceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
