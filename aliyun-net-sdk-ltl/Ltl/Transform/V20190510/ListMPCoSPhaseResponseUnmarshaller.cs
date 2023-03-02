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
    public class ListMPCoSPhaseResponseUnmarshaller
    {
        public static ListMPCoSPhaseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMPCoSPhaseResponse listMPCoSPhaseResponse = new ListMPCoSPhaseResponse();

			listMPCoSPhaseResponse.HttpResponse = _ctx.HttpResponse;
			listMPCoSPhaseResponse.Code = _ctx.IntegerValue("ListMPCoSPhase.Code");
			listMPCoSPhaseResponse.Message = _ctx.StringValue("ListMPCoSPhase.Message");
			listMPCoSPhaseResponse.RequestId = _ctx.StringValue("ListMPCoSPhase.RequestId");
			listMPCoSPhaseResponse.Success = _ctx.BooleanValue("ListMPCoSPhase.Success");

			ListMPCoSPhaseResponse.ListMPCoSPhase_Data data = new ListMPCoSPhaseResponse.ListMPCoSPhase_Data();
			data.Num = _ctx.IntegerValue("ListMPCoSPhase.Data.Num");
			data.Total = _ctx.IntegerValue("ListMPCoSPhase.Data.Total");
			data.Size = _ctx.IntegerValue("ListMPCoSPhase.Data.Size");

			List<ListMPCoSPhaseResponse.ListMPCoSPhase_Data.ListMPCoSPhase_PhaseInfo> data_pageData = new List<ListMPCoSPhaseResponse.ListMPCoSPhase_Data.ListMPCoSPhase_PhaseInfo>();
			for (int i = 0; i < _ctx.Length("ListMPCoSPhase.Data.PageData.Length"); i++) {
				ListMPCoSPhaseResponse.ListMPCoSPhase_Data.ListMPCoSPhase_PhaseInfo phaseInfo = new ListMPCoSPhaseResponse.ListMPCoSPhase_Data.ListMPCoSPhase_PhaseInfo();
				phaseInfo.Name = _ctx.StringValue("ListMPCoSPhase.Data.PageData["+ i +"].Name");
				phaseInfo.Remark = _ctx.StringValue("ListMPCoSPhase.Data.PageData["+ i +"].Remark");
				phaseInfo.AccessPermission = _ctx.IntegerValue("ListMPCoSPhase.Data.PageData["+ i +"].AccessPermission");
				phaseInfo.PhaseId = _ctx.StringValue("ListMPCoSPhase.Data.PageData["+ i +"].PhaseId");

				data_pageData.Add(phaseInfo);
			}
			data.PageData = data_pageData;
			listMPCoSPhaseResponse.Data = data;
        
			return listMPCoSPhaseResponse;
        }
    }
}
