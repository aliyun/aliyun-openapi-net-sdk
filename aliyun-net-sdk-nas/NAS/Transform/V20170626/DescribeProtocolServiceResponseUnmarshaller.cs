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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeProtocolServiceResponseUnmarshaller
    {
        public static DescribeProtocolServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProtocolServiceResponse describeProtocolServiceResponse = new DescribeProtocolServiceResponse();

			describeProtocolServiceResponse.HttpResponse = _ctx.HttpResponse;
			describeProtocolServiceResponse.RequestId = _ctx.StringValue("DescribeProtocolService.RequestId");
			describeProtocolServiceResponse.NextToken = _ctx.StringValue("DescribeProtocolService.NextToken");

			List<DescribeProtocolServiceResponse.DescribeProtocolService_ProtocolService> describeProtocolServiceResponse_protocolServices = new List<DescribeProtocolServiceResponse.DescribeProtocolService_ProtocolService>();
			for (int i = 0; i < _ctx.Length("DescribeProtocolService.ProtocolServices.Length"); i++) {
				DescribeProtocolServiceResponse.DescribeProtocolService_ProtocolService protocolService = new DescribeProtocolServiceResponse.DescribeProtocolService_ProtocolService();
				protocolService.FileSystemId = _ctx.StringValue("DescribeProtocolService.ProtocolServices["+ i +"].FileSystemId");
				protocolService.ProtocolServiceId = _ctx.StringValue("DescribeProtocolService.ProtocolServices["+ i +"].ProtocolServiceId");
				protocolService.ProtocolSpec = _ctx.StringValue("DescribeProtocolService.ProtocolServices["+ i +"].ProtocolSpec");
				protocolService.ProtocolThroughput = _ctx.IntegerValue("DescribeProtocolService.ProtocolServices["+ i +"].ProtocolThroughput");
				protocolService.InstanceRAM = _ctx.IntegerValue("DescribeProtocolService.ProtocolServices["+ i +"].InstanceRAM");
				protocolService.InstanceBaseThroughput = _ctx.IntegerValue("DescribeProtocolService.ProtocolServices["+ i +"].InstanceBaseThroughput");
				protocolService.InstanceBurstThroughput = _ctx.IntegerValue("DescribeProtocolService.ProtocolServices["+ i +"].InstanceBurstThroughput");
				protocolService.MountTargetCount = _ctx.IntegerValue("DescribeProtocolService.ProtocolServices["+ i +"].MountTargetCount");
				protocolService.ProtocolType = _ctx.StringValue("DescribeProtocolService.ProtocolServices["+ i +"].ProtocolType");
				protocolService.Status = _ctx.StringValue("DescribeProtocolService.ProtocolServices["+ i +"].Status");
				protocolService.Description = _ctx.StringValue("DescribeProtocolService.ProtocolServices["+ i +"].Description");
				protocolService.CreateTime = _ctx.StringValue("DescribeProtocolService.ProtocolServices["+ i +"].CreateTime");
				protocolService.ModifyTime = _ctx.StringValue("DescribeProtocolService.ProtocolServices["+ i +"].ModifyTime");

				describeProtocolServiceResponse_protocolServices.Add(protocolService);
			}
			describeProtocolServiceResponse.ProtocolServices = describeProtocolServiceResponse_protocolServices;
        
			return describeProtocolServiceResponse;
        }
    }
}
