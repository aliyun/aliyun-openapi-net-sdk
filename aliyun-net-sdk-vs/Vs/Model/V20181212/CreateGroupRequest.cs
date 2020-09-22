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
using Aliyun.Acs.vs.Transform;
using Aliyun.Acs.vs.Transform.V20181212;

namespace Aliyun.Acs.vs.Model.V20181212
{
    public class CreateGroupRequest : RpcAcsRequest<CreateGroupResponse>
    {
        public CreateGroupRequest()
            : base("vs", "2018-12-12", "CreateGroup", "vs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? captureVideo;

		private string description;

		private string captureOssPath;

		private string pushDomain;

		private int? captureImage;

		private string app;

		private string playDomain;

		private string outProtocol;

		private int? captureInterval;

		private long? ownerId;

		private string inProtocol;

		private bool? lazyPull;

		private string name;

		private string callback;

		private string region;

		private string captureOssBucket;

		public int? CaptureVideo
		{
			get
			{
				return captureVideo;
			}
			set	
			{
				captureVideo = value;
				DictionaryUtil.Add(QueryParameters, "CaptureVideo", value.ToString());
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string CaptureOssPath
		{
			get
			{
				return captureOssPath;
			}
			set	
			{
				captureOssPath = value;
				DictionaryUtil.Add(QueryParameters, "CaptureOssPath", value);
			}
		}

		public string PushDomain
		{
			get
			{
				return pushDomain;
			}
			set	
			{
				pushDomain = value;
				DictionaryUtil.Add(QueryParameters, "PushDomain", value);
			}
		}

		public int? CaptureImage
		{
			get
			{
				return captureImage;
			}
			set	
			{
				captureImage = value;
				DictionaryUtil.Add(QueryParameters, "CaptureImage", value.ToString());
			}
		}

		public string App
		{
			get
			{
				return app;
			}
			set	
			{
				app = value;
				DictionaryUtil.Add(QueryParameters, "App", value);
			}
		}

		public string PlayDomain
		{
			get
			{
				return playDomain;
			}
			set	
			{
				playDomain = value;
				DictionaryUtil.Add(QueryParameters, "PlayDomain", value);
			}
		}

		public string OutProtocol
		{
			get
			{
				return outProtocol;
			}
			set	
			{
				outProtocol = value;
				DictionaryUtil.Add(QueryParameters, "OutProtocol", value);
			}
		}

		public int? CaptureInterval
		{
			get
			{
				return captureInterval;
			}
			set	
			{
				captureInterval = value;
				DictionaryUtil.Add(QueryParameters, "CaptureInterval", value.ToString());
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

		public string InProtocol
		{
			get
			{
				return inProtocol;
			}
			set	
			{
				inProtocol = value;
				DictionaryUtil.Add(QueryParameters, "InProtocol", value);
			}
		}

		public bool? LazyPull
		{
			get
			{
				return lazyPull;
			}
			set	
			{
				lazyPull = value;
				DictionaryUtil.Add(QueryParameters, "LazyPull", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string Callback
		{
			get
			{
				return callback;
			}
			set	
			{
				callback = value;
				DictionaryUtil.Add(QueryParameters, "Callback", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		public string CaptureOssBucket
		{
			get
			{
				return captureOssBucket;
			}
			set	
			{
				captureOssBucket = value;
				DictionaryUtil.Add(QueryParameters, "CaptureOssBucket", value);
			}
		}

        public override CreateGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
