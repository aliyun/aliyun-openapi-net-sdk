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
using Aliyun.Acs.ltl.Model.V20190510;

namespace Aliyun.Acs.ltl.Transform.V20190510
{
    public class ListMPCoSPhaseGroupResponseUnmarshaller
    {
        public static ListMPCoSPhaseGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMPCoSPhaseGroupResponse listMPCoSPhaseGroupResponse = new ListMPCoSPhaseGroupResponse();

			listMPCoSPhaseGroupResponse.HttpResponse = _ctx.HttpResponse;
			listMPCoSPhaseGroupResponse.Code = _ctx.IntegerValue("ListMPCoSPhaseGroup.Code");
			listMPCoSPhaseGroupResponse.Message = _ctx.StringValue("ListMPCoSPhaseGroup.Message");
			listMPCoSPhaseGroupResponse.RequestId = _ctx.StringValue("ListMPCoSPhaseGroup.RequestId");
			listMPCoSPhaseGroupResponse.Success = _ctx.BooleanValue("ListMPCoSPhaseGroup.Success");

			ListMPCoSPhaseGroupResponse.ListMPCoSPhaseGroup_Data data = new ListMPCoSPhaseGroupResponse.ListMPCoSPhaseGroup_Data();
			data.Num = _ctx.IntegerValue("ListMPCoSPhaseGroup.Data.Num");
			data.Total = _ctx.IntegerValue("ListMPCoSPhaseGroup.Data.Total");
			data.Size = _ctx.IntegerValue("ListMPCoSPhaseGroup.Data.Size");

			List<ListMPCoSPhaseGroupResponse.ListMPCoSPhaseGroup_Data.ListMPCoSPhaseGroup_PhaseGroupInfo> data_pageData = new List<ListMPCoSPhaseGroupResponse.ListMPCoSPhaseGroup_Data.ListMPCoSPhaseGroup_PhaseGroupInfo>();
			for (int i = 0; i < _ctx.Length("ListMPCoSPhaseGroup.Data.PageData.Length"); i++) {
				ListMPCoSPhaseGroupResponse.ListMPCoSPhaseGroup_Data.ListMPCoSPhaseGroup_PhaseGroupInfo phaseGroupInfo = new ListMPCoSPhaseGroupResponse.ListMPCoSPhaseGroup_Data.ListMPCoSPhaseGroup_PhaseGroupInfo();
				phaseGroupInfo.PhaseGroupId = _ctx.StringValue("ListMPCoSPhaseGroup.Data.PageData["+ i +"].PhaseGroupId");
				phaseGroupInfo.Name = _ctx.StringValue("ListMPCoSPhaseGroup.Data.PageData["+ i +"].Name");
				phaseGroupInfo.Remark = _ctx.StringValue("ListMPCoSPhaseGroup.Data.PageData["+ i +"].Remark");

				data_pageData.Add(phaseGroupInfo);
			}
			data.PageData = data_pageData;
			listMPCoSPhaseGroupResponse.Data = data;
        
			return listMPCoSPhaseGroupResponse;
        }
    }
}
