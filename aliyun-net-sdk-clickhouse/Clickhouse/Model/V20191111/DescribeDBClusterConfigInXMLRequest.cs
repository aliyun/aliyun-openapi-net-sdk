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
using Aliyun.Acs.clickhouse.Transform;
using Aliyun.Acs.clickhouse.Transform.V20191111;

namespace Aliyun.Acs.clickhouse.Model.V20191111
{
    public class DescribeDBClusterConfigInXMLRequest : RpcAcsRequest<DescribeDBClusterConfigInXMLResponse>
    {
        public DescribeDBClusterConfigInXMLRequest()
            : base("clickhouse", "2019-11-11", "DescribeDBClusterConfigInXML", "service", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.clickhouse.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.clickhouse.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dBClusterId;

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeDBClusterConfigInXMLResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDBClusterConfigInXMLResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
