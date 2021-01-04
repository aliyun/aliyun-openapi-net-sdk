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
        public static DescribeGtmInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGtmInstanceResponse describeGtmInstanceResponse = new DescribeGtmInstanceResponse();

			describeGtmInstanceResponse.HttpResponse = _ctx.HttpResponse;
			describeGtmInstanceResponse.RequestId = _ctx.StringValue("DescribeGtmInstance.RequestId");
			describeGtmInstanceResponse.InstanceId = _ctx.StringValue("DescribeGtmInstance.InstanceId");
			describeGtmInstanceResponse.InstanceName = _ctx.StringValue("DescribeGtmInstance.InstanceName");
			describeGtmInstanceResponse.VersionCode = _ctx.StringValue("DescribeGtmInstance.VersionCode");
			describeGtmInstanceResponse.ExpireTime = _ctx.StringValue("DescribeGtmInstance.ExpireTime");
			describeGtmInstanceResponse.ExpireTimestamp = _ctx.LongValue("DescribeGtmInstance.ExpireTimestamp");
			describeGtmInstanceResponse.Cname = _ctx.StringValue("DescribeGtmInstance.Cname");
			describeGtmInstanceResponse.UserDomainName = _ctx.StringValue("DescribeGtmInstance.UserDomainName");
			describeGtmInstanceResponse.Ttl = _ctx.IntegerValue("DescribeGtmInstance.Ttl");
			describeGtmInstanceResponse.LbaStrategy = _ctx.StringValue("DescribeGtmInstance.LbaStrategy");
			describeGtmInstanceResponse.CreateTime = _ctx.StringValue("DescribeGtmInstance.CreateTime");
			describeGtmInstanceResponse.CreateTimestamp = _ctx.LongValue("DescribeGtmInstance.CreateTimestamp");
			describeGtmInstanceResponse.AlertGroup = _ctx.StringValue("DescribeGtmInstance.AlertGroup");
			describeGtmInstanceResponse.CnameMode = _ctx.StringValue("DescribeGtmInstance.CnameMode");
			describeGtmInstanceResponse.AccessStrategyNum = _ctx.IntegerValue("DescribeGtmInstance.AccessStrategyNum");
			describeGtmInstanceResponse.AddressPoolNum = _ctx.IntegerValue("DescribeGtmInstance.AddressPoolNum");
        
			return describeGtmInstanceResponse;
        }
    }
}
