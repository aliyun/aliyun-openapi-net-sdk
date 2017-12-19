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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.TeslaMaxCompute.Transform;
using Aliyun.Acs.TeslaMaxCompute.Transform.V20171130;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaMaxCompute.Model.V20171130
{
    public class GetClusterInfoRequest : RpcAcsRequest<GetClusterInfoResponse>
    {
        public GetClusterInfoRequest()
            : base("TeslaMaxCompute", "2017-11-30", "GetClusterInfo")
        {
        }

		private string cluster;

		private int? pageSize;

		private int? pageNum;

		private string status;

		public string Cluster
		{
			get
			{
				return cluster;
			}
			set	
			{
				cluster = value;
				DictionaryUtil.Add(QueryParameters, "Cluster", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetClusterInfoResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return GetClusterInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}