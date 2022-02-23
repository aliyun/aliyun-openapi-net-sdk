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
    public class UploadIdentifyRecordRequest : RpcAcsRequest<UploadIdentifyRecordResponse>
    {
        public UploadIdentifyRecordRequest()
            : base("Cloudauth-console", "2019-04-03", "UploadIdentifyRecord", "cloudauth-console", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cloudauth_console.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cloudauth_console.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string ext;

		private string identifyingImageUrl;

		private string identifyingImageBase64;

		private string deviceSecret;

		private string productKey;

		private string userId;

		private string iotId;

		private string deviceName;

		private long? identifyingTime;

		private string projectId;

		private string userName;

		public string Ext
		{
			get
			{
				return ext;
			}
			set	
			{
				ext = value;
				DictionaryUtil.Add(QueryParameters, "Ext", value);
			}
		}

		public string IdentifyingImageUrl
		{
			get
			{
				return identifyingImageUrl;
			}
			set	
			{
				identifyingImageUrl = value;
				DictionaryUtil.Add(QueryParameters, "IdentifyingImageUrl", value);
			}
		}

		public string IdentifyingImageBase64
		{
			get
			{
				return identifyingImageBase64;
			}
			set	
			{
				identifyingImageBase64 = value;
				DictionaryUtil.Add(BodyParameters, "IdentifyingImageBase64", value);
			}
		}

		public string DeviceSecret
		{
			get
			{
				return deviceSecret;
			}
			set	
			{
				deviceSecret = value;
				DictionaryUtil.Add(QueryParameters, "DeviceSecret", value);
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
			}
		}

		public string IotId
		{
			get
			{
				return iotId;
			}
			set	
			{
				iotId = value;
				DictionaryUtil.Add(QueryParameters, "IotId", value);
			}
		}

		public string DeviceName
		{
			get
			{
				return deviceName;
			}
			set	
			{
				deviceName = value;
				DictionaryUtil.Add(QueryParameters, "DeviceName", value);
			}
		}

		public long? IdentifyingTime
		{
			get
			{
				return identifyingTime;
			}
			set	
			{
				identifyingTime = value;
				DictionaryUtil.Add(QueryParameters, "IdentifyingTime", value.ToString());
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

		public string UserName
		{
			get
			{
				return userName;
			}
			set	
			{
				userName = value;
				DictionaryUtil.Add(QueryParameters, "UserName", value);
			}
		}

        public override UploadIdentifyRecordResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UploadIdentifyRecordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
