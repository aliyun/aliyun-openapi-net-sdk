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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeCloudSiemEventDetailResponseUnmarshaller
    {
        public static DescribeCloudSiemEventDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCloudSiemEventDetailResponse describeCloudSiemEventDetailResponse = new DescribeCloudSiemEventDetailResponse();

			describeCloudSiemEventDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeCloudSiemEventDetailResponse.Success = _ctx.BooleanValue("DescribeCloudSiemEventDetail.Success");
			describeCloudSiemEventDetailResponse.Code = _ctx.IntegerValue("DescribeCloudSiemEventDetail.Code");
			describeCloudSiemEventDetailResponse.Message = _ctx.StringValue("DescribeCloudSiemEventDetail.Message");
			describeCloudSiemEventDetailResponse.RequestId = _ctx.StringValue("DescribeCloudSiemEventDetail.RequestId");

			DescribeCloudSiemEventDetailResponse.DescribeCloudSiemEventDetail_Data data = new DescribeCloudSiemEventDetailResponse.DescribeCloudSiemEventDetail_Data();
			data.GmtCreate = _ctx.StringValue("DescribeCloudSiemEventDetail.Data.GmtCreate");
			data.GmtModified = _ctx.StringValue("DescribeCloudSiemEventDetail.Data.GmtModified");
			data.Aliuid = _ctx.LongValue("DescribeCloudSiemEventDetail.Data.Aliuid");
			data.AlertNum = _ctx.IntegerValue("DescribeCloudSiemEventDetail.Data.AlertNum");
			data.AssetNum = _ctx.IntegerValue("DescribeCloudSiemEventDetail.Data.AssetNum");
			data.IncidentUuid = _ctx.StringValue("DescribeCloudSiemEventDetail.Data.IncidentUuid");
			data.IncidentName = _ctx.StringValue("DescribeCloudSiemEventDetail.Data.IncidentName");
			data.IncidentNameEn = _ctx.StringValue("DescribeCloudSiemEventDetail.Data.IncidentNameEn");
			data.Description = _ctx.StringValue("DescribeCloudSiemEventDetail.Data.Description");
			data.DescriptionEn = _ctx.StringValue("DescribeCloudSiemEventDetail.Data.DescriptionEn");
			data.ThreatLevel = _ctx.StringValue("DescribeCloudSiemEventDetail.Data.ThreatLevel");
			data.ThreatScore = _ctx.FloatValue("DescribeCloudSiemEventDetail.Data.ThreatScore");
			data.ExtContent = _ctx.StringValue("DescribeCloudSiemEventDetail.Data.ExtContent");
			data.Status = _ctx.IntegerValue("DescribeCloudSiemEventDetail.Data.Status");
			data.Remark = _ctx.StringValue("DescribeCloudSiemEventDetail.Data.Remark");

			List<string> data_dataSources = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeCloudSiemEventDetail.Data.DataSources.Length"); i++) {
				data_dataSources.Add(_ctx.StringValue("DescribeCloudSiemEventDetail.Data.DataSources["+ i +"]"));
			}
			data.DataSources = data_dataSources;

			List<string> data_attCkLabels = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeCloudSiemEventDetail.Data.AttCkLabels.Length"); i++) {
				data_attCkLabels.Add(_ctx.StringValue("DescribeCloudSiemEventDetail.Data.AttCkLabels["+ i +"]"));
			}
			data.AttCkLabels = data_attCkLabels;
			describeCloudSiemEventDetailResponse.Data = data;
        
			return describeCloudSiemEventDetailResponse;
        }
    }
}
