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
    public class GetFramedPhotoUrlsRequest : RpcAcsRequest<GetFramedPhotoUrlsResponse>
    {
        public GetFramedPhotoUrlsRequest()
            : base("CloudPhoto", "2017-07-11", "GetFramedPhotoUrls", "cloudphoto", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private string frameId;

		private string libraryId;

		private List<long?> photoIds;

		private string storeName;

		public string FrameId
		{
			get
			{
				return frameId;
			}
			set	
			{
				frameId = value;
				DictionaryUtil.Add(QueryParameters, "FrameId", value);
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

		public List<long?> PhotoIds
		{
			get
			{
				return photoIds;
			}

			set
			{
				photoIds = value;
				for (int i = 0; i < photoIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PhotoId." + (i + 1) , photoIds[i]);
				}
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

        public override GetFramedPhotoUrlsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return GetFramedPhotoUrlsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}