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
    public class GetOcIpWorksCopyrightResponseUnmarshaller
    {
        public static GetOcIpWorksCopyrightResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcIpWorksCopyrightResponse getOcIpWorksCopyrightResponse = new GetOcIpWorksCopyrightResponse();

			getOcIpWorksCopyrightResponse.HttpResponse = _ctx.HttpResponse;
			getOcIpWorksCopyrightResponse.Code = _ctx.StringValue("GetOcIpWorksCopyright.Code");
			getOcIpWorksCopyrightResponse.Success = _ctx.BooleanValue("GetOcIpWorksCopyright.Success");
			getOcIpWorksCopyrightResponse.Message = _ctx.StringValue("GetOcIpWorksCopyright.Message");
			getOcIpWorksCopyrightResponse.TotalNum = _ctx.IntegerValue("GetOcIpWorksCopyright.TotalNum");
			getOcIpWorksCopyrightResponse.PageIndex = _ctx.IntegerValue("GetOcIpWorksCopyright.PageIndex");
			getOcIpWorksCopyrightResponse.PageNum = _ctx.IntegerValue("GetOcIpWorksCopyright.PageNum");
			getOcIpWorksCopyrightResponse.RequestId = _ctx.StringValue("GetOcIpWorksCopyright.RequestId");

			List<GetOcIpWorksCopyrightResponse.GetOcIpWorksCopyright_DataItem> getOcIpWorksCopyrightResponse_data = new List<GetOcIpWorksCopyrightResponse.GetOcIpWorksCopyright_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcIpWorksCopyright.Data.Length"); i++) {
				GetOcIpWorksCopyrightResponse.GetOcIpWorksCopyright_DataItem dataItem = new GetOcIpWorksCopyrightResponse.GetOcIpWorksCopyright_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcIpWorksCopyright.Data["+ i +"].EntName");
				dataItem.CopyName = _ctx.StringValue("GetOcIpWorksCopyright.Data["+ i +"].CopyName");
				dataItem.TypeName = _ctx.StringValue("GetOcIpWorksCopyright.Data["+ i +"].TypeName");
				dataItem.CopyNum = _ctx.StringValue("GetOcIpWorksCopyright.Data["+ i +"].CopyNum");
				dataItem.SuccessDate = _ctx.StringValue("GetOcIpWorksCopyright.Data["+ i +"].SuccessDate");
				dataItem.FirstDate = _ctx.StringValue("GetOcIpWorksCopyright.Data["+ i +"].FirstDate");
				dataItem.ApprovalDate = _ctx.StringValue("GetOcIpWorksCopyright.Data["+ i +"].ApprovalDate");

				getOcIpWorksCopyrightResponse_data.Add(dataItem);
			}
			getOcIpWorksCopyrightResponse.Data = getOcIpWorksCopyrightResponse_data;
        
			return getOcIpWorksCopyrightResponse;
        }
    }
}
