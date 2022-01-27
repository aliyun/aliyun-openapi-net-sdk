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
    public class DescribeGtmInstancesResponseUnmarshaller
    {
        public static DescribeGtmInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGtmInstancesResponse describeGtmInstancesResponse = new DescribeGtmInstancesResponse();

			describeGtmInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeGtmInstancesResponse.PageSize = _ctx.IntegerValue("DescribeGtmInstances.PageSize");
			describeGtmInstancesResponse.RequestId = _ctx.StringValue("DescribeGtmInstances.RequestId");
			describeGtmInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeGtmInstances.PageNumber");
			describeGtmInstancesResponse.TotalPages = _ctx.IntegerValue("DescribeGtmInstances.TotalPages");
			describeGtmInstancesResponse.TotalItems = _ctx.IntegerValue("DescribeGtmInstances.TotalItems");

			List<DescribeGtmInstancesResponse.DescribeGtmInstances_GtmInstance> describeGtmInstancesResponse_gtmInstances = new List<DescribeGtmInstancesResponse.DescribeGtmInstances_GtmInstance>();
			for (int i = 0; i < _ctx.Length("DescribeGtmInstances.GtmInstances.Length"); i++) {
				DescribeGtmInstancesResponse.DescribeGtmInstances_GtmInstance gtmInstance = new DescribeGtmInstancesResponse.DescribeGtmInstances_GtmInstance();
				gtmInstance.ExpireTime = _ctx.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].ExpireTime");
				gtmInstance.AccessStrategyNum = _ctx.IntegerValue("DescribeGtmInstances.GtmInstances["+ i +"].AccessStrategyNum");
				gtmInstance.CreateTime = _ctx.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].CreateTime");
				gtmInstance.CnameMode = _ctx.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].CnameMode");
				gtmInstance.InstanceId = _ctx.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].InstanceId");
				gtmInstance.ExpireTimestamp = _ctx.LongValue("DescribeGtmInstances.GtmInstances["+ i +"].ExpireTimestamp");
				gtmInstance.Ttl = _ctx.IntegerValue("DescribeGtmInstances.GtmInstances["+ i +"].Ttl");
				gtmInstance.AlertGroup = _ctx.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].AlertGroup");
				gtmInstance.AddressPoolNum = _ctx.IntegerValue("DescribeGtmInstances.GtmInstances["+ i +"].AddressPoolNum");
				gtmInstance.InstanceName = _ctx.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].InstanceName");
				gtmInstance.LbaStrategy = _ctx.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].LbaStrategy");
				gtmInstance.Cname = _ctx.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].Cname");
				gtmInstance.VersionCode = _ctx.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].VersionCode");
				gtmInstance.UserDomainName = _ctx.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].UserDomainName");
				gtmInstance.CreateTimestamp = _ctx.LongValue("DescribeGtmInstances.GtmInstances["+ i +"].CreateTimestamp");
				gtmInstance.ResourceGroupId = _ctx.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].ResourceGroupId");

				describeGtmInstancesResponse_gtmInstances.Add(gtmInstance);
			}
			describeGtmInstancesResponse.GtmInstances = describeGtmInstancesResponse_gtmInstances;
        
			return describeGtmInstancesResponse;
        }
    }
}
