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
        public static DescribeGtmInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeGtmInstancesResponse describeGtmInstancesResponse = new DescribeGtmInstancesResponse();

			describeGtmInstancesResponse.HttpResponse = context.HttpResponse;
			describeGtmInstancesResponse.RequestId = context.StringValue("DescribeGtmInstances.RequestId");
			describeGtmInstancesResponse.PageNumber = context.IntegerValue("DescribeGtmInstances.PageNumber");
			describeGtmInstancesResponse.PageSize = context.IntegerValue("DescribeGtmInstances.PageSize");
			describeGtmInstancesResponse.TotalItems = context.IntegerValue("DescribeGtmInstances.TotalItems");
			describeGtmInstancesResponse.TotalPages = context.IntegerValue("DescribeGtmInstances.TotalPages");

			List<DescribeGtmInstancesResponse.DescribeGtmInstances_GtmInstance> describeGtmInstancesResponse_gtmInstances = new List<DescribeGtmInstancesResponse.DescribeGtmInstances_GtmInstance>();
			for (int i = 0; i < context.Length("DescribeGtmInstances.GtmInstances.Length"); i++) {
				DescribeGtmInstancesResponse.DescribeGtmInstances_GtmInstance gtmInstance = new DescribeGtmInstancesResponse.DescribeGtmInstances_GtmInstance();
				gtmInstance.InstanceId = context.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].InstanceId");
				gtmInstance.InstanceName = context.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].InstanceName");
				gtmInstance.Cname = context.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].Cname");
				gtmInstance.UserDomainName = context.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].UserDomainName");
				gtmInstance.VersionCode = context.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].VersionCode");
				gtmInstance.Ttl = context.IntegerValue("DescribeGtmInstances.GtmInstances["+ i +"].Ttl");
				gtmInstance.LbaStrategy = context.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].LbaStrategy");
				gtmInstance.CreateTime = context.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].CreateTime");
				gtmInstance.CreateTimestamp = context.LongValue("DescribeGtmInstances.GtmInstances["+ i +"].CreateTimestamp");
				gtmInstance.ExpireTime = context.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].ExpireTime");
				gtmInstance.ExpireTimestamp = context.LongValue("DescribeGtmInstances.GtmInstances["+ i +"].ExpireTimestamp");
				gtmInstance.AlertGroup = context.StringValue("DescribeGtmInstances.GtmInstances["+ i +"].AlertGroup");

				describeGtmInstancesResponse_gtmInstances.Add(gtmInstance);
			}
			describeGtmInstancesResponse.GtmInstances = describeGtmInstancesResponse_gtmInstances;
        
			return describeGtmInstancesResponse;
        }
    }
}
