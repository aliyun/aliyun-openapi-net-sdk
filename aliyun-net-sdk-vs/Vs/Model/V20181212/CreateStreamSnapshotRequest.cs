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
    public class CreateStreamSnapshotRequest : RpcAcsRequest<CreateStreamSnapshotResponse>
    {
        public CreateStreamSnapshotRequest()
            : base("vs", "2018-12-12", "CreateStreamSnapshot")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string id;

		private long? ownerId;

		private string location;

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

        public override CreateStreamSnapshotResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateStreamSnapshotResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
