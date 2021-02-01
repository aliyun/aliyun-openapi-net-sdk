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
using Aliyun.Acs.facebody.Transform.V20200910;

namespace Aliyun.Acs.facebody.Model.V20200910
{
    public class ExecuteServerSideVerificationRequest : RoaAcsRequest<ExecuteServerSideVerificationResponse>
    {
        public ExecuteServerSideVerificationRequest()
            : base("facebody", "2020-09-10", "ExecuteServerSideVerification", "facebody", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.facebody.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.facebody.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/viapi/thirdparty/realperson/execServerSideVerification";
			Method = MethodType.POST;
        }

		private string facialPictureData;

		private string sceneType;

		private string certificateNumber;

		private string certificateName;

		private string facialPictureUrl;

		public string FacialPictureData
		{
			get
			{
				return facialPictureData;
			}
			set	
			{
				facialPictureData = value;
				DictionaryUtil.Add(BodyParameters, "facialPictureData", value);
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
				DictionaryUtil.Add(BodyParameters, "sceneType", value);
			}
		}

		public string CertificateNumber
		{
			get
			{
				return certificateNumber;
			}
			set	
			{
				certificateNumber = value;
				DictionaryUtil.Add(BodyParameters, "certificateNumber", value);
			}
		}

		public string CertificateName
		{
			get
			{
				return certificateName;
			}
			set	
			{
				certificateName = value;
				DictionaryUtil.Add(BodyParameters, "certificateName", value);
			}
		}

		public string FacialPictureUrl
		{
			get
			{
				return facialPictureUrl;
			}
			set	
			{
				facialPictureUrl = value;
				DictionaryUtil.Add(BodyParameters, "facialPictureUrl", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ExecuteServerSideVerificationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ExecuteServerSideVerificationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
