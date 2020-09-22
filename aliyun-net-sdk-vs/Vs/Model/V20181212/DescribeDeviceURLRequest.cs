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
    public class DescribeDeviceURLRequest : RpcAcsRequest<DescribeDeviceURLResponse>
    {
        public DescribeDeviceURLRequest()
            : base("vs", "2018-12-12", "DescribeDeviceURL", "vs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? auth;

		private string type;

		private string mode;

		private string stream;

		private string id;

		private string outProtocol;

		private long? ownerId;

		private long? expire;

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

		public string Mode
		{
			get
			{
				return mode;
			}
			set	
			{
				mode = value;
				DictionaryUtil.Add(QueryParameters, "Mode", value);
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

        public override DescribeDeviceURLResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDeviceURLResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
