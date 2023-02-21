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
    public class GetOcIpSoftwareCopyrightResponseUnmarshaller
    {
        public static GetOcIpSoftwareCopyrightResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIpSoftwareCopyrightResponse getOcIpSoftwareCopyrightResponse = new GetOcIpSoftwareCopyrightResponse();

			getOcIpSoftwareCopyrightResponse.HttpResponse = _ctx.HttpResponse;
			getOcIpSoftwareCopyrightResponse.Code = _ctx.StringValue("GetOcIpSoftwareCopyright.Code");
			getOcIpSoftwareCopyrightResponse.Success = _ctx.BooleanValue("GetOcIpSoftwareCopyright.Success");
			getOcIpSoftwareCopyrightResponse.Message = _ctx.StringValue("GetOcIpSoftwareCopyright.Message");
			getOcIpSoftwareCopyrightResponse.TotalNum = _ctx.IntegerValue("GetOcIpSoftwareCopyright.TotalNum");
			getOcIpSoftwareCopyrightResponse.PageIndex = _ctx.IntegerValue("GetOcIpSoftwareCopyright.PageIndex");
			getOcIpSoftwareCopyrightResponse.PageNum = _ctx.IntegerValue("GetOcIpSoftwareCopyright.PageNum");
			getOcIpSoftwareCopyrightResponse.RequestId = _ctx.StringValue("GetOcIpSoftwareCopyright.RequestId");

			List<GetOcIpSoftwareCopyrightResponse.GetOcIpSoftwareCopyright_DataItem> getOcIpSoftwareCopyrightResponse_data = new List<GetOcIpSoftwareCopyrightResponse.GetOcIpSoftwareCopyright_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIpSoftwareCopyright.Data.Length"); i++) {
				GetOcIpSoftwareCopyrightResponse.GetOcIpSoftwareCopyright_DataItem dataItem = new GetOcIpSoftwareCopyrightResponse.GetOcIpSoftwareCopyright_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcIpSoftwareCopyright.Data["+ i +"].EntName");
				dataItem.CopyNum = _ctx.StringValue("GetOcIpSoftwareCopyright.Data["+ i +"].CopyNum");
				dataItem.TypeNum = _ctx.StringValue("GetOcIpSoftwareCopyright.Data["+ i +"].TypeNum");
				dataItem.ShortName = _ctx.StringValue("GetOcIpSoftwareCopyright.Data["+ i +"].ShortName");
				dataItem.CopyName = _ctx.StringValue("GetOcIpSoftwareCopyright.Data["+ i +"].CopyName");
				dataItem.Version = _ctx.StringValue("GetOcIpSoftwareCopyright.Data["+ i +"].Version");
				dataItem.SuccessDate = _ctx.StringValue("GetOcIpSoftwareCopyright.Data["+ i +"].SuccessDate");
				dataItem.FirstDate = _ctx.StringValue("GetOcIpSoftwareCopyright.Data["+ i +"].FirstDate");
				dataItem.ApprovalDate = _ctx.StringValue("GetOcIpSoftwareCopyright.Data["+ i +"].ApprovalDate");

				getOcIpSoftwareCopyrightResponse_data.Add(dataItem);
			}
			getOcIpSoftwareCopyrightResponse.Data = getOcIpSoftwareCopyrightResponse_data;
        
			return getOcIpSoftwareCopyrightResponse;
        }
    }
}
