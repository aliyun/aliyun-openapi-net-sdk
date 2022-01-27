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
    public class GetInstanceConsumeTimeRankResponseUnmarshaller
    {
        public static GetInstanceConsumeTimeRankResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceConsumeTimeRankResponse getInstanceConsumeTimeRankResponse = new GetInstanceConsumeTimeRankResponse();

			getInstanceConsumeTimeRankResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceConsumeTimeRankResponse.RequestId = _ctx.StringValue("GetInstanceConsumeTimeRank.RequestId");

			GetInstanceConsumeTimeRankResponse.GetInstanceConsumeTimeRank_InstanceConsumeTimeRank instanceConsumeTimeRank = new GetInstanceConsumeTimeRankResponse.GetInstanceConsumeTimeRank_InstanceConsumeTimeRank();
			instanceConsumeTimeRank.UpdateTime = _ctx.LongValue("GetInstanceConsumeTimeRank.InstanceConsumeTimeRank.UpdateTime");

			List<GetInstanceConsumeTimeRankResponse.GetInstanceConsumeTimeRank_InstanceConsumeTimeRank.GetInstanceConsumeTimeRank_ConsumeTimeRankItem> instanceConsumeTimeRank_consumeTimeRank = new List<GetInstanceConsumeTimeRankResponse.GetInstanceConsumeTimeRank_InstanceConsumeTimeRank.GetInstanceConsumeTimeRank_ConsumeTimeRankItem>();
			for (int i = 0; i < _ctx.Length("GetInstanceConsumeTimeRank.InstanceConsumeTimeRank.ConsumeTimeRank.Length"); i++) {
				GetInstanceConsumeTimeRankResponse.GetInstanceConsumeTimeRank_InstanceConsumeTimeRank.GetInstanceConsumeTimeRank_ConsumeTimeRankItem consumeTimeRankItem = new GetInstanceConsumeTimeRankResponse.GetInstanceConsumeTimeRank_InstanceConsumeTimeRank.GetInstanceConsumeTimeRank_ConsumeTimeRankItem();
				consumeTimeRankItem.NodeName = _ctx.StringValue("GetInstanceConsumeTimeRank.InstanceConsumeTimeRank.ConsumeTimeRank["+ i +"].NodeName");
				consumeTimeRankItem.NodeId = _ctx.LongValue("GetInstanceConsumeTimeRank.InstanceConsumeTimeRank.ConsumeTimeRank["+ i +"].NodeId");
				consumeTimeRankItem.Bizdate = _ctx.LongValue("GetInstanceConsumeTimeRank.InstanceConsumeTimeRank.ConsumeTimeRank["+ i +"].Bizdate");
				consumeTimeRankItem.Owner = _ctx.StringValue("GetInstanceConsumeTimeRank.InstanceConsumeTimeRank.ConsumeTimeRank["+ i +"].Owner");
				consumeTimeRankItem.Consumed = _ctx.LongValue("GetInstanceConsumeTimeRank.InstanceConsumeTimeRank.ConsumeTimeRank["+ i +"].Consumed");
				consumeTimeRankItem.InstanceId = _ctx.LongValue("GetInstanceConsumeTimeRank.InstanceConsumeTimeRank.ConsumeTimeRank["+ i +"].InstanceId");
				consumeTimeRankItem.PrgType = _ctx.IntegerValue("GetInstanceConsumeTimeRank.InstanceConsumeTimeRank.ConsumeTimeRank["+ i +"].PrgType");

				instanceConsumeTimeRank_consumeTimeRank.Add(consumeTimeRankItem);
			}
			instanceConsumeTimeRank.ConsumeTimeRank = instanceConsumeTimeRank_consumeTimeRank;
			getInstanceConsumeTimeRankResponse.InstanceConsumeTimeRank = instanceConsumeTimeRank;
        
			return getInstanceConsumeTimeRankResponse;
        }
    }
}
