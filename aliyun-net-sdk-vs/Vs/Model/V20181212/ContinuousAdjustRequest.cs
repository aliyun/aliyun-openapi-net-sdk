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
using Aliyun.Acs.vs;
using Aliyun.Acs.vs.Transform;
using Aliyun.Acs.vs.Transform.V20181212;

namespace Aliyun.Acs.vs.Model.V20181212
{
    public class ContinuousAdjustRequest : RpcAcsRequest<ContinuousAdjustResponse>
    {
        public ContinuousAdjustRequest()
            : base("vs", "2018-12-12", "ContinuousAdjust")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string focus;

		private string subProtocol;

		private string id;

		private string iris;

		private long? ownerId;

		public string Focus
		{
			get
			{
				return focus;
			}
			set	
			{
				focus = value;
				DictionaryUtil.Add(QueryParameters, "Focus", value);
			}
		}

		public string SubProtocol
		{
			get
			{
				return subProtocol;
			}
			set	
			{
				subProtocol = value;
				DictionaryUtil.Add(QueryParameters, "SubProtocol", value);
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

		public string Iris
		{
			get
			{
				return iris;
			}
			set	
			{
				iris = value;
				DictionaryUtil.Add(QueryParameters, "Iris", value);
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

        public override ContinuousAdjustResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ContinuousAdjustResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
