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
    public class DescribeLiveDetectPornDataRequest : RpcAcsRequest<DescribeLiveDetectPornDataResponse>
    {
        public DescribeLiveDetectPornDataRequest()
            : base("live", "2016-11-01", "DescribeLiveDetectPornData", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string fee;

		private string startTime;

		private string scene;

		private string stream;

		private string splitBy;

		private string app;

		private string domainName;

		private string endTime;

		private long? ownerId;

		private string region;

		public string Fee
		{
			get
			{
				return fee;
			}
			set	
			{
				fee = value;
				DictionaryUtil.Add(QueryParameters, "Fee", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string Scene
		{
			get
			{
				return scene;
			}
			set	
			{
				scene = value;
				DictionaryUtil.Add(QueryParameters, "Scene", value);
			}
		}

		public string Stream
		{
			get
			{
				return stream;
			}
			set	
			{
				stream = value;
				DictionaryUtil.Add(QueryParameters, "Stream", value);
			}
		}

		public string SplitBy
		{
			get
			{
				return splitBy;
			}
			set	
			{
				splitBy = value;
				DictionaryUtil.Add(QueryParameters, "SplitBy", value);
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

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
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

        public override DescribeLiveDetectPornDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeLiveDetectPornDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
