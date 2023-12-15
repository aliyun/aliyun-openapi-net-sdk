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
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class UploadMediaByURLRequest : RpcAcsRequest<UploadMediaByURLResponse>
    {
        public UploadMediaByURLRequest()
            : base("vod", "2017-03-21", "UploadMediaByURL", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sessionId;

		private string storageLocation;

		private string userData;

		private string workflowId;

		private string templateGroupId;

		private string uploadMetadatas;

		private string uploadURLs;

		private string appId;

		[JsonProperty(PropertyName = "SessionId")]
		public string SessionId
		{
			get
			{
				return sessionId;
			}
			set	
			{
				sessionId = value;
				DictionaryUtil.Add(QueryParameters, "SessionId", value);
			}
		}

		[JsonProperty(PropertyName = "StorageLocation")]
		public string StorageLocation
		{
			get
			{
				return storageLocation;
			}
			set	
			{
				storageLocation = value;
				DictionaryUtil.Add(QueryParameters, "StorageLocation", value);
			}
		}

		[JsonProperty(PropertyName = "UserData")]
		public string UserData
		{
			get
			{
				return userData;
			}
			set	
			{
				userData = value;
				DictionaryUtil.Add(QueryParameters, "UserData", value);
			}
		}

		[JsonProperty(PropertyName = "WorkflowId")]
		public string WorkflowId
		{
			get
			{
				return workflowId;
			}
			set	
			{
				workflowId = value;
				DictionaryUtil.Add(QueryParameters, "WorkflowId", value);
			}
		}

		[JsonProperty(PropertyName = "TemplateGroupId")]
		public string TemplateGroupId
		{
			get
			{
				return templateGroupId;
			}
			set	
			{
				templateGroupId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateGroupId", value);
			}
		}

		[JsonProperty(PropertyName = "UploadMetadatas")]
		public string UploadMetadatas
		{
			get
			{
				return uploadMetadatas;
			}
			set	
			{
				uploadMetadatas = value;
				DictionaryUtil.Add(QueryParameters, "UploadMetadatas", value);
			}
		}

		[JsonProperty(PropertyName = "UploadURLs")]
		public string UploadURLs
		{
			get
			{
				return uploadURLs;
			}
			set	
			{
				uploadURLs = value;
				DictionaryUtil.Add(QueryParameters, "UploadURLs", value);
			}
		}

		[JsonProperty(PropertyName = "AppId")]
		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UploadMediaByURLResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UploadMediaByURLResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
