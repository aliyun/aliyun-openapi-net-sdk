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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeAvailableMemResourceResponseUnmarshaller
    {
        public static DescribeAvailableMemResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableMemResourceResponse describeAvailableMemResourceResponse = new DescribeAvailableMemResourceResponse();

			describeAvailableMemResourceResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableMemResourceResponse.RequestId = _ctx.StringValue("DescribeAvailableMemResource.RequestId");

			DescribeAvailableMemResourceResponse.DescribeAvailableMemResource_Data data = new DescribeAvailableMemResourceResponse.DescribeAvailableMemResource_Data();
			data.MinMem = _ctx.LongValue("DescribeAvailableMemResource.Data.MinMem");
			data.MaxMem = _ctx.LongValue("DescribeAvailableMemResource.Data.MaxMem");
			data.UsedMem = _ctx.LongValue("DescribeAvailableMemResource.Data.UsedMem");
			data.SafeMem = _ctx.StringValue("DescribeAvailableMemResource.Data.SafeMem");
			describeAvailableMemResourceResponse.Data = data;
        
			return describeAvailableMemResourceResponse;
        }
    }
}
