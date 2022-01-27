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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class AddNodesResponseUnmarshaller
    {
        public static AddNodesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddNodesResponse addNodesResponse = new AddNodesResponse();

			addNodesResponse.HttpResponse = _ctx.HttpResponse;
			addNodesResponse.RequestId = _ctx.StringValue("AddNodes.RequestId");
			addNodesResponse.TaskId = _ctx.StringValue("AddNodes.TaskId");

			List<string> addNodesResponse_instanceIds = new List<string>();
			for (int i = 0; i < _ctx.Length("AddNodes.InstanceIds.Length"); i++) {
				addNodesResponse_instanceIds.Add(_ctx.StringValue("AddNodes.InstanceIds["+ i +"]"));
			}
			addNodesResponse.InstanceIds = addNodesResponse_instanceIds;
        
			return addNodesResponse;
        }
    }
}
