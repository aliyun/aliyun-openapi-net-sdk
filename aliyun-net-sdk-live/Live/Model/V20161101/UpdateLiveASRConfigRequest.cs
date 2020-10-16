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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class UpdateLiveASRConfigRequest : RpcAcsRequest<UpdateLiveASRConfigResponse>
    {
        public UpdateLiveASRConfigRequest()
            : base("live", "2016-11-01", "UpdateLiveASRConfig", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string appName;

		private string mnsTopic;

		private string streamName;

		private int? period;

		private string domainName;

		private string httpCallbackURL;

		private long? ownerId;

		private string mnsRegion;

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		public string MnsTopic
		{
			get
			{
				return mnsTopic;
			}
			set	
			{
				mnsTopic = value;
				DictionaryUtil.Add(QueryParameters, "MnsTopic", value);
			}
		}

		public string StreamName
		{
			get
			{
				return streamName;
			}
			set	
			{
				streamName = value;
				DictionaryUtil.Add(QueryParameters, "StreamName", value);
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string HttpCallbackURL
		{
			get
			{
				return httpCallbackURL;
			}
			set	
			{
				httpCallbackURL = value;
				DictionaryUtil.Add(QueryParameters, "HttpCallbackURL", value);
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

		public string MnsRegion
		{
			get
			{
				return mnsRegion;
			}
			set	
			{
				mnsRegion = value;
				DictionaryUtil.Add(QueryParameters, "MnsRegion", value);
			}
		}

        public override UpdateLiveASRConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateLiveASRConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
