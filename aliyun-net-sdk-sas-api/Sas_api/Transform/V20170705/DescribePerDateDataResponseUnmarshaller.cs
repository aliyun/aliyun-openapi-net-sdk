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
using Aliyun.Acs.Sas_api.Model.V20170705;

namespace Aliyun.Acs.Sas_api.Transform.V20170705
{
    public class DescribePerDateDataResponseUnmarshaller
    {
        public static DescribePerDateDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePerDateDataResponse describePerDateDataResponse = new DescribePerDateDataResponse();

			describePerDateDataResponse.HttpResponse = context.HttpResponse;
			describePerDateDataResponse.RequestId = context.StringValue("DescribePerDateData.RequestId");

			List<DescribePerDateDataResponse.DescribePerDateData_DataViewItem> describePerDateDataResponse_dataView = new List<DescribePerDateDataResponse.DescribePerDateData_DataViewItem>();
			for (int i = 0; i < context.Length("DescribePerDateData.DataView.Length"); i++) {
				DescribePerDateDataResponse.DescribePerDateData_DataViewItem dataViewItem = new DescribePerDateDataResponse.DescribePerDateData_DataViewItem();
				dataViewItem.DataTime = context.StringValue("DescribePerDateData.DataView["+ i +"].DataTime");
				dataViewItem.CallTimes = context.LongValue("DescribePerDateData.DataView["+ i +"].CallTimes");
				dataViewItem.TotalHit = context.LongValue("DescribePerDateData.DataView["+ i +"].TotalHit");
				dataViewItem.HitRate = context.LongValue("DescribePerDateData.DataView["+ i +"].HitRate");
				dataViewItem.IsGreyPhone = context.LongValue("DescribePerDateData.DataView["+ i +"].IsGreyPhone");
				dataViewItem.IsBlackPhone = context.LongValue("DescribePerDateData.DataView["+ i +"].IsBlackPhone");
				dataViewItem.IsVirtualOperator = context.LongValue("DescribePerDateData.DataView["+ i +"].IsVirtualOperator");
				dataViewItem.IsOpenCommonPort1d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsOpenCommonPort1d");
				dataViewItem.IsOpenCommonPort7d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsOpenCommonPort7d");
				dataViewItem.IsOpenCommonPort30d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsOpenCommonPort30d");
				dataViewItem.IsCheatFlow1d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsCheatFlow1d");
				dataViewItem.IsCheatFlow7d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsCheatFlow7d");
				dataViewItem.IsCheatFlow30d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsCheatFlow30d");
				dataViewItem.IsProxy1d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsProxy1d");
				dataViewItem.IsProxy7d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsProxy7d");
				dataViewItem.IsProxy30d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsProxy30d");
				dataViewItem.IsHiJack1d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsHiJack1d");
				dataViewItem.IsHiJack7d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsHiJack7d");
				dataViewItem.IsHiJack30d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsHiJack30d");
				dataViewItem.IsC21d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsC21d");
				dataViewItem.IsC27d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsC27d");
				dataViewItem.IsC230d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsC230d");
				dataViewItem.IsBotnet1d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsBotnet1d");
				dataViewItem.IsBotnet7d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsBotnet7d");
				dataViewItem.IsBotnet30d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsBotnet30d");
				dataViewItem.IsNetAttack1d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsNetAttack1d");
				dataViewItem.IsNetAttack7d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsNetAttack7d");
				dataViewItem.IsNetAttack30d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsNetAttack30d");
				dataViewItem.IsBlackCampaign1d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsBlackCampaign1d");
				dataViewItem.IsBlackCampaign7d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsBlackCampaign7d");
				dataViewItem.IsBlackCampaign30d = context.LongValue("DescribePerDateData.DataView["+ i +"].IsBlackCampaign30d");

				describePerDateDataResponse_dataView.Add(dataViewItem);
			}
			describePerDateDataResponse.DataView = describePerDateDataResponse_dataView;
        
			return describePerDateDataResponse;
        }
    }
}
