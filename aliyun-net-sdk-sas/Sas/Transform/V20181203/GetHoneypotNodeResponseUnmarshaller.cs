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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class GetHoneypotNodeResponseUnmarshaller
    {
        public static GetHoneypotNodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetHoneypotNodeResponse getHoneypotNodeResponse = new GetHoneypotNodeResponse();

			getHoneypotNodeResponse.HttpResponse = _ctx.HttpResponse;
			getHoneypotNodeResponse.Success = _ctx.BooleanValue("GetHoneypotNode.Success");
			getHoneypotNodeResponse.Code = _ctx.StringValue("GetHoneypotNode.Code");
			getHoneypotNodeResponse.Message = _ctx.StringValue("GetHoneypotNode.Message");
			getHoneypotNodeResponse.RequestId = _ctx.StringValue("GetHoneypotNode.RequestId");
			getHoneypotNodeResponse.HttpStatusCode = _ctx.IntegerValue("GetHoneypotNode.HttpStatusCode");

			GetHoneypotNodeResponse.GetHoneypotNode_HoneypotNode honeypotNode = new GetHoneypotNodeResponse.GetHoneypotNode_HoneypotNode();
			honeypotNode.NodeId = _ctx.StringValue("GetHoneypotNode.HoneypotNode.NodeId");
			honeypotNode.NodeName = _ctx.StringValue("GetHoneypotNode.HoneypotNode.NodeName");
			honeypotNode.HoneypotTotalCount = _ctx.IntegerValue("GetHoneypotNode.HoneypotNode.HoneypotTotalCount");
			honeypotNode.HoneypotUsedCount = _ctx.IntegerValue("GetHoneypotNode.HoneypotNode.HoneypotUsedCount");
			honeypotNode.ProbeTotalCount = _ctx.IntegerValue("GetHoneypotNode.HoneypotNode.ProbeTotalCount");
			honeypotNode.ProbeUsedCount = _ctx.IntegerValue("GetHoneypotNode.HoneypotNode.ProbeUsedCount");
			honeypotNode.TotalStatus = _ctx.IntegerValue("GetHoneypotNode.HoneypotNode.TotalStatus");
			honeypotNode.EcsInstanceId = _ctx.StringValue("GetHoneypotNode.HoneypotNode.EcsInstanceId");
			honeypotNode.CreateTime = _ctx.StringValue("GetHoneypotNode.HoneypotNode.CreateTime");
			honeypotNode.AllowHoneypotAccessInternet = _ctx.BooleanValue("GetHoneypotNode.HoneypotNode.AllowHoneypotAccessInternet");
			honeypotNode.Ip = _ctx.StringValue("GetHoneypotNode.HoneypotNode.Ip");

			List<string> honeypotNode_securityGroupProbeIpList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetHoneypotNode.HoneypotNode.SecurityGroupProbeIpList.Length"); i++) {
				honeypotNode_securityGroupProbeIpList.Add(_ctx.StringValue("GetHoneypotNode.HoneypotNode.SecurityGroupProbeIpList["+ i +"]"));
			}
			honeypotNode.SecurityGroupProbeIpList = honeypotNode_securityGroupProbeIpList;
			getHoneypotNodeResponse.HoneypotNode = honeypotNode;
        
			return getHoneypotNodeResponse;
        }
    }
}
