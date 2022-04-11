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
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class RefreshMediaPlayUrlsRequest : RpcAcsRequest<RefreshMediaPlayUrlsResponse>
    {
        public RefreshMediaPlayUrlsRequest()
            : base("vod", "2017-03-21", "RefreshMediaPlayUrls", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vod.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string formats;

		private string userData;

		private string mediaIds;

		private string definitions;

		private string streamType;

		private string taskType;

		private bool? sliceFlag;

		private string resultType;

		private int? sliceCount;

		public string Formats
		{
			get
			{
				return formats;
			}
			set	
			{
				formats = value;
				DictionaryUtil.Add(QueryParameters, "Formats", value);
			}
		}

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

		public string MediaIds
		{
			get
			{
				return mediaIds;
			}
			set	
			{
				mediaIds = value;
				DictionaryUtil.Add(QueryParameters, "MediaIds", value);
			}
		}

		public string Definitions
		{
			get
			{
				return definitions;
			}
			set	
			{
				definitions = value;
				DictionaryUtil.Add(QueryParameters, "Definitions", value);
			}
		}

		public string StreamType
		{
			get
			{
				return streamType;
			}
			set	
			{
				streamType = value;
				DictionaryUtil.Add(QueryParameters, "StreamType", value);
			}
		}

		public string TaskType
		{
			get
			{
				return taskType;
			}
			set	
			{
				taskType = value;
				DictionaryUtil.Add(QueryParameters, "TaskType", value);
			}
		}

		public bool? SliceFlag
		{
			get
			{
				return sliceFlag;
			}
			set	
			{
				sliceFlag = value;
				DictionaryUtil.Add(QueryParameters, "SliceFlag", value.ToString());
			}
		}

		public string ResultType
		{
			get
			{
				return resultType;
			}
			set	
			{
				resultType = value;
				DictionaryUtil.Add(QueryParameters, "ResultType", value);
			}
		}

		public int? SliceCount
		{
			get
			{
				return sliceCount;
			}
			set	
			{
				sliceCount = value;
				DictionaryUtil.Add(QueryParameters, "SliceCount", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RefreshMediaPlayUrlsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RefreshMediaPlayUrlsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
