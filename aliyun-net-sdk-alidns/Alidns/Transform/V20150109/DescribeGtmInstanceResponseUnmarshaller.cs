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
using Aliyun.Acs.Alidns.Model.V20150109;

namespace Aliyun.Acs.Alidns.Transform.V20150109
{
    public class DescribeGtmInstanceResponseUnmarshaller
    {
        public static DescribeGtmInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGtmInstanceResponse describeGtmInstanceResponse = new DescribeGtmInstanceResponse();

			describeGtmInstanceResponse.HttpResponse = context.HttpResponse;
			describeGtmInstanceResponse.RequestId = context.StringValue("DescribeGtmInstance.RequestId");
			describeGtmInstanceResponse.InstanceId = context.StringValue("DescribeGtmInstance.InstanceId");
			describeGtmInstanceResponse.InstanceName = context.StringValue("DescribeGtmInstance.InstanceName");
			describeGtmInstanceResponse.VersionCode = context.StringValue("DescribeGtmInstance.VersionCode");
			describeGtmInstanceResponse.ExpireTime = context.StringValue("DescribeGtmInstance.ExpireTime");
			describeGtmInstanceResponse.ExpireTimestamp = context.LongValue("DescribeGtmInstance.ExpireTimestamp");
			describeGtmInstanceResponse.Cname = context.StringValue("DescribeGtmInstance.Cname");
			describeGtmInstanceResponse.UserDomainName = context.StringValue("DescribeGtmInstance.UserDomainName");
			describeGtmInstanceResponse.Ttl = context.IntegerValue("DescribeGtmInstance.Ttl");
			describeGtmInstanceResponse.LbaStrategy = context.StringValue("DescribeGtmInstance.LbaStrategy");
			describeGtmInstanceResponse.CreateTime = context.StringValue("DescribeGtmInstance.CreateTime");
			describeGtmInstanceResponse.CreateTimestamp = context.LongValue("DescribeGtmInstance.CreateTimestamp");
			describeGtmInstanceResponse.AlertGroup = context.StringValue("DescribeGtmInstance.AlertGroup");
			describeGtmInstanceResponse.CnameMode = context.StringValue("DescribeGtmInstance.CnameMode");
        
			return describeGtmInstanceResponse;
        }
    }
}
