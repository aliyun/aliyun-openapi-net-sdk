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
    public class DescribeProtocolMountTargetResponseUnmarshaller
    {
        public static DescribeProtocolMountTargetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProtocolMountTargetResponse describeProtocolMountTargetResponse = new DescribeProtocolMountTargetResponse();

			describeProtocolMountTargetResponse.HttpResponse = _ctx.HttpResponse;
			describeProtocolMountTargetResponse.RequestId = _ctx.StringValue("DescribeProtocolMountTarget.RequestId");
			describeProtocolMountTargetResponse.NextToken = _ctx.StringValue("DescribeProtocolMountTarget.NextToken");

			List<DescribeProtocolMountTargetResponse.DescribeProtocolMountTarget_ProtocolMountTarget> describeProtocolMountTargetResponse_protocolMountTargets = new List<DescribeProtocolMountTargetResponse.DescribeProtocolMountTarget_ProtocolMountTarget>();
			for (int i = 0; i < _ctx.Length("DescribeProtocolMountTarget.ProtocolMountTargets.Length"); i++) {
				DescribeProtocolMountTargetResponse.DescribeProtocolMountTarget_ProtocolMountTarget protocolMountTarget = new DescribeProtocolMountTargetResponse.DescribeProtocolMountTarget_ProtocolMountTarget();
				protocolMountTarget.ExportId = _ctx.StringValue("DescribeProtocolMountTarget.ProtocolMountTargets["+ i +"].ExportId");
				protocolMountTarget.ProtocolMountTargetDomain = _ctx.StringValue("DescribeProtocolMountTarget.ProtocolMountTargets["+ i +"].ProtocolMountTargetDomain");
				protocolMountTarget.ProtocolType = _ctx.StringValue("DescribeProtocolMountTarget.ProtocolMountTargets["+ i +"].ProtocolType");
				protocolMountTarget.VpcId = _ctx.StringValue("DescribeProtocolMountTarget.ProtocolMountTargets["+ i +"].VpcId");
				protocolMountTarget.VSwitchId = _ctx.StringValue("DescribeProtocolMountTarget.ProtocolMountTargets["+ i +"].VSwitchId");
				protocolMountTarget.FsetId = _ctx.StringValue("DescribeProtocolMountTarget.ProtocolMountTargets["+ i +"].FsetId");
				protocolMountTarget.Path = _ctx.StringValue("DescribeProtocolMountTarget.ProtocolMountTargets["+ i +"].Path");
				protocolMountTarget.AccessGroupName = _ctx.StringValue("DescribeProtocolMountTarget.ProtocolMountTargets["+ i +"].AccessGroupName");
				protocolMountTarget.CreateTime = _ctx.StringValue("DescribeProtocolMountTarget.ProtocolMountTargets["+ i +"].CreateTime");
				protocolMountTarget.Status = _ctx.StringValue("DescribeProtocolMountTarget.ProtocolMountTargets["+ i +"].Status");
				protocolMountTarget.ProtocolServiceId = _ctx.StringValue("DescribeProtocolMountTarget.ProtocolMountTargets["+ i +"].ProtocolServiceId");
				protocolMountTarget.Description = _ctx.StringValue("DescribeProtocolMountTarget.ProtocolMountTargets["+ i +"].Description");

				describeProtocolMountTargetResponse_protocolMountTargets.Add(protocolMountTarget);
			}
			describeProtocolMountTargetResponse.ProtocolMountTargets = describeProtocolMountTargetResponse_protocolMountTargets;
        
			return describeProtocolMountTargetResponse;
        }
    }
}
