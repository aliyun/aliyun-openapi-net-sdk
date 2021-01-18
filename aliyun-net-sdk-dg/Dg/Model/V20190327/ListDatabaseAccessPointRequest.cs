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
using Aliyun.Acs.dg.Transform;
using Aliyun.Acs.dg.Transform.V20190327;

namespace Aliyun.Acs.dg.Model.V20190327
{
    public class ListDatabaseAccessPointRequest : RpcAcsRequest<ListDatabaseAccessPointResponse>
    {
        public ListDatabaseAccessPointRequest()
            : base("dg", "2019-03-27", "ListDatabaseAccessPoint", "dg", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dg.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dg.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string searchKey;

		private string pageNumber;

		private string pageSize;

		private string host;

		private string dbInstanceId;

		private string gatewayId;

		private int? port;

		private string vpcId;

		public string SearchKey
		{
			get
			{
				return searchKey;
			}
			set	
			{
				searchKey = value;
				DictionaryUtil.Add(BodyParameters, "SearchKey", value);
			}
		}

		public string PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value);
			}
		}

		public string PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value);
			}
		}

		public string Host
		{
			get
			{
				return host;
			}
			set	
			{
				host = value;
				DictionaryUtil.Add(BodyParameters, "Host", value);
			}
		}

		public string DbInstanceId
		{
			get
			{
				return dbInstanceId;
			}
			set	
			{
				dbInstanceId = value;
				DictionaryUtil.Add(BodyParameters, "DbInstanceId", value);
			}
		}

		public string GatewayId
		{
			get
			{
				return gatewayId;
			}
			set	
			{
				gatewayId = value;
				DictionaryUtil.Add(BodyParameters, "GatewayId", value);
			}
		}

		public int? Port
		{
			get
			{
				return port;
			}
			set	
			{
				port = value;
				DictionaryUtil.Add(BodyParameters, "Port", value.ToString());
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(BodyParameters, "VpcId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListDatabaseAccessPointResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListDatabaseAccessPointResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
