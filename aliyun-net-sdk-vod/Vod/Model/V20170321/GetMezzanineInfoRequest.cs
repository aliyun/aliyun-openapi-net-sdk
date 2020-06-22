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
    public class GetMezzanineInfoRequest : RpcAcsRequest<GetMezzanineInfoResponse>
    {
        public GetMezzanineInfoRequest()
            : base("vod", "2017-03-21", "GetMezzanineInfo", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string outputType;

		private long? authTimeout;

		private string resourceOwnerAccount;

		private string videoId;

		private long? ownerId;

		private bool? previewSegment;

		private string additionType;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string OutputType
		{
			get
			{
				return outputType;
			}
			set	
			{
				outputType = value;
				DictionaryUtil.Add(QueryParameters, "OutputType", value);
			}
		}

		public long? AuthTimeout
		{
			get
			{
				return authTimeout;
			}
			set	
			{
				authTimeout = value;
				DictionaryUtil.Add(QueryParameters, "AuthTimeout", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
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
				DictionaryUtil.Add(QueryParameters, "VideoId", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public bool? PreviewSegment
		{
			get
			{
				return previewSegment;
			}
			set	
			{
				previewSegment = value;
				DictionaryUtil.Add(QueryParameters, "PreviewSegment", value.ToString());
			}
		}

		public string AdditionType
		{
			get
			{
				return additionType;
			}
			set	
			{
				additionType = value;
				DictionaryUtil.Add(QueryParameters, "AdditionType", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetMezzanineInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetMezzanineInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
