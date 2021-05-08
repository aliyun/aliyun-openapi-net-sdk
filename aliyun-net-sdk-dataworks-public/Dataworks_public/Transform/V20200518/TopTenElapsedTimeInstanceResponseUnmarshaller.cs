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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class TopTenElapsedTimeInstanceResponseUnmarshaller
    {
        public static TopTenElapsedTimeInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TopTenElapsedTimeInstanceResponse topTenElapsedTimeInstanceResponse = new TopTenElapsedTimeInstanceResponse();

			topTenElapsedTimeInstanceResponse.HttpResponse = _ctx.HttpResponse;
			topTenElapsedTimeInstanceResponse.RequestId = _ctx.StringValue("TopTenElapsedTimeInstance.RequestId");

			TopTenElapsedTimeInstanceResponse.TopTenElapsedTimeInstance_InstanceConsumeTimeRank instanceConsumeTimeRank = new TopTenElapsedTimeInstanceResponse.TopTenElapsedTimeInstance_InstanceConsumeTimeRank();
			instanceConsumeTimeRank.UpdateTime = _ctx.LongValue("TopTenElapsedTimeInstance.InstanceConsumeTimeRank.UpdateTime");

			List<TopTenElapsedTimeInstanceResponse.TopTenElapsedTimeInstance_InstanceConsumeTimeRank.TopTenElapsedTimeInstance_ConsumeTimeRankItem> instanceConsumeTimeRank_consumeTimeRank = new List<TopTenElapsedTimeInstanceResponse.TopTenElapsedTimeInstance_InstanceConsumeTimeRank.TopTenElapsedTimeInstance_ConsumeTimeRankItem>();
			for (int i = 0; i < _ctx.Length("TopTenElapsedTimeInstance.InstanceConsumeTimeRank.ConsumeTimeRank.Length"); i++) {
				TopTenElapsedTimeInstanceResponse.TopTenElapsedTimeInstance_InstanceConsumeTimeRank.TopTenElapsedTimeInstance_ConsumeTimeRankItem consumeTimeRankItem = new TopTenElapsedTimeInstanceResponse.TopTenElapsedTimeInstance_InstanceConsumeTimeRank.TopTenElapsedTimeInstance_ConsumeTimeRankItem();
				consumeTimeRankItem.NodeName = _ctx.StringValue("TopTenElapsedTimeInstance.InstanceConsumeTimeRank.ConsumeTimeRank["+ i +"].NodeName");
				consumeTimeRankItem.NodeId = _ctx.LongValue("TopTenElapsedTimeInstance.InstanceConsumeTimeRank.ConsumeTimeRank["+ i +"].NodeId");
				consumeTimeRankItem.BusinessDate = _ctx.LongValue("TopTenElapsedTimeInstance.InstanceConsumeTimeRank.ConsumeTimeRank["+ i +"].BusinessDate");
				consumeTimeRankItem.Owner = _ctx.StringValue("TopTenElapsedTimeInstance.InstanceConsumeTimeRank.ConsumeTimeRank["+ i +"].Owner");
				consumeTimeRankItem.Consumed = _ctx.LongValue("TopTenElapsedTimeInstance.InstanceConsumeTimeRank.ConsumeTimeRank["+ i +"].Consumed");
				consumeTimeRankItem.InstanceId = _ctx.LongValue("TopTenElapsedTimeInstance.InstanceConsumeTimeRank.ConsumeTimeRank["+ i +"].InstanceId");
				consumeTimeRankItem.ProgramType = _ctx.IntegerValue("TopTenElapsedTimeInstance.InstanceConsumeTimeRank.ConsumeTimeRank["+ i +"].ProgramType");

				instanceConsumeTimeRank_consumeTimeRank.Add(consumeTimeRankItem);
			}
			instanceConsumeTimeRank.ConsumeTimeRank = instanceConsumeTimeRank_consumeTimeRank;
			topTenElapsedTimeInstanceResponse.InstanceConsumeTimeRank = instanceConsumeTimeRank;
        
			return topTenElapsedTimeInstanceResponse;
        }
    }
}
