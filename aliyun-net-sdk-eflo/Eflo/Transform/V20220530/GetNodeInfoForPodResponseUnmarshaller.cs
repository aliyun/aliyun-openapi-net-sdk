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
using Aliyun.Acs.eflo.Model.V20220530;

namespace Aliyun.Acs.eflo.Transform.V20220530
{
    public class GetNodeInfoForPodResponseUnmarshaller
    {
        public static GetNodeInfoForPodResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNodeInfoForPodResponse getNodeInfoForPodResponse = new GetNodeInfoForPodResponse();

			getNodeInfoForPodResponse.HttpResponse = _ctx.HttpResponse;
			getNodeInfoForPodResponse.Code = _ctx.IntegerValue("GetNodeInfoForPod.Code");
			getNodeInfoForPodResponse.Message = _ctx.StringValue("GetNodeInfoForPod.Message");
			getNodeInfoForPodResponse.RequestId = _ctx.StringValue("GetNodeInfoForPod.RequestId");

			GetNodeInfoForPodResponse.GetNodeInfoForPod_Content content = new GetNodeInfoForPodResponse.GetNodeInfoForPod_Content();
			content.RegionId = _ctx.StringValue("GetNodeInfoForPod.Content.RegionId");
			content.ClusterId = _ctx.StringValue("GetNodeInfoForPod.Content.ClusterId");
			content.VpcId = _ctx.StringValue("GetNodeInfoForPod.Content.VpcId");
			content.NodeId = _ctx.StringValue("GetNodeInfoForPod.Content.NodeId");
			content.LeniQuota = _ctx.IntegerValue("GetNodeInfoForPod.Content.LeniQuota");
			content.LniSipQuota = _ctx.IntegerValue("GetNodeInfoForPod.Content.LniSipQuota");

			List<string> content_vSwitches = new List<string>();
			for (int i = 0; i < _ctx.Length("GetNodeInfoForPod.Content.VSwitches.Length"); i++) {
				content_vSwitches.Add(_ctx.StringValue("GetNodeInfoForPod.Content.VSwitches["+ i +"]"));
			}
			content.VSwitches = content_vSwitches;
			getNodeInfoForPodResponse.Content = content;
        
			return getNodeInfoForPodResponse;
        }
    }
}
