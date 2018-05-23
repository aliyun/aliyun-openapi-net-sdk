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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Drds.Model.V20171016;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Drds.Transform.V20171016
{
    public class DescribeShardDbConnectionInfoResponseUnmarshaller
    {
        public static DescribeShardDbConnectionInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeShardDbConnectionInfoResponse describeShardDbConnectionInfoResponse = new DescribeShardDbConnectionInfoResponse();

			describeShardDbConnectionInfoResponse.HttpResponse = context.HttpResponse;
			describeShardDbConnectionInfoResponse.RequestId = context.StringValue("DescribeShardDbConnectionInfo.RequestId");
			describeShardDbConnectionInfoResponse.Success = context.BooleanValue("DescribeShardDbConnectionInfo.Success");

			DescribeShardDbConnectionInfoResponse.DescribeShardDbConnectionInfo_ConnectionInfo connectionInfo = new DescribeShardDbConnectionInfoResponse.DescribeShardDbConnectionInfo_ConnectionInfo();
			connectionInfo.InstanceName = context.StringValue("DescribeShardDbConnectionInfo.ConnectionInfo.InstanceName");
			connectionInfo.InstanceUrl = context.StringValue("DescribeShardDbConnectionInfo.ConnectionInfo.InstanceUrl");
			connectionInfo.SubDbName = context.StringValue("DescribeShardDbConnectionInfo.ConnectionInfo.SubDbName");
			connectionInfo.DbStatus = context.StringValue("DescribeShardDbConnectionInfo.ConnectionInfo.DbStatus");
			connectionInfo.DbType = context.StringValue("DescribeShardDbConnectionInfo.ConnectionInfo.DbType");
			connectionInfo.MinPoolSize = context.IntegerValue("DescribeShardDbConnectionInfo.ConnectionInfo.MinPoolSize");
			connectionInfo.MaxPoolSize = context.IntegerValue("DescribeShardDbConnectionInfo.ConnectionInfo.MaxPoolSize");
			connectionInfo.IdleTimeOut = context.IntegerValue("DescribeShardDbConnectionInfo.ConnectionInfo.IdleTimeOut");
			connectionInfo.BlockingTimeout = context.IntegerValue("DescribeShardDbConnectionInfo.ConnectionInfo.BlockingTimeout");
			connectionInfo.ConnectionProperties = context.StringValue("DescribeShardDbConnectionInfo.ConnectionInfo.ConnectionProperties");
			connectionInfo.PreparedStatementCacheSize = context.IntegerValue("DescribeShardDbConnectionInfo.ConnectionInfo.PreparedStatementCacheSize");
			connectionInfo.UserName = context.StringValue("DescribeShardDbConnectionInfo.ConnectionInfo.UserName");
			describeShardDbConnectionInfoResponse.ConnectionInfo = connectionInfo;
        
			return describeShardDbConnectionInfoResponse;
        }
    }
}