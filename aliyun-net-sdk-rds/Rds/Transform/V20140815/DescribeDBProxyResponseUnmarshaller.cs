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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBProxyResponseUnmarshaller
    {
        public static DescribeDBProxyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBProxyResponse describeDBProxyResponse = new DescribeDBProxyResponse();

			describeDBProxyResponse.HttpResponse = _ctx.HttpResponse;
			describeDBProxyResponse.RequestId = _ctx.StringValue("DescribeDBProxy.RequestId");
			describeDBProxyResponse.DBProxyServiceStatus = _ctx.StringValue("DescribeDBProxy.DBProxyServiceStatus");
			describeDBProxyResponse.DBProxyInstanceType = _ctx.StringValue("DescribeDBProxy.DBProxyInstanceType");
			describeDBProxyResponse.DBProxyInstanceNum = _ctx.IntegerValue("DescribeDBProxy.DBProxyInstanceNum");
			describeDBProxyResponse.DBProxyInstanceStatus = _ctx.StringValue("DescribeDBProxy.DBProxyInstanceStatus");
			describeDBProxyResponse.DBProxyInstanceCurrentMinorVersion = _ctx.StringValue("DescribeDBProxy.DBProxyInstanceCurrentMinorVersion");
			describeDBProxyResponse.DBProxyInstanceLatestMinorVersion = _ctx.StringValue("DescribeDBProxy.DBProxyInstanceLatestMinorVersion");
			describeDBProxyResponse.DBProxyInstanceName = _ctx.StringValue("DescribeDBProxy.DBProxyInstanceName");

			List<DescribeDBProxyResponse.DescribeDBProxy_DBProxyConnectStringItemsItem> describeDBProxyResponse_dBProxyConnectStringItems = new List<DescribeDBProxyResponse.DescribeDBProxy_DBProxyConnectStringItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBProxy.DBProxyConnectStringItems.Length"); i++) {
				DescribeDBProxyResponse.DescribeDBProxy_DBProxyConnectStringItemsItem dBProxyConnectStringItemsItem = new DescribeDBProxyResponse.DescribeDBProxy_DBProxyConnectStringItemsItem();
				dBProxyConnectStringItemsItem.DBProxyEndpointId = _ctx.StringValue("DescribeDBProxy.DBProxyConnectStringItems["+ i +"].DBProxyEndpointId");
				dBProxyConnectStringItemsItem.DBProxyConnectString = _ctx.StringValue("DescribeDBProxy.DBProxyConnectStringItems["+ i +"].DBProxyConnectString");
				dBProxyConnectStringItemsItem.DBProxyConnectStringPort = _ctx.StringValue("DescribeDBProxy.DBProxyConnectStringItems["+ i +"].DBProxyConnectStringPort");
				dBProxyConnectStringItemsItem.DBProxyConnectStringNetType = _ctx.StringValue("DescribeDBProxy.DBProxyConnectStringItems["+ i +"].DBProxyConnectStringNetType");
				dBProxyConnectStringItemsItem.DBProxyVpcInstanceId = _ctx.StringValue("DescribeDBProxy.DBProxyConnectStringItems["+ i +"].DBProxyVpcInstanceId");
				dBProxyConnectStringItemsItem.DBProxyEndpointName = _ctx.StringValue("DescribeDBProxy.DBProxyConnectStringItems["+ i +"].DBProxyEndpointName");
				dBProxyConnectStringItemsItem.DBProxyConnectStringNetWorkType = _ctx.StringValue("DescribeDBProxy.DBProxyConnectStringItems["+ i +"].DBProxyConnectStringNetWorkType");

				describeDBProxyResponse_dBProxyConnectStringItems.Add(dBProxyConnectStringItemsItem);
			}
			describeDBProxyResponse.DBProxyConnectStringItems = describeDBProxyResponse_dBProxyConnectStringItems;

			List<DescribeDBProxyResponse.DescribeDBProxy_DbProxyEndpointItemsItem> describeDBProxyResponse_dbProxyEndpointItems = new List<DescribeDBProxyResponse.DescribeDBProxy_DbProxyEndpointItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeDBProxy.DbProxyEndpointItems.Length"); i++) {
				DescribeDBProxyResponse.DescribeDBProxy_DbProxyEndpointItemsItem dbProxyEndpointItemsItem = new DescribeDBProxyResponse.DescribeDBProxy_DbProxyEndpointItemsItem();
				dbProxyEndpointItemsItem.DbProxyEndpointName = _ctx.StringValue("DescribeDBProxy.DbProxyEndpointItems["+ i +"].DbProxyEndpointName");
				dbProxyEndpointItemsItem.DbProxyEndpointType = _ctx.StringValue("DescribeDBProxy.DbProxyEndpointItems["+ i +"].DbProxyEndpointType");
				dbProxyEndpointItemsItem.DbProxyReadWriteMode = _ctx.StringValue("DescribeDBProxy.DbProxyEndpointItems["+ i +"].DbProxyReadWriteMode");
				dbProxyEndpointItemsItem.DbProxyEndpointAliases = _ctx.StringValue("DescribeDBProxy.DbProxyEndpointItems["+ i +"].DbProxyEndpointAliases");

				describeDBProxyResponse_dbProxyEndpointItems.Add(dbProxyEndpointItemsItem);
			}
			describeDBProxyResponse.DbProxyEndpointItems = describeDBProxyResponse_dbProxyEndpointItems;
        
			return describeDBProxyResponse;
        }
    }
}
