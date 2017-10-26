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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CloudPhoto.Transform;
using Aliyun.Acs.CloudPhoto.Transform.V20170711;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Model.V20170711
{
    public class CreatePhotoRequest : RpcAcsRequest<CreatePhotoResponse>
    {
        public CreatePhotoRequest()
            : base("CloudPhoto", "2017-07-11", "CreatePhoto", "cloudphoto", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private string photoTitle;

		private string libraryId;

		private long? shareExpireTime;

		private string storeName;

		private string uploadType;

		private string remark;

		private string sessionId;

		private string staging;

		private string fileId;

		public string PhotoTitle
		{
			get
			{
				return photoTitle;
			}
			set	
			{
				photoTitle = value;
				DictionaryUtil.Add(QueryParameters, "PhotoTitle", value);
			}
		}

		public string LibraryId
		{
			get
			{
				return libraryId;
			}
			set	
			{
				libraryId = value;
				DictionaryUtil.Add(QueryParameters, "LibraryId", value);
			}
		}

		public long? ShareExpireTime
		{
			get
			{
				return shareExpireTime;
			}
			set	
			{
				shareExpireTime = value;
				DictionaryUtil.Add(QueryParameters, "ShareExpireTime", value.ToString());
			}
		}

		public string StoreName
		{
			get
			{
				return storeName;
			}
			set	
			{
				storeName = value;
				DictionaryUtil.Add(QueryParameters, "StoreName", value);
			}
		}

		public string UploadType
		{
			get
			{
				return uploadType;
			}
			set	
			{
				uploadType = value;
				DictionaryUtil.Add(QueryParameters, "UploadType", value);
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

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

		public string Staging
		{
			get
			{
				return staging;
			}
			set	
			{
				staging = value;
				DictionaryUtil.Add(QueryParameters, "Staging", value);
			}
		}

		public string FileId
		{
			get
			{
				return fileId;
			}
			set	
			{
				fileId = value;
				DictionaryUtil.Add(QueryParameters, "FileId", value);
			}
		}

        public override CreatePhotoResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreatePhotoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}