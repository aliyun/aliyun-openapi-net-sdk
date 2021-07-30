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
using Aliyun.Acs.Dyvmsapi.Model.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Transform.V20170525
{
    public class ListOutboundStrategiesResponseUnmarshaller
    {
        public static ListOutboundStrategiesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOutboundStrategiesResponse listOutboundStrategiesResponse = new ListOutboundStrategiesResponse();

			listOutboundStrategiesResponse.HttpResponse = _ctx.HttpResponse;
			listOutboundStrategiesResponse.RequestId = _ctx.StringValue("ListOutboundStrategies.RequestId");
			listOutboundStrategiesResponse.Code = _ctx.StringValue("ListOutboundStrategies.Code");
			listOutboundStrategiesResponse.Message = _ctx.StringValue("ListOutboundStrategies.Message");

			List<ListOutboundStrategiesResponse.ListOutboundStrategies_OutboundStrategy> listOutboundStrategiesResponse_outboundStrategies = new List<ListOutboundStrategiesResponse.ListOutboundStrategies_OutboundStrategy>();
			for (int i = 0; i < _ctx.Length("ListOutboundStrategies.OutboundStrategies.Length"); i++) {
				ListOutboundStrategiesResponse.ListOutboundStrategies_OutboundStrategy outboundStrategy = new ListOutboundStrategiesResponse.ListOutboundStrategies_OutboundStrategy();
				outboundStrategy.Id = _ctx.LongValue("ListOutboundStrategies.OutboundStrategies["+ i +"].Id");
				outboundStrategy.GmtCreateStr = _ctx.StringValue("ListOutboundStrategies.OutboundStrategies["+ i +"].GmtCreateStr");
				outboundStrategy.GmtModifiedStr = _ctx.StringValue("ListOutboundStrategies.OutboundStrategies["+ i +"].GmtModifiedStr");
				outboundStrategy.CreatorId = _ctx.LongValue("ListOutboundStrategies.OutboundStrategies["+ i +"].CreatorId");
				outboundStrategy.CreatorName = _ctx.StringValue("ListOutboundStrategies.OutboundStrategies["+ i +"].CreatorName");
				outboundStrategy.ModifierId = _ctx.LongValue("ListOutboundStrategies.OutboundStrategies["+ i +"].ModifierId");
				outboundStrategy.ModifierName = _ctx.StringValue("ListOutboundStrategies.OutboundStrategies["+ i +"].ModifierName");
				outboundStrategy.BuId = _ctx.LongValue("ListOutboundStrategies.OutboundStrategies["+ i +"].BuId");
				outboundStrategy.DepartmentId = _ctx.LongValue("ListOutboundStrategies.OutboundStrategies["+ i +"].DepartmentId");
				outboundStrategy.Name = _ctx.StringValue("ListOutboundStrategies.OutboundStrategies["+ i +"].name");
				outboundStrategy.NumType = _ctx.IntegerValue("ListOutboundStrategies.OutboundStrategies["+ i +"].NumType");
				outboundStrategy.OutboundNum = _ctx.StringValue("ListOutboundStrategies.OutboundStrategies["+ i +"].OutboundNum");
				outboundStrategy.RobotType = _ctx.IntegerValue("ListOutboundStrategies.OutboundStrategies["+ i +"].RobotType");
				outboundStrategy.RobotId = _ctx.StringValue("ListOutboundStrategies.OutboundStrategies["+ i +"].RobotId");
				outboundStrategy.RobotName = _ctx.StringValue("ListOutboundStrategies.OutboundStrategies["+ i +"].RobotName");
				outboundStrategy.ResourceAllocation = _ctx.IntegerValue("ListOutboundStrategies.OutboundStrategies["+ i +"].ResourceAllocation");
				outboundStrategy.SceneName = _ctx.StringValue("ListOutboundStrategies.OutboundStrategies["+ i +"].SceneName");
				outboundStrategy.RuleCode = _ctx.LongValue("ListOutboundStrategies.OutboundStrategies["+ i +"].RuleCode");
				outboundStrategy.Status = _ctx.IntegerValue("ListOutboundStrategies.OutboundStrategies["+ i +"].Status");
				outboundStrategy.ExtAttr = _ctx.StringValue("ListOutboundStrategies.OutboundStrategies["+ i +"].ExtAttr");
				outboundStrategy.Process = _ctx.IntegerValue("ListOutboundStrategies.OutboundStrategies["+ i +"].Process");
				outboundStrategy.SuccessRate = _ctx.IntegerValue("ListOutboundStrategies.OutboundStrategies["+ i +"].SuccessRate");

				listOutboundStrategiesResponse_outboundStrategies.Add(outboundStrategy);
			}
			listOutboundStrategiesResponse.OutboundStrategies = listOutboundStrategiesResponse_outboundStrategies;
        
			return listOutboundStrategiesResponse;
        }
    }
}
