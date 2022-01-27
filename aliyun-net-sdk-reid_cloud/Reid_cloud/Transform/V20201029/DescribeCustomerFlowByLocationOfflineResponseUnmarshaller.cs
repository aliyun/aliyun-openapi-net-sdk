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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class DescribeCustomerFlowByLocationOfflineResponseUnmarshaller
    {
        public static DescribeCustomerFlowByLocationOfflineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCustomerFlowByLocationOfflineResponse describeCustomerFlowByLocationOfflineResponse = new DescribeCustomerFlowByLocationOfflineResponse();

			describeCustomerFlowByLocationOfflineResponse.HttpResponse = _ctx.HttpResponse;
			describeCustomerFlowByLocationOfflineResponse.Message = _ctx.StringValue("DescribeCustomerFlowByLocationOffline.Message");
			describeCustomerFlowByLocationOfflineResponse.RequestId = _ctx.StringValue("DescribeCustomerFlowByLocationOffline.RequestId");
			describeCustomerFlowByLocationOfflineResponse.DynamicMessage = _ctx.StringValue("DescribeCustomerFlowByLocationOffline.DynamicMessage");
			describeCustomerFlowByLocationOfflineResponse.Code = _ctx.StringValue("DescribeCustomerFlowByLocationOffline.Code");
			describeCustomerFlowByLocationOfflineResponse.Success = _ctx.BooleanValue("DescribeCustomerFlowByLocationOffline.Success");
			describeCustomerFlowByLocationOfflineResponse.StoreId = _ctx.LongValue("DescribeCustomerFlowByLocationOffline.StoreId");
			describeCustomerFlowByLocationOfflineResponse.SummaryDay = _ctx.StringValue("DescribeCustomerFlowByLocationOffline.SummaryDay");
			describeCustomerFlowByLocationOfflineResponse.DynamicCode = _ctx.StringValue("DescribeCustomerFlowByLocationOffline.DynamicCode");
			describeCustomerFlowByLocationOfflineResponse.ErrorCode = _ctx.StringValue("DescribeCustomerFlowByLocationOffline.ErrorCode");
			describeCustomerFlowByLocationOfflineResponse.ErrorMessage = _ctx.StringValue("DescribeCustomerFlowByLocationOffline.ErrorMessage");

			List<DescribeCustomerFlowByLocationOfflineResponse.DescribeCustomerFlowByLocationOffline_CustomerSummaryItem> describeCustomerFlowByLocationOfflineResponse_customerSummary = new List<DescribeCustomerFlowByLocationOfflineResponse.DescribeCustomerFlowByLocationOffline_CustomerSummaryItem>();
			for (int i = 0; i < _ctx.Length("DescribeCustomerFlowByLocationOffline.CustomerSummary.Length"); i++) {
				DescribeCustomerFlowByLocationOfflineResponse.DescribeCustomerFlowByLocationOffline_CustomerSummaryItem customerSummaryItem = new DescribeCustomerFlowByLocationOfflineResponse.DescribeCustomerFlowByLocationOffline_CustomerSummaryItem();
				customerSummaryItem.SummaryStartTime = _ctx.LongValue("DescribeCustomerFlowByLocationOffline.CustomerSummary["+ i +"].SummaryStartTime");
				customerSummaryItem.SummaryEndTime = _ctx.LongValue("DescribeCustomerFlowByLocationOffline.CustomerSummary["+ i +"].SummaryEndTime");

				List<DescribeCustomerFlowByLocationOfflineResponse.DescribeCustomerFlowByLocationOffline_CustomerSummaryItem.DescribeCustomerFlowByLocationOffline_CustomerFlow> customerSummaryItem_customerFlows = new List<DescribeCustomerFlowByLocationOfflineResponse.DescribeCustomerFlowByLocationOffline_CustomerSummaryItem.DescribeCustomerFlowByLocationOffline_CustomerFlow>();
				for (int j = 0; j < _ctx.Length("DescribeCustomerFlowByLocationOffline.CustomerSummary["+ i +"].CustomerFlows.Length"); j++) {
					DescribeCustomerFlowByLocationOfflineResponse.DescribeCustomerFlowByLocationOffline_CustomerSummaryItem.DescribeCustomerFlowByLocationOffline_CustomerFlow customerFlow = new DescribeCustomerFlowByLocationOfflineResponse.DescribeCustomerFlowByLocationOffline_CustomerSummaryItem.DescribeCustomerFlowByLocationOffline_CustomerFlow();
					customerFlow.CurrentLocationId = _ctx.LongValue("DescribeCustomerFlowByLocationOffline.CustomerSummary["+ i +"].CustomerFlows["+ j +"].CurrentLocationId");
					customerFlow.Count = _ctx.LongValue("DescribeCustomerFlowByLocationOffline.CustomerSummary["+ i +"].CustomerFlows["+ j +"].Count");

					List<DescribeCustomerFlowByLocationOfflineResponse.DescribeCustomerFlowByLocationOffline_CustomerSummaryItem.DescribeCustomerFlowByLocationOffline_CustomerFlow.DescribeCustomerFlowByLocationOffline_CustomerFlowItem> customerFlow_customerFlowItems = new List<DescribeCustomerFlowByLocationOfflineResponse.DescribeCustomerFlowByLocationOffline_CustomerSummaryItem.DescribeCustomerFlowByLocationOffline_CustomerFlow.DescribeCustomerFlowByLocationOffline_CustomerFlowItem>();
					for (int k = 0; k < _ctx.Length("DescribeCustomerFlowByLocationOffline.CustomerSummary["+ i +"].CustomerFlows["+ j +"].CustomerFlowItems.Length"); k++) {
						DescribeCustomerFlowByLocationOfflineResponse.DescribeCustomerFlowByLocationOffline_CustomerSummaryItem.DescribeCustomerFlowByLocationOffline_CustomerFlow.DescribeCustomerFlowByLocationOffline_CustomerFlowItem customerFlowItem = new DescribeCustomerFlowByLocationOfflineResponse.DescribeCustomerFlowByLocationOffline_CustomerSummaryItem.DescribeCustomerFlowByLocationOffline_CustomerFlow.DescribeCustomerFlowByLocationOffline_CustomerFlowItem();
						customerFlowItem.LocationId = _ctx.LongValue("DescribeCustomerFlowByLocationOffline.CustomerSummary["+ i +"].CustomerFlows["+ j +"].CustomerFlowItems["+ k +"].LocationId");

						List<string> customerFlowItem_ukId = new List<string>();
						for (int l = 0; l < _ctx.Length("DescribeCustomerFlowByLocationOffline.CustomerSummary["+ i +"].CustomerFlows["+ j +"].CustomerFlowItems["+ k +"].UkId.Length"); l++) {
							customerFlowItem_ukId.Add(_ctx.StringValue("DescribeCustomerFlowByLocationOffline.CustomerSummary["+ i +"].CustomerFlows["+ j +"].CustomerFlowItems["+ k +"].UkId["+ l +"]"));
						}
						customerFlowItem.UkId = customerFlowItem_ukId;

						customerFlow_customerFlowItems.Add(customerFlowItem);
					}
					customerFlow.CustomerFlowItems = customerFlow_customerFlowItems;

					customerSummaryItem_customerFlows.Add(customerFlow);
				}
				customerSummaryItem.CustomerFlows = customerSummaryItem_customerFlows;

				describeCustomerFlowByLocationOfflineResponse_customerSummary.Add(customerSummaryItem);
			}
			describeCustomerFlowByLocationOfflineResponse.CustomerSummary = describeCustomerFlowByLocationOfflineResponse_customerSummary;
        
			return describeCustomerFlowByLocationOfflineResponse;
        }
    }
}
