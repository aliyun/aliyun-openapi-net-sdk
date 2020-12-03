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
    public class GetInstanceErrorRankResponseUnmarshaller
    {
        public static GetInstanceErrorRankResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetInstanceErrorRankResponse getInstanceErrorRankResponse = new GetInstanceErrorRankResponse();

			getInstanceErrorRankResponse.HttpResponse = _ctx.HttpResponse;
			getInstanceErrorRankResponse.RequestId = _ctx.StringValue("GetInstanceErrorRank.RequestId");

			GetInstanceErrorRankResponse.GetInstanceErrorRank_InstanceErrorRank instanceErrorRank = new GetInstanceErrorRankResponse.GetInstanceErrorRank_InstanceErrorRank();
			instanceErrorRank.UpdateTime = _ctx.LongValue("GetInstanceErrorRank.InstanceErrorRank.UpdateTime");

			List<GetInstanceErrorRankResponse.GetInstanceErrorRank_InstanceErrorRank.GetInstanceErrorRank_ErrorRankItem> instanceErrorRank_errorRank = new List<GetInstanceErrorRankResponse.GetInstanceErrorRank_InstanceErrorRank.GetInstanceErrorRank_ErrorRankItem>();
			for (int i = 0; i < _ctx.Length("GetInstanceErrorRank.InstanceErrorRank.ErrorRank.Length"); i++) {
				GetInstanceErrorRankResponse.GetInstanceErrorRank_InstanceErrorRank.GetInstanceErrorRank_ErrorRankItem errorRankItem = new GetInstanceErrorRankResponse.GetInstanceErrorRank_InstanceErrorRank.GetInstanceErrorRank_ErrorRankItem();
				errorRankItem.NodeId = _ctx.LongValue("GetInstanceErrorRank.InstanceErrorRank.ErrorRank["+ i +"].NodeId");
				errorRankItem.NodeName = _ctx.StringValue("GetInstanceErrorRank.InstanceErrorRank.ErrorRank["+ i +"].NodeName");
				errorRankItem.Owner = _ctx.StringValue("GetInstanceErrorRank.InstanceErrorRank.ErrorRank["+ i +"].Owner");
				errorRankItem.Count = _ctx.IntegerValue("GetInstanceErrorRank.InstanceErrorRank.ErrorRank["+ i +"].Count");
				errorRankItem.ProjectId = _ctx.LongValue("GetInstanceErrorRank.InstanceErrorRank.ErrorRank["+ i +"].ProjectId");
				errorRankItem.PrgType = _ctx.IntegerValue("GetInstanceErrorRank.InstanceErrorRank.ErrorRank["+ i +"].PrgType");

				instanceErrorRank_errorRank.Add(errorRankItem);
			}
			instanceErrorRank.ErrorRank = instanceErrorRank_errorRank;
			getInstanceErrorRankResponse.InstanceErrorRank = instanceErrorRank;
        
			return getInstanceErrorRankResponse;
        }
    }
}
