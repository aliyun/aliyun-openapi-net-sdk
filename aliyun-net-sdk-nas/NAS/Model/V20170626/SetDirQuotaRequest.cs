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
using Aliyun.Acs.NAS.Transform;
using Aliyun.Acs.NAS.Transform.V20170626;

namespace Aliyun.Acs.NAS.Model.V20170626
{
    public class SetDirQuotaRequest : RpcAcsRequest<SetDirQuotaResponse>
    {
        public SetDirQuotaRequest()
            : base("NAS", "2017-06-26", "SetDirQuota", "nas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.NAS.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string quotaType;

		private string userId;

		private long? fileCountLimit;

		private string path;

		private long? sizeLimit;

		private string fileSystemId;

		private string userType;

		[JsonProperty(PropertyName = "QuotaType")]
		public string QuotaType
		{
			get
			{
				return quotaType;
			}
			set	
			{
				quotaType = value;
				DictionaryUtil.Add(QueryParameters, "QuotaType", value);
			}
		}

		[JsonProperty(PropertyName = "UserId")]
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

		[JsonProperty(PropertyName = "FileCountLimit")]
		public long? FileCountLimit
		{
			get
			{
				return fileCountLimit;
			}
			set	
			{
				fileCountLimit = value;
				DictionaryUtil.Add(QueryParameters, "FileCountLimit", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Path")]
		public string Path
		{
			get
			{
				return path;
			}
			set	
			{
				path = value;
				DictionaryUtil.Add(QueryParameters, "Path", value);
			}
		}

		[JsonProperty(PropertyName = "SizeLimit")]
		public long? SizeLimit
		{
			get
			{
				return sizeLimit;
			}
			set	
			{
				sizeLimit = value;
				DictionaryUtil.Add(QueryParameters, "SizeLimit", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "FileSystemId")]
		public string FileSystemId
		{
			get
			{
				return fileSystemId;
			}
			set	
			{
				fileSystemId = value;
				DictionaryUtil.Add(QueryParameters, "FileSystemId", value);
			}
		}

		[JsonProperty(PropertyName = "UserType")]
		public string UserType
		{
			get
			{
				return userType;
			}
			set	
			{
				userType = value;
				DictionaryUtil.Add(QueryParameters, "UserType", value);
			}
		}

        public override SetDirQuotaResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetDirQuotaResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
