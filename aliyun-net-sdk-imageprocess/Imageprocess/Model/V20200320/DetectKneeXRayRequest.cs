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
using Aliyun.Acs.imageprocess.Transform;
using Aliyun.Acs.imageprocess.Transform.V20200320;

namespace Aliyun.Acs.imageprocess.Model.V20200320
{
    public class DetectKneeXRayRequest : RpcAcsRequest<DetectKneeXRayResponse>
    {
        public DetectKneeXRayRequest()
            : base("imageprocess", "2020-03-20", "DetectKneeXRay", "imageprocess", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.imageprocess.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.imageprocess.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string orgName;

		private string dataFormat;

		private string url;

		private string orgId;

		public string OrgName
		{
			get
			{
				return orgName;
			}
			set	
			{
				orgName = value;
				DictionaryUtil.Add(BodyParameters, "OrgName", value);
			}
		}

		public string DataFormat
		{
			get
			{
				return dataFormat;
			}
			set	
			{
				dataFormat = value;
				DictionaryUtil.Add(BodyParameters, "DataFormat", value);
			}
		}

		public string Url
		{
			get
			{
				return url;
			}
			set	
			{
				url = value;
				DictionaryUtil.Add(BodyParameters, "Url", value);
			}
		}

		public string OrgId
		{
			get
			{
				return orgId;
			}
			set	
			{
				orgId = value;
				DictionaryUtil.Add(BodyParameters, "OrgId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DetectKneeXRayResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DetectKneeXRayResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
