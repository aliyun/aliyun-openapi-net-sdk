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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeStorageBundleResponseUnmarshaller
    {
        public static DescribeStorageBundleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStorageBundleResponse describeStorageBundleResponse = new DescribeStorageBundleResponse();

			describeStorageBundleResponse.HttpResponse = _ctx.HttpResponse;
			describeStorageBundleResponse.RequestId = _ctx.StringValue("DescribeStorageBundle.RequestId");
			describeStorageBundleResponse.Success = _ctx.BooleanValue("DescribeStorageBundle.Success");
			describeStorageBundleResponse.Code = _ctx.StringValue("DescribeStorageBundle.Code");
			describeStorageBundleResponse.Message = _ctx.StringValue("DescribeStorageBundle.Message");
			describeStorageBundleResponse.StorageBundleId = _ctx.StringValue("DescribeStorageBundle.StorageBundleId");
			describeStorageBundleResponse.Name = _ctx.StringValue("DescribeStorageBundle.Name");
			describeStorageBundleResponse.Description = _ctx.StringValue("DescribeStorageBundle.Description");
			describeStorageBundleResponse.BackendBucketRegionId = _ctx.StringValue("DescribeStorageBundle.BackendBucketRegionId");
			describeStorageBundleResponse.Location = _ctx.StringValue("DescribeStorageBundle.Location");
			describeStorageBundleResponse.CreatedTime = _ctx.LongValue("DescribeStorageBundle.CreatedTime");
			describeStorageBundleResponse.ResourceGroupId = _ctx.StringValue("DescribeStorageBundle.ResourceGroupId");
        
			return describeStorageBundleResponse;
        }
    }
}
