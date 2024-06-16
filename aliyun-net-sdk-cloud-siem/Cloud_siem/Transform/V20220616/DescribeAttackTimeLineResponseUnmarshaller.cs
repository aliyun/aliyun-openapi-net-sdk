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
    public class DescribeAttackTimeLineResponseUnmarshaller
    {
        public static DescribeAttackTimeLineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAttackTimeLineResponse describeAttackTimeLineResponse = new DescribeAttackTimeLineResponse();

			describeAttackTimeLineResponse.HttpResponse = _ctx.HttpResponse;
			describeAttackTimeLineResponse.Success = _ctx.BooleanValue("DescribeAttackTimeLine.Success");
			describeAttackTimeLineResponse.Code = _ctx.IntegerValue("DescribeAttackTimeLine.Code");
			describeAttackTimeLineResponse.Message = _ctx.StringValue("DescribeAttackTimeLine.Message");
			describeAttackTimeLineResponse.RequestId = _ctx.StringValue("DescribeAttackTimeLine.RequestId");

			List<DescribeAttackTimeLineResponse.DescribeAttackTimeLine_DataItem> describeAttackTimeLineResponse_data = new List<DescribeAttackTimeLineResponse.DescribeAttackTimeLine_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeAttackTimeLine.Data.Length"); i++) {
				DescribeAttackTimeLineResponse.DescribeAttackTimeLine_DataItem dataItem = new DescribeAttackTimeLineResponse.DescribeAttackTimeLine_DataItem();
				dataItem.AssetName = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AssetName");
				dataItem.AlertTime = _ctx.LongValue("DescribeAttackTimeLine.Data["+ i +"].AlertTime");
				dataItem.AssetId = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AssetId");
				dataItem.IncidentUuid = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].IncidentUuid");
				dataItem.AlertUuid = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AlertUuid");
				dataItem.LogTime = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].LogTime");
				dataItem.AlertSrcProd = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AlertSrcProd");
				dataItem.AlertTitle = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AlertTitle");
				dataItem.AlertLevel = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AlertLevel");
				dataItem.AssetList = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AssetList");
				dataItem.AlertSrcProdModule = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AlertSrcProdModule");
				dataItem.AttCk = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AttCk");
				dataItem.CloudCode = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].CloudCode");
				dataItem.AlertTitleEn = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AlertTitleEn");
				dataItem.AlertType = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AlertType");
				dataItem.AlertTypeEn = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AlertTypeEn");
				dataItem.AlertTypeCode = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AlertTypeCode");
				dataItem.AlertName = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AlertName");
				dataItem.AlertNameEn = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AlertNameEn");
				dataItem.AlertNameCode = _ctx.StringValue("DescribeAttackTimeLine.Data["+ i +"].AlertNameCode");

				describeAttackTimeLineResponse_data.Add(dataItem);
			}
			describeAttackTimeLineResponse.Data = describeAttackTimeLineResponse_data;
        
			return describeAttackTimeLineResponse;
        }
    }
}
