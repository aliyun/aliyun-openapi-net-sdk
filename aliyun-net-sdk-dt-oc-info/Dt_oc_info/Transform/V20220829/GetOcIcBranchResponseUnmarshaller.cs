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
using Aliyun.Acs.dt_oc_info.Model.V20220829;

namespace Aliyun.Acs.dt_oc_info.Transform.V20220829
{
    public class GetOcIcBranchResponseUnmarshaller
    {
        public static GetOcIcBranchResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIcBranchResponse getOcIcBranchResponse = new GetOcIcBranchResponse();

			getOcIcBranchResponse.HttpResponse = _ctx.HttpResponse;
			getOcIcBranchResponse.Code = _ctx.StringValue("GetOcIcBranch.Code");
			getOcIcBranchResponse.Success = _ctx.BooleanValue("GetOcIcBranch.Success");
			getOcIcBranchResponse.Message = _ctx.StringValue("GetOcIcBranch.Message");
			getOcIcBranchResponse.TotalNum = _ctx.IntegerValue("GetOcIcBranch.TotalNum");
			getOcIcBranchResponse.PageIndex = _ctx.IntegerValue("GetOcIcBranch.PageIndex");
			getOcIcBranchResponse.PageNum = _ctx.IntegerValue("GetOcIcBranch.PageNum");
			getOcIcBranchResponse.RequestId = _ctx.StringValue("GetOcIcBranch.RequestId");

			List<GetOcIcBranchResponse.GetOcIcBranch_DataItem> getOcIcBranchResponse_data = new List<GetOcIcBranchResponse.GetOcIcBranch_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIcBranch.Data.Length"); i++) {
				GetOcIcBranchResponse.GetOcIcBranch_DataItem dataItem = new GetOcIcBranchResponse.GetOcIcBranch_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcIcBranch.Data["+ i +"].EntName");
				dataItem.EntStatus = _ctx.StringValue("GetOcIcBranch.Data["+ i +"].EntStatus");
				dataItem.OperName = _ctx.StringValue("GetOcIcBranch.Data["+ i +"].OperName");
				dataItem.EsDate = _ctx.StringValue("GetOcIcBranch.Data["+ i +"].EsDate");

				getOcIcBranchResponse_data.Add(dataItem);
			}
			getOcIcBranchResponse.Data = getOcIcBranchResponse_data;
        
			return getOcIcBranchResponse;
        }
    }
}
