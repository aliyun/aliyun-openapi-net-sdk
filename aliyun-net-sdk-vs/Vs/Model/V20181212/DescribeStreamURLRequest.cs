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
    public class DescribeStreamURLRequest : RpcAcsRequest<DescribeStreamURLResponse>
    {
        public DescribeStreamURLRequest()
            : base("vs", "2018-12-12", "DescribeStreamURL", "vs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string authKey;

		private bool? auth;

		private long? startTime;

		private string type;

		private string outHostType;

		private string id;

		private string outProtocol;

		private string transcode;

		private long? endTime;

		private long? ownerId;

		private long? expire;

		private string location;

		public string AuthKey
		{
			get
			{
				return authKey;
			}
			set	
			{
				authKey = value;
				DictionaryUtil.Add(QueryParameters, "AuthKey", value);
			}
		}

		public bool? Auth
		{
			get
			{
				return auth;
			}
			set	
			{
				auth = value;
				DictionaryUtil.Add(QueryParameters, "Auth", value.ToString());
			}
		}

		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value.ToString());
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string OutHostType
		{
			get
			{
				return outHostType;
			}
			set	
			{
				outHostType = value;
				DictionaryUtil.Add(QueryParameters, "OutHostType", value);
			}
		}

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value);
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

		public string Transcode
		{
			get
			{
				return transcode;
			}
			set	
			{
				transcode = value;
				DictionaryUtil.Add(QueryParameters, "Transcode", value);
			}
		}

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
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

		public long? Expire
		{
			get
			{
				return expire;
			}
			set	
			{
				expire = value;
				DictionaryUtil.Add(QueryParameters, "Expire", value.ToString());
			}
		}

		public string Location
		{
			get
			{
				return location;
			}
			set	
			{
				location = value;
				DictionaryUtil.Add(QueryParameters, "Location", value);
			}
		}

        public override DescribeStreamURLResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeStreamURLResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
