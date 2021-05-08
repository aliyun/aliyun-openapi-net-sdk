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
    public class TopTenErrorTimesInstanceResponseUnmarshaller
    {
        public static TopTenErrorTimesInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			TopTenErrorTimesInstanceResponse topTenErrorTimesInstanceResponse = new TopTenErrorTimesInstanceResponse();

			topTenErrorTimesInstanceResponse.HttpResponse = _ctx.HttpResponse;
			topTenErrorTimesInstanceResponse.RequestId = _ctx.StringValue("TopTenErrorTimesInstance.RequestId");

			TopTenErrorTimesInstanceResponse.TopTenErrorTimesInstance_InstanceErrorRank instanceErrorRank = new TopTenErrorTimesInstanceResponse.TopTenErrorTimesInstance_InstanceErrorRank();
			instanceErrorRank.UpdateTime = _ctx.LongValue("TopTenErrorTimesInstance.InstanceErrorRank.UpdateTime");

			List<TopTenErrorTimesInstanceResponse.TopTenErrorTimesInstance_InstanceErrorRank.TopTenErrorTimesInstance_ErrorRankItem> instanceErrorRank_errorRank = new List<TopTenErrorTimesInstanceResponse.TopTenErrorTimesInstance_InstanceErrorRank.TopTenErrorTimesInstance_ErrorRankItem>();
			for (int i = 0; i < _ctx.Length("TopTenErrorTimesInstance.InstanceErrorRank.ErrorRank.Length"); i++) {
				TopTenErrorTimesInstanceResponse.TopTenErrorTimesInstance_InstanceErrorRank.TopTenErrorTimesInstance_ErrorRankItem errorRankItem = new TopTenErrorTimesInstanceResponse.TopTenErrorTimesInstance_InstanceErrorRank.TopTenErrorTimesInstance_ErrorRankItem();
				errorRankItem.NodeId = _ctx.LongValue("TopTenErrorTimesInstance.InstanceErrorRank.ErrorRank["+ i +"].NodeId");
				errorRankItem.NodeName = _ctx.StringValue("TopTenErrorTimesInstance.InstanceErrorRank.ErrorRank["+ i +"].NodeName");
				errorRankItem.Owner = _ctx.StringValue("TopTenErrorTimesInstance.InstanceErrorRank.ErrorRank["+ i +"].Owner");
				errorRankItem.Count = _ctx.IntegerValue("TopTenErrorTimesInstance.InstanceErrorRank.ErrorRank["+ i +"].Count");
				errorRankItem.ProjectId = _ctx.LongValue("TopTenErrorTimesInstance.InstanceErrorRank.ErrorRank["+ i +"].ProjectId");
				errorRankItem.ProgramType = _ctx.IntegerValue("TopTenErrorTimesInstance.InstanceErrorRank.ErrorRank["+ i +"].ProgramType");

				instanceErrorRank_errorRank.Add(errorRankItem);
			}
			instanceErrorRank.ErrorRank = instanceErrorRank_errorRank;
			topTenErrorTimesInstanceResponse.InstanceErrorRank = instanceErrorRank;
        
			return topTenErrorTimesInstanceResponse;
        }
    }
}
