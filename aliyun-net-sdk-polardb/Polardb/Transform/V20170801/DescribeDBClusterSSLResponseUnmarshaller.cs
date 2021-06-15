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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeDBClusterSSLResponseUnmarshaller
    {
        public static DescribeDBClusterSSLResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBClusterSSLResponse describeDBClusterSSLResponse = new DescribeDBClusterSSLResponse();

			describeDBClusterSSLResponse.HttpResponse = _ctx.HttpResponse;
			describeDBClusterSSLResponse.RequestId = _ctx.StringValue("DescribeDBClusterSSL.RequestId");
			describeDBClusterSSLResponse.SSLAutoRotate = _ctx.StringValue("DescribeDBClusterSSL.SSLAutoRotate");

			List<DescribeDBClusterSSLResponse.DescribeDBClusterSSL_Item> describeDBClusterSSLResponse_items = new List<DescribeDBClusterSSLResponse.DescribeDBClusterSSL_Item>();
			for (int i = 0; i < _ctx.Length("DescribeDBClusterSSL.Items.Length"); i++) {
				DescribeDBClusterSSLResponse.DescribeDBClusterSSL_Item item = new DescribeDBClusterSSLResponse.DescribeDBClusterSSL_Item();
				item.SSLExpireTime = _ctx.StringValue("DescribeDBClusterSSL.Items["+ i +"].SSLExpireTime");
				item.SSLEnabled = _ctx.StringValue("DescribeDBClusterSSL.Items["+ i +"].SSLEnabled");
				item.SSLConnectionString = _ctx.StringValue("DescribeDBClusterSSL.Items["+ i +"].SSLConnectionString");
				item.DBEndpointId = _ctx.StringValue("DescribeDBClusterSSL.Items["+ i +"].DBEndpointId");

				describeDBClusterSSLResponse_items.Add(item);
			}
			describeDBClusterSSLResponse.Items = describeDBClusterSSLResponse_items;
        
			return describeDBClusterSSLResponse;
        }
    }
}
