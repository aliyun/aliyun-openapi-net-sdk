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
    public class GetOcOperationRecruitmentResponseUnmarshaller
    {
        public static GetOcOperationRecruitmentResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOcOperationRecruitmentResponse getOcOperationRecruitmentResponse = new GetOcOperationRecruitmentResponse();

			getOcOperationRecruitmentResponse.HttpResponse = _ctx.HttpResponse;
			getOcOperationRecruitmentResponse.Code = _ctx.StringValue("GetOcOperationRecruitment.Code");
			getOcOperationRecruitmentResponse.Success = _ctx.BooleanValue("GetOcOperationRecruitment.Success");
			getOcOperationRecruitmentResponse.Message = _ctx.StringValue("GetOcOperationRecruitment.Message");
			getOcOperationRecruitmentResponse.TotalNum = _ctx.IntegerValue("GetOcOperationRecruitment.TotalNum");
			getOcOperationRecruitmentResponse.PageIndex = _ctx.IntegerValue("GetOcOperationRecruitment.PageIndex");
			getOcOperationRecruitmentResponse.PageNum = _ctx.IntegerValue("GetOcOperationRecruitment.PageNum");
			getOcOperationRecruitmentResponse.RequestId = _ctx.StringValue("GetOcOperationRecruitment.RequestId");

			List<GetOcOperationRecruitmentResponse.GetOcOperationRecruitment_DataItem> getOcOperationRecruitmentResponse_data = new List<GetOcOperationRecruitmentResponse.GetOcOperationRecruitment_DataItem>();
			for (int i = 0; i < _ctx.Length("GetOcOperationRecruitment.Data.Length"); i++) {
				GetOcOperationRecruitmentResponse.GetOcOperationRecruitment_DataItem dataItem = new GetOcOperationRecruitmentResponse.GetOcOperationRecruitment_DataItem();
				dataItem.EntName = _ctx.StringValue("GetOcOperationRecruitment.Data["+ i +"].EntName");
				dataItem.RecruitingName = _ctx.StringValue("GetOcOperationRecruitment.Data["+ i +"].RecruitingName");
				dataItem.Description = _ctx.StringValue("GetOcOperationRecruitment.Data["+ i +"].Description");
				dataItem.Salary = _ctx.StringValue("GetOcOperationRecruitment.Data["+ i +"].Salary");
				dataItem.RecruitingAddress = _ctx.StringValue("GetOcOperationRecruitment.Data["+ i +"].RecruitingAddress");
				dataItem.Education = _ctx.StringValue("GetOcOperationRecruitment.Data["+ i +"].Education");
				dataItem.Experience = _ctx.StringValue("GetOcOperationRecruitment.Data["+ i +"].Experience");
				dataItem.BenefitList = _ctx.StringValue("GetOcOperationRecruitment.Data["+ i +"].BenefitList");
				dataItem.PublishDate = _ctx.StringValue("GetOcOperationRecruitment.Data["+ i +"].PublishDate");
				dataItem.StartDate = _ctx.StringValue("GetOcOperationRecruitment.Data["+ i +"].StartDate");
				dataItem.EndDate = _ctx.StringValue("GetOcOperationRecruitment.Data["+ i +"].EndDate");
				dataItem.PageUrl = _ctx.StringValue("GetOcOperationRecruitment.Data["+ i +"].PageUrl");

				getOcOperationRecruitmentResponse_data.Add(dataItem);
			}
			getOcOperationRecruitmentResponse.Data = getOcOperationRecruitmentResponse_data;
        
			return getOcOperationRecruitmentResponse;
        }
    }
}
