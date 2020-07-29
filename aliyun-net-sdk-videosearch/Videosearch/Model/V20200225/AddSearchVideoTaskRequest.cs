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
using Aliyun.Acs.videosearch;
using Aliyun.Acs.videosearch.Transform;
using Aliyun.Acs.videosearch.Transform.V20200225;

namespace Aliyun.Acs.videosearch.Model.V20200225
{
    public class AddSearchVideoTaskRequest : RpcAcsRequest<AddSearchVideoTaskResponse>
    {
        public AddSearchVideoTaskRequest()
            : base("videosearch", "2020-02-25", "AddSearchVideoTask")
        {
			Method = MethodType.POST;
        }

		private string clientToken;

		private int? storageType;

		private string videoTags;

		private int? returnVideoNumber;

		private string videoId;

		private float? replaceStorageThreshold;

		private string instanceId;

		private string videoUrl;

		private string queryTags;

		private string callbackUrl;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public int? StorageType
		{
			get
			{
				return storageType;
			}
			set	
			{
				storageType = value;
				DictionaryUtil.Add(BodyParameters, "StorageType", value.ToString());
			}
		}

		public string VideoTags
		{
			get
			{
				return videoTags;
			}
			set	
			{
				videoTags = value;
				DictionaryUtil.Add(BodyParameters, "VideoTags", value);
			}
		}

		public int? ReturnVideoNumber
		{
			get
			{
				return returnVideoNumber;
			}
			set	
			{
				returnVideoNumber = value;
				DictionaryUtil.Add(BodyParameters, "ReturnVideoNumber", value.ToString());
			}
		}

		public string VideoId
		{
			get
			{
				return videoId;
			}
			set	
			{
				videoId = value;
				DictionaryUtil.Add(BodyParameters, "VideoId", value);
			}
		}

		public float? ReplaceStorageThreshold
		{
			get
			{
				return replaceStorageThreshold;
			}
			set	
			{
				replaceStorageThreshold = value;
				DictionaryUtil.Add(BodyParameters, "ReplaceStorageThreshold", value.ToString());
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(BodyParameters, "InstanceId", value);
			}
		}

		public string VideoUrl
		{
			get
			{
				return videoUrl;
			}
			set	
			{
				videoUrl = value;
				DictionaryUtil.Add(BodyParameters, "VideoUrl", value);
			}
		}

		public string QueryTags
		{
			get
			{
				return queryTags;
			}
			set	
			{
				queryTags = value;
				DictionaryUtil.Add(BodyParameters, "QueryTags", value);
			}
		}

		public string CallbackUrl
		{
			get
			{
				return callbackUrl;
			}
			set	
			{
				callbackUrl = value;
				DictionaryUtil.Add(BodyParameters, "CallbackUrl", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddSearchVideoTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddSearchVideoTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
